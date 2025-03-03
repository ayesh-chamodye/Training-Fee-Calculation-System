using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Training_Fee_Calculation_System
{
    public partial class CompetitionManagement : Form
    {
        public CompetitionManagement()
        {
            InitializeComponent();
            LoadCompetitions();
        }

        // Connection string to the database
        private string connectionString = ApplicationSettings.ConnetionString();

        // Load the existing competitions into DataGridView
        private void LoadCompetitions()
        {
            string query = "SELECT [CompetitionID], [Name], [Date], [WeightCategory], [CostPerCompetition] FROM [dbo].[Competition]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCompetitions.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading competitions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Add a new competition
        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompetitionName.Text) || string.IsNullOrEmpty(txtWeightCategory.Text) || string.IsNullOrEmpty(txtCostPerCompetition.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal costPerCompetition;
            if (!decimal.TryParse(txtCostPerCompetition.Text, out costPerCompetition))
            {
                MessageBox.Show("Please enter a valid cost per competition.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO [dbo].[Competition] (Name, Date, WeightCategory, CostPerCompetition) VALUES (@Name, @Date, @WeightCategory, @CostPerCompetition)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtCompetitionName.Text);
                        cmd.Parameters.AddWithValue("@Date", dtpCompetitionDate.Value);
                        cmd.Parameters.AddWithValue("@WeightCategory", txtWeightCategory.Text);
                        cmd.Parameters.AddWithValue("@CostPerCompetition", costPerCompetition);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Competition added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadCompetitions();
                        }
                        else
                        {
                            MessageBox.Show("Error adding competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update an existing competition
        private void btnUpdateCompetition_Click(object sender, EventArgs e)
        {
            if (dgvCompetitions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a competition to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCompetitionName.Text) || string.IsNullOrEmpty(txtWeightCategory.Text) || string.IsNullOrEmpty(txtCostPerCompetition.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal costPerCompetition;
            if (!decimal.TryParse(txtCostPerCompetition.Text, out costPerCompetition))
            {
                MessageBox.Show("Please enter a valid cost per competition.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int competitionID = (int)dgvCompetitions.SelectedRows[0].Cells["CompetitionID"].Value;

            string query = "UPDATE [dbo].[Competition] SET Name = @Name, Date = @Date, WeightCategory = @WeightCategory, CostPerCompetition = @CostPerCompetition WHERE CompetitionID = @CompetitionID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompetitionID", competitionID);
                        cmd.Parameters.AddWithValue("@Name", txtCompetitionName.Text);
                        cmd.Parameters.AddWithValue("@Date", dtpCompetitionDate.Value);
                        cmd.Parameters.AddWithValue("@WeightCategory", txtWeightCategory.Text);
                        cmd.Parameters.AddWithValue("@CostPerCompetition", costPerCompetition);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Competition updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadCompetitions();
                        }
                        else
                        {
                            MessageBox.Show("Error updating competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete a competition
        private void btnDeleteCompetition_Click(object sender, EventArgs e)
        {
            if (dgvCompetitions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a competition to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int competitionID = (int)dgvCompetitions.SelectedRows[0].Cells["CompetitionID"].Value;

            string query = "DELETE FROM [dbo].[Competition] WHERE CompetitionID = @CompetitionID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompetitionID", competitionID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Competition deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadCompetitions();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fill the fields with selected competition details
        private void dgvCompetitions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCompetitions.Rows[e.RowIndex];
                txtCompetitionName.Text = row.Cells["Name"].Value.ToString();
                txtWeightCategory.Text = row.Cells["WeightCategory"].Value.ToString();
                txtCostPerCompetition.Text = row.Cells["CostPerCompetition"].Value.ToString();
                dtpCompetitionDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }
        }

        // Clear the input fields
        private void ClearFields()
        {
            txtCompetitionName.Clear();
            txtWeightCategory.Clear();
            txtCostPerCompetition.Clear();
            dtpCompetitionDate.Value = DateTime.Now;
        }
    }
}
