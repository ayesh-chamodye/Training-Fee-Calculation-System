using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Training_Fee_Calculation_System
{
    public partial class FeeCalculation : Form
    {
        private string connectionString = ApplicationSettings.ConnetionString();

        public FeeCalculation()
        {
            InitializeComponent();
            LoadAthletes();
            LoadTrainingPlans();
        }

        private void LoadAthletes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT AthleteID, Name FROM Athlete";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbAthlete.DataSource = dt;
                    cmbAthlete.DisplayMember = "Name";
                    cmbAthlete.ValueMember = "AthleteID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading athletes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //click event of calculate fee button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbAthlete.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an athlete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtMonth.Value.Month.ToString()))
            {
                MessageBox.Show("Please enter a valid month.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int athleteID = Convert.ToInt32(cmbAthlete.SelectedValue);
            int TrainingPlanID = Convert.ToInt32(cmbTrainingPlan.SelectedValue);
            string month = dtMonth.Value.Month.ToString();
            decimal totalCost = CalculateFees(athleteID, TrainingPlanID);

            txtTotalCost.Text = totalCost.ToString();
        }


        private decimal CalculateFees(int athleteID,int TrainingPlanID)
        {
            decimal trainingCost = 0;
            decimal competitionCost = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get training plan cost
                    string queryTraining = @"SELECT CostPerWeek * 4 
                                             FROM TrainingPlan                                             
                                             WHERE TrainingPlanID = @TrainingPlanID";
                    using (SqlCommand cmd = new SqlCommand(queryTraining, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrainingPlanID", TrainingPlanID);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                            trainingCost = Convert.ToDecimal(result);
                    }

                    // Get competition cost
                    string queryCompetition = @"SELECT SUM(C.CostPerCompetition) FROM Competition C JOIN AthleteCompetition AC ON C.CompetitionID = AC.CompetitionID WHERE AC.AthleteID = @AthleteID;";
                    using (SqlCommand cmd = new SqlCommand(queryCompetition, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                            competitionCost = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating fees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return trainingCost + competitionCost;
        }



        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (cmbAthlete.SelectedIndex == -1 || string.IsNullOrWhiteSpace(dtMonth.Text) || string.IsNullOrWhiteSpace(txtTotalCost.Text))
            {
                MessageBox.Show("Please fill all details before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Invoice (Month, TotalCost, AthleteID,Date) VALUES (@Month, @TotalCost, @AthleteID,GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Month", dtMonth.Value.Month.ToString());
                        cmd.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(txtTotalCost.Text.Replace("$", "").Trim()));
                        cmd.Parameters.AddWithValue("@AthleteID", cmbAthlete.SelectedValue);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadTrainingPlans()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TrainingPlanID, PlanName FROM TrainingPlan";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbTrainingPlan.DataSource = dt;
                        cmbTrainingPlan.DisplayMember = "PlanName";
                        cmbTrainingPlan.ValueMember = "TrainingPlanID";
                        
                    }
                    
                }

            }
            catch (Exception ex)
            {                
                MessageBox.Show("Error loading training plans: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAthlete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAthlete.SelectedIndex != -1)
            {
                int athleteID = Convert.ToInt32(cmbAthlete.SelectedValue);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT TrainingPlanID FROM AthleteTrainingPlan WHERE AthleteID = @AthleteID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                cmbTrainingPlan.SelectedValue = Convert.ToInt32(result);
                            }
                            else
                            {
                                cmbTrainingPlan.SelectedIndex = -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assigned training plan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
