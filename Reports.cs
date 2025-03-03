using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Training_Fee_Calculation_System;

namespace TrainingFeeSystem
{
    public partial class Reports : Form
    {
        private string connectionString = ApplicationSettings.ConnetionString();

        public Reports()
        {
            InitializeComponent();
            LoadReportOptions();
        }

        private void LoadReportOptions()
        {
            cmbReport.Items.Add("Total Revenue by Month");
            cmbReport.Items.Add("Detailed Invoice Report");
            cmbReport.Items.Add("Yearly Total Revenue per Athlete");
            cmbReport.Items.Add("Top 10 Most Expensive Invoices");
            cmbReport.Items.Add("Invoice Count by Month");            
            cmbReport.SelectedIndex = 0; // Default selection
        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData(cmbReport.SelectedItem.ToString());
        }

        private void LoadReportData(string reportType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "";

                switch (reportType)
                {
                    case "Total Revenue by Month":
                        query = "SELECT [Month], SUM([TotalCost]) AS TotalRevenue " +
                                "FROM [Invoice] " +
                                "GROUP BY [Month] " +
                                "ORDER BY [Month]";
                        break;
                    case "Detailed Invoice Report":
                        query = "SELECT [InvoiceID], [Date], [Month], [TotalCost] As 'Total cost', A.[Name] AS 'Athlete Name' FROM [Invoice] I JOIN [Athlete] A ON I.AthleteID = A.AthleteID ORDER BY [Date] DESC";
                        break;                    
                    case "Yearly Total Revenue per Athlete":
                        query = "SELECT A.[Name] AS 'Athlete Name', SUM([TotalCost]) AS TotalRevenue FROM [Invoice] I JOIN [Athlete] A ON I.AthleteID = A.AthleteID WHERE YEAR([Date]) = YEAR(GETDATE()) GROUP BY Name ORDER BY TotalRevenue DESC";
                        break;
                    case "Top 10 Most Expensive Invoices":
                        query = "SELECT TOP 10 [InvoiceID], [Date], [Month], [TotalCost], A.[Name] AS 'Athlete Name' FROM [Invoice] I JOIN [Athlete] A ON I.AthleteID = A.AthleteID ORDER BY [TotalCost] DESC";
                        break;
                    case "Invoice Count by Month":
                        query = "SELECT [Month], COUNT([InvoiceID]) AS InvoiceCount " +
                                "FROM [KickBlast].[dbo].[Invoice] " +
                                "GROUP BY [Month] " +
                                "ORDER BY [Month]";
                        break;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewReport.DataSource = dt;
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }

        private void ExportToPdf()
        {
            if (dataGridViewReport.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Report.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    PdfPTable pdfTable = new PdfPTable(dataGridViewReport.Columns.Count);

                    // Adding table headers
                    foreach (DataGridViewColumn column in dataGridViewReport.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        pdfTable.AddCell(cell);
                    }

                    // Adding rows
                    foreach (DataGridViewRow row in dataGridViewReport.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                }

                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
