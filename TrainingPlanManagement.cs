using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Training_Fee_Calculation_System
{
    public partial class TrainingPlanManagement : Form
    {
        private string connectionString = ApplicationSettings.ConnetionString(); // Update with your database connection string

        public TrainingPlanManagement()
        {
            InitializeComponent();
        }

        private void TrainingPlanManagement_Load(object sender, EventArgs e)
        {
            RefreshTrainingPlans(); // Load training plans on form load
        }

        // Method to refresh the training plans in the DataGridView
        private void RefreshTrainingPlans()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TrainingPlanID, PlanName AS 'Training Plan Name', MaxPrivateCoachingHours AS 'Max Private Coaching Hours', CostPerWeek AS 'Cost per Week' FROM TrainingPlan";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTrainingPlans.DataSource = dt; // Bind to DataGridView
                    dgvTrainingPlans.Columns["TrainingPlanID"].Visible = false; //hide Id column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading training plans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to add a new training plan
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string planName = txtPlanName.Text;
            int maxHours;
            decimal costPerWeek;

            // Validation checks for empty fields and invalid data
            if (string.IsNullOrEmpty(planName))
            {
                MessageBox.Show("Plan Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMaxPrivateCoachingHours.Text, out maxHours) || maxHours <= 0)
            {
                MessageBox.Show("Please enter a valid number for Max Private Coaching Hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtCostPerWeek.Text, out costPerWeek) || costPerWeek <= 0)
            {
                MessageBox.Show("Please enter a valid cost per week.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO TrainingPlan (PlanName, MaxPrivateCoachingHours, CostPerWeek) VALUES (@PlanName, @MaxHours, @CostPerWeek)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PlanName", planName);
                    cmd.Parameters.AddWithValue("@MaxHours", maxHours);
                    cmd.Parameters.AddWithValue("@CostPerWeek", costPerWeek);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Training Plan added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();//trigger clear button to clear inputs
                    RefreshTrainingPlans(); // Refresh the list after adding
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding training plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to update an existing training plan
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTrainingPlans.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a training plan to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int trainingPlanID = Convert.ToInt32(dgvTrainingPlans.SelectedRows[0].Cells[0].Value);
            string planName = txtPlanName.Text;
            int maxHours;
            decimal costPerWeek;

            // Validation checks for empty fields and invalid data
            if (string.IsNullOrEmpty(planName))
            {
                MessageBox.Show("Plan Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMaxPrivateCoachingHours.Text, out maxHours) || maxHours <= 0)
            {
                MessageBox.Show("Please enter a valid number for Max Private Coaching Hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtCostPerWeek.Text, out costPerWeek) || costPerWeek <= 0)
            {
                MessageBox.Show("Please enter a valid cost per week.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE TrainingPlan SET PlanName = @PlanName, MaxPrivateCoachingHours = @MaxHours, CostPerWeek = @CostPerWeek WHERE TrainingPlanID = @TrainingPlanID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PlanName", planName);
                    cmd.Parameters.AddWithValue("@MaxHours", maxHours);
                    cmd.Parameters.AddWithValue("@CostPerWeek", costPerWeek);
                    cmd.Parameters.AddWithValue("@TrainingPlanID", trainingPlanID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Training Plan updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();//trigger clear button to clear inputs
                    RefreshTrainingPlans(); // Refresh the list after updating
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating training plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to delete a training plan
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrainingPlans.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a training plan to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int trainingPlanID = Convert.ToInt32(dgvTrainingPlans.SelectedRows[0].Cells[0].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this training plan?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM TrainingPlan WHERE TrainingPlanID = @TrainingPlanID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@TrainingPlanID", trainingPlanID);
                        cmd.ExecuteNonQuery();
                        btnClear.PerformClick();//trigger clear button to clear inputs
                        MessageBox.Show("Training Plan deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshTrainingPlans(); // Refresh the list after deleting
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting training plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to clear input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlanName.Clear();
            txtMaxPrivateCoachingHours.Clear();
            txtCostPerWeek.Clear();
        }

        private void dgvTrainingPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = dgvTrainingPlans.Rows[e.RowIndex];

                // Populate the textboxes with the selected row's values
                txtPlanName.Text = row.Cells["Training Plan Name"].Value.ToString();
                txtMaxPrivateCoachingHours.Text = row.Cells["Max Private Coaching Hours"].Value.ToString();
                txtCostPerWeek.Text = row.Cells["Cost per Week"].Value.ToString();
                                
            }
        }
    }
}
