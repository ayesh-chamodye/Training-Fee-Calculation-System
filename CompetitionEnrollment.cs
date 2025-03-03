using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Training_Fee_Calculation_System
{
    public partial class CompetitionEnrollment : Form
    {
        private string connectionString = ApplicationSettings.ConnetionString();

        public CompetitionEnrollment()
        {
            InitializeComponent();
        }

        // Load the form and populate data
        private void CompetitionEnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadAthletes($"SELECT a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%' AND tp.PlanName <> 'Beginner' AND tp.PlanName IS NOT NULL AND tp.PlanName <> '';");
            LoadCompetitions();
        }

        

        // Load available competitions into ComboBox
        private void LoadCompetitions()
        {
            string query = "SELECT CompetitionID, Name FROM Competition";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCompetitions.DisplayMember = "Name";
                cmbCompetitions.ValueMember = "CompetitionID";
                cmbCompetitions.DataSource = dt;
            }
        }

        // Handle registration button click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (dgvAthletes.SelectedRows.Count > 0 && cmbCompetitions.SelectedValue != null)
            {
                int athleteID = Convert.ToInt32(dgvAthletes.SelectedRows[0].Cells["Athlete ID"].Value);
                int competitionID = Convert.ToInt32(cmbCompetitions.SelectedValue);

                // Register the athlete for the selected competition
                RegisterAthleteForCompetition(athleteID, competitionID);
                LoadRegisteredCompetitions(athleteID);
            }
            else
            {
                MessageBox.Show("Please select an athlete and a competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Register the athlete to the competition
        private void RegisterAthleteForCompetition(int athleteID, int competitionID)
        {
            string query = "INSERT INTO AthleteCompetition (AthleteID, CompetitionID) VALUES (@AthleteID, @CompetitionID)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                cmd.Parameters.AddWithValue("@CompetitionID", competitionID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Athlete successfully registered for the competition!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while registering the athlete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //load athletes from speified query
        private void LoadAthletes(string query)
        {
            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAthletes.DataSource = dt;
                dgvAthletes.Columns["Athlete ID"].Visible = false;//hide ID
                dgvAthletes.Columns["BranchID"].Visible = false;//hide ID
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAthletes($"SELECT a.AthleteID AS 'Athlete ID', a.Name AS 'Name', a.DOB AS 'Date of Birth', a.Address AS 'Address', a.ContactNo AS 'Contact Number', a.CurrentWeight AS 'Current Weight', a.CompetitionWeight AS 'Competition Weight', b.BranchName AS 'Branch Name', a.BranchID, tp.PlanName AS 'Training Plan Name' FROM [KickBlast].[dbo].[Athlete] a JOIN [KickBlast].[dbo].[Branch] b ON a.BranchID = b.BranchID JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID WHERE a.Name LIKE '%{txtSearch.Text}%' AND tp.PlanName <> 'Beginner' AND tp.PlanName IS NOT NULL AND tp.PlanName <> '';");
        }

        private void dgvAthletes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure a valid row is clicked
                {
                    DataGridViewRow row = dgvAthletes.Rows[e.RowIndex];

                    
                    athleteID = Convert.ToInt32(row.Cells["Athlete ID"].Value);
                    LoadRegisteredCompetitions(athleteID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //getting registered compatition to list
        private void LoadRegisteredCompetitions(int athleteID)
        {
            lvRegisteredCompatition.Items.Clear(); // Clear existing items

            string query = @"SELECT C.CompetitionID, C.Date, C.WeightCategory, C.CostPerCompetition, C.Name 
                     FROM Competition C
                     INNER JOIN AthleteCompetition AC ON C.CompetitionID = AC.CompetitionID
                     WHERE AC.AthleteID = @AthleteID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["CompetitionID"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd"));
                                item.SubItems.Add(reader["WeightCategory"].ToString());
                                item.SubItems.Add(Convert.ToDecimal(reader["CostPerCompetition"]).ToString("C"));
                                item.SubItems.Add(reader["Name"].ToString());

                                lvRegisteredCompatition.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading competitions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            if (lvRegisteredCompatition.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an athlete's competition to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected AthleteID and CompetitionID
            ListViewItem selectedItem = lvRegisteredCompatition.SelectedItems[0];            
            competitionID = int.Parse(selectedItem.SubItems[0].Text); // Assuming CompetitionID is in the second column

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to remove this athlete from the competition?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            // SQL Query to delete the record
            string query = "DELETE FROM AthleteCompetition WHERE AthleteID = @AthleteID AND CompetitionID = @CompetitionID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                        cmd.Parameters.AddWithValue("@CompetitionID", competitionID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Athlete removed from the competition successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRegisteredCompetitions(athleteID); // Refresh the list
                        }
                        else
                        {
                            MessageBox.Show("No records were deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting the competition record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int athleteID = 0;
        private int competitionID;
        private void lvRegisteredCompatition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRegisteredCompatition.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvRegisteredCompatition.SelectedItems[0];

                 competitionID = Convert.ToInt32(selectedItem.SubItems[0].Text);
                

                
            }
        }
    }
}
