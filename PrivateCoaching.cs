using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Training_Fee_Calculation_System
{
    public partial class PrivateCoaching : Form
    {
        private string connectionString = ApplicationSettings.ConnetionString();

        public PrivateCoaching()
        {
            InitializeComponent();
        }

        // Form load event to initialize ComboBox and DataGridView
        private void PrivateCoachingForm_Load(object sender, EventArgs e)
        {
            LoadAthletes();
            LoadCoaches();
            LoadPrivateCoachingHours();
        }

        // Load athletes into the ComboBox
        private void LoadAthletes()
        {
            string query = "SELECT AthleteID, Name FROM [KickBlast].[dbo].[Athlete]";
            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbAthlete.DisplayMember = "Name";
                cmbAthlete.ValueMember = "AthleteID";
                cmbAthlete.DataSource = dt;
            }
        }

        // Load coaches into the ComboBox
        private void LoadCoaches()
        {
            string query = "SELECT CoachID, Name FROM [KickBlast].[dbo].[Coach]";
            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbCoach.DisplayMember = "Name";
                cmbCoach.ValueMember = "CoachID";
                cmbCoach.DataSource = dt;
            }
        }

        // Load private coaching hours and details into DataGridView
        private void LoadPrivateCoachingHours()
        {
            string query = @"
                SELECT 
                    a.Name AS 'Athlete Name', 
                    tp.PlanName AS 'Training Plan Name', 
                    ISNULL(pc.CoachingHours, 0) AS 'Coaching Hours', 
                    pc.CoachingDate AS 'Coaching Date',
                    co.Name AS 'Coach Name'
                FROM [KickBlast].[dbo].[Athlete] a
                JOIN [KickBlast].[dbo].[AthleteTrainingPlan] atp ON a.AthleteID = atp.AthleteID
                JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID
                LEFT JOIN [KickBlast].[dbo].[PrivateCoaching] pc ON a.AthleteID = pc.AthleteID
                LEFT JOIN [KickBlast].[dbo].[Coach] co ON pc.CoachID = co.CoachID";

            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPrivateCoaching.DataSource = dt;
            }
        }

        // Submit private coaching session for an athlete
        private void btnSubmitCoaching_Click(object sender, EventArgs e)
        {
            if (cmbAthlete.SelectedValue == null || string.IsNullOrEmpty(txtCoachingHours.Text) || dtpCoachingDate.Value == null)
            {
                lblMessage.Text = "Please select an athlete, coach, and enter coaching hours and date.";
                return;
            }

            int athleteID = Convert.ToInt32(cmbAthlete.SelectedValue);
            int coachID = Convert.ToInt32(cmbCoach.SelectedValue);  // Assuming you also have a ComboBox for coaches
            int coachingHours = Convert.ToInt32(txtCoachingHours.Text);
            DateTime coachingDate = dtpCoachingDate.Value;

            // Fetch the total coaching hours for the athlete
            int totalCoachingHours = GetTotalCoachingHours(athleteID);

            // Fetch the max coaching hours allowed by the athlete's training plan
            int maxCoachingHours = GetMaxCoachingHours(athleteID);

            // Check if adding the new coaching session would exceed the max allowed hours
            if (totalCoachingHours + coachingHours > maxCoachingHours)
            {
                MessageBox.Show("The athlete has exceeded the maximum allowed coaching hours.");
                return;
            }

            // Insert the private coaching session
            string query = @"
                INSERT INTO [KickBlast].[dbo].[PrivateCoaching] (AthleteID, CoachID, CoachingDate, CoachingHours)
                VALUES (@AthleteID, @CoachID, @CoachingDate, @CoachingHours)";
            try
            {


                using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                    cmd.Parameters.AddWithValue("@CoachID", coachID);
                    cmd.Parameters.AddWithValue("@CoachingDate", coachingDate);
                    cmd.Parameters.AddWithValue("@CoachingHours", coachingHours);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Private coaching session added successfully!");
                }

                lblMessage.Text = $"Private coaching session for {cmbAthlete.Text} added.";
                LoadPrivateCoachingHours();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to get the total coaching hours for an athlete
        private int GetTotalCoachingHours(int athleteID)
        {
            string query = @"
                SELECT 
                    ISNULL(SUM(CoachingHours), 0) AS TotalCoachingHours
                FROM [KickBlast].[dbo].[PrivateCoaching]
                WHERE AthleteID = @AthleteID DATEPART(WEEK, [CoachingDate]) = DATEPART(WEEK, GETDATE())
                GROUP BY AthleteID";

            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AthleteID", athleteID);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Function to get the max allowed coaching hours from the athlete's training plan
        private int GetMaxCoachingHours(int athleteID)
        {
            string query = @"
                SELECT 
                    tp.MaxPrivateCoachingHours
                FROM [KickBlast].[dbo].[AthleteTrainingPlan] atp
                JOIN [KickBlast].[dbo].[TrainingPlan] tp ON atp.TrainingPlanID = tp.TrainingPlanID
                WHERE atp.AthleteID = @AthleteID";

            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AthleteID", athleteID);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}
