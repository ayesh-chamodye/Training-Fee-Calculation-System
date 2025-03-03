using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Training_Fee_Calculation_System
{
    public partial class AthleteManagement : Form
    {
        public AthleteManagement()
        {
            InitializeComponent();
        }

        private void AthleteManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickBlastDataSet1.TrainingPlan' table. You can move, or remove it, as needed.
            this.trainingPlanTableAdapter.Fill(this.kickBlastDataSet1.TrainingPlan);
            // TODO: This line of code loads data into the 'kickBlastDataSet.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.kickBlastDataSet.Branch);
            LoadAthletes($"SELECT atp.TrainingPlanID,a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%';");// Assuming table Athletes
            
            
        }


        private void LoadAthletes(string query)
        {
            try { 
            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAthletes.DataSource = dt;
                dgvAthletes.Columns["Athlete ID"].Visible = false;//hide ID
                dgvAthletes.Columns["BranchID"].Visible = false;//hide ID
                dgvAthletes.Columns["TrainingPlanID"].Visible = false;//hide ID
                }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Clipboard.SetText(ex.ToString());
            }
        }

        // Add a new athlete
        private void btnAddAthlete_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            string name = txtName.Text.Trim();
            DateTime dob = dtDOB.Value.Date;
            string current_weight = txtCurrentWeight.Text.Trim();            
            string competition_weight = txtCampeignWeight.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string contact_no = txtContact.Text.Trim();
            string branchID = cmbBranch.SelectedValue.ToString();

            try
            {
                //Confirmation message
                DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
                    {
                        conn.Open();
                        string query = $"INSERT INTO [dbo].[Athlete] ([Name],[DOB],[Address],[ContactNo],[CurrentWeight],[CompetitionWeight],[BranchID])VALUES('{name}','{dob}','{Address}','{contact_no}','{current_weight}','{competition_weight}','{branchID}'); SELECT SCOPE_IDENTITY();";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int athleteID = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show($"{name} Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateTrainingPlan(athleteID);
                    }
                }
                ClearEntries();//clear inputs
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAthletes($"SELECT atp.TrainingPlanID,a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%';"); // Refresh the data
            
        }

        // Edit an existing athlete's details
        private void btnEditAthlete_Click(object sender, EventArgs e)
        {

            if (!ValidateFields())
            {
                return;
            }

            //Confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dgvAthletes.SelectedRows.Count > 0 && result == DialogResult.Yes)
            {
                
                string name = txtName.Text.Trim();
                DateTime dob = dtDOB.Value.Date;
                string current_weight = txtCurrentWeight.Text.Trim();                
                string competition_weight = txtCampeignWeight.Text.Trim();
                string Address = txtAddress.Text.Trim();
                string contact_no = txtContact.Text.Trim();
                string branchID = cmbBranch.SelectedValue.ToString();
                try
                {
                    using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
                    {
                        conn.Open();
                        string query = $"UPDATE [dbo].[Athlete] SET [Name] = '{name}', [DOB] = '{dob}', [Address] = '{Address}', [ContactNo] = '{contact_no}', [CurrentWeight] = '{current_weight}', [CompetitionWeight] = '{competition_weight}', [BranchID] = '{branchID}' WHERE [AthleteID] = {athleteID}";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{name} Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateTrainingPlan(athleteID);
                        LoadAthletes($"SELECT atp.TrainingPlanID,a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%';"); // Refresh the data
                    }
                    ClearEntries();//clear inputs
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        // Delete an athlete
        private void btnDeleteAthlete_Click(object sender, EventArgs e)
        {
            //Confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dgvAthletes.SelectedRows.Count > 0 && result == DialogResult.Yes)
            {
                string name = txtName.Text;
                try
                {
                    

                    using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
                    {
                        conn.Open();
                        string query = "DELETE FROM Athlete WHERE AthleteID = @AthleteID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@AthleteID",athleteID );

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{name} Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearEntries();//clear input fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadAthletes($"SELECT atp.TrainingPlanID,a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%'"); // Refresh the data
            }
        }

        private void ClearEntries()
        {
            //clear inputs
            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtCampeignWeight.Clear();
            txtCurrentWeight.Clear();
            dtDOB.Value = DateTime.Now;
            cmbBranch.SelectedIndex = 0;
        }
        private int athleteID;
        private void dgvAthletes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex >= 0) // Ensure a valid row is clicked
                {
                    DataGridViewRow row = dgvAthletes.Rows[e.RowIndex];

                    txtName.Text = row.Cells["Name"].Value.ToString().Trim();
                    athleteID = Convert.ToInt32(row.Cells["Athlete ID"].Value);
                    dtDOB.Value = Convert.ToDateTime(row.Cells["Date of Birth"].Value);
                    txtCurrentWeight.Text = row.Cells["Current Weight"].Value.ToString().Trim();
                    txtCampeignWeight.Text = row.Cells["Competition Weight"].Value.ToString().Trim();
                    txtAddress.Text = row.Cells["Address"].Value.ToString().Trim();
                    txtContact.Text = row.Cells["Contact Number"].Value.ToString().Trim();
                    cmbBranch.SelectedValue = row.Cells["BranchID"].Value.ToString().Trim();                    
                    cbTrainingPlans.SelectedValue = row.Cells["TrainingPlanID"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEntries();//clear inputs
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAthletes($"SELECT atp.TrainingPlanID,a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%';");            
        }


        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtDOB.Value == null || dtDOB.Value.Date == DateTime.MinValue)
            {
                MessageBox.Show("Please select a valid Date of Birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCurrentWeight.Text) || !decimal.TryParse(txtCurrentWeight.Text, out _))
            {
                MessageBox.Show("Please enter a valid current weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCampeignWeight.Text) || !decimal.TryParse(txtCampeignWeight.Text, out _))
            {
                MessageBox.Show("Please enter a valid competition weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text) || !long.TryParse(txtContact.Text, out _) || txtContact.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbBranch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a branch.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void UpdateTrainingPlan(int athleteID)
        {



            
            string checkQuery = "SELECT COUNT(*) FROM AthleteTrainingPlan WHERE AthleteID = @AthleteID";
            string updateQuery = "UPDATE AthleteTrainingPlan SET TrainingPlanID = @TrainingPlanID WHERE AthleteID = @AthleteID";
            string insertQuery = "INSERT INTO AthleteTrainingPlan (AthleteID, TrainingPlanID) VALUES (@AthleteID, @TrainingPlanID)";

            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@AthleteID", athleteID);
                        int count = (int)checkCmd.ExecuteScalar();
                        //assign query string based on row count
                        string query = count > 0 ? updateQuery : insertQuery;

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                            cmd.Parameters.AddWithValue("@TrainingPlanID", cbTrainingPlans.SelectedValue);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Training plan assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                            {
                                MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error assigning training plan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
