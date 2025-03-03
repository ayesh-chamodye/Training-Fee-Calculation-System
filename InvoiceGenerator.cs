using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Training_Fee_Calculation_System
{
    public partial class InvoiceGenerator : Form
    {
        private string connectionString = ApplicationSettings.ConnetionString(); // Replace with actual connection string

        public InvoiceGenerator()
        {
            InitializeComponent();
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT I.InvoiceID, A.Name AS Athlete, I.Month, I.TotalCost, I.Date
                        FROM Invoice I
                        JOIN Athlete A ON I.AthleteID = A.AthleteID
                        ORDER BY I.Date DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvInvoices.DataSource = dt;
                        }
                    }
                }

                FormatGridView();
            }
            catch (Exception ex)
            {
                Clipboard.SetText(ex.ToString());
                MessageBox.Show("Error loading invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridView()
        {
            dgvInvoices.Columns["InvoiceID"].Visible = false; // Hide ID column
            dgvInvoices.Columns["Athlete"].HeaderText = "Athlete Name";
            dgvInvoices.Columns["Month"].HeaderText = "Month";
            dgvInvoices.Columns["TotalCost"].HeaderText = "Total Cost (Rs.)";
            dgvInvoices.Columns["Date"].HeaderText = "Invoice Date";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadInvoices();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT I.InvoiceID, A.Name AS Athlete, I.Month, I.TotalCost, I.InvoiceDate
                        FROM Invoice I
                        JOIN Athlete A ON I.AthleteID = A.AthleteID
                        WHERE A.Name LIKE @SearchText OR I.Month LIKE @SearchText
                        ORDER BY I.InvoiceDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvInvoices.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an invoice to export.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int invoiceID = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
            ExportInvoiceToPDF(invoiceID);
        }
        private DataTable GetInvoiceDetails(int invoiceID)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            I.InvoiceID, 
            A.Name AS AthleteName, 
            I.Month, 
            I.Date AS InvoiceDate, 
            TP.PlanName AS TrainingPlan, 
            TP.CostPerWeek * 4 AS TrainingPlanCost, 
            (SELECT SUM(C.CostPerCompetition) 
             FROM Competition C 
             JOIN AthleteCompetition AC ON C.CompetitionID = AC.CompetitionID 
             WHERE AC.AthleteID = A.AthleteID) AS CompetitionCost, 
            I.TotalCost 
        FROM Invoice I
        JOIN Athlete A ON I.AthleteID = A.AthleteID
        LEFT JOIN AthleteTrainingPlan ATP ON A.AthleteID = ATP.AthleteID
        LEFT JOIN TrainingPlan TP ON ATP.TrainingPlanID = TP.TrainingPlanID
        WHERE I.InvoiceID = @InvoiceID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving invoice details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        private void ExportInvoiceToPDF(int invoiceID)
        {
            DataTable dt = GetInvoiceDetails(invoiceID);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No invoice details found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "Save Invoice",
                FileName = "Invoice_" + invoiceID + ".pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, stream);
                        doc.Open();

                        // Add Title
                        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        Paragraph title = new Paragraph("Invoice / Payment Bill", titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(title);
                        doc.Add(new Paragraph("\n"));

                        // Add Invoice Details
                        DataRow row = dt.Rows[0];
                        doc.Add(new Paragraph($"Invoice ID: {row["InvoiceID"]}"));
                        doc.Add(new Paragraph($"Athlete: {row["AthleteName"]}"));
                        doc.Add(new Paragraph($"Month: {row["Month"]}"));
                        doc.Add(new Paragraph($"Date: {Convert.ToDateTime(row["InvoiceDate"]).ToShortDateString()}"));
                        doc.Add(new Paragraph("\n"));

                        // Add Payment Breakdown
                        PdfPTable table = new PdfPTable(2);
                        table.WidthPercentage = 100;
                        table.AddCell("Description");
                        table.AddCell("Amount (Rs.)");

                        table.AddCell("Training Plan");
                        table.AddCell(row["TrainingPlanCost"].ToString());

                        table.AddCell("Competition Fees");
                        table.AddCell(row["CompetitionCost"] != DBNull.Value ? row["CompetitionCost"].ToString() : "0");

                        table.AddCell("Total Cost");
                        table.AddCell(row["TotalCost"].ToString());

                        doc.Add(table);
                        doc.Add(new Paragraph("\n\n"));

                        // Thank You Message
                        Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                        Paragraph footer = new Paragraph("Thank you for your payment!", footerFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(footer);

                        doc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Invoice exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
            }
        }

    }
}
