using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrainingFeeCalculationSystem;
using TrainingFeeSystem;

namespace Training_Fee_Calculation_System
{

    public partial class Home : Form
    {
        //logged username
        public String Username { get; set; }
        public Home()
        {
            InitializeComponent();
            LoadDashboardData();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void btnAthleteManagement_Click(object sender, EventArgs e)
        {
            AthleteManagement athleteManagement = new AthleteManagement();
            athleteManagement.Show();
        }

        private void btnFeeCalculation_Click(object sender, EventArgs e)
        {
            FeeCalculation feeCalculation = new FeeCalculation();
            feeCalculation.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            invoiceGenerator.Show();
        }

        private void btnCompetitions_Click(object sender, EventArgs e)
        {
            CompetitionManagement competitionManagement = new CompetitionManagement();
            competitionManagement.Show();
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            Office_Details office_Details = new Office_Details();
            office_Details.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Welcome {Username}";
        }




        private void LoadDashboardData()
        {
            // Fetch and display data dynamically
            lblTotalAthletes.Text = "Total Athletes: " + GetTotalAthletes();
            decimal totalIncome = GetIncomeForMonth();
            lblTotalIncome.Text = $"Total Income for {DateTime.Now.Month}/{DateTime.Now.Year}: Rs. {totalIncome}";  // Assuming lblTotalIncome is a Label control
            lblUpcomingCompetitions.Text = "Upcoming Competitions: " + GetUpcomingCompetitions();
        }

        private int GetTotalAthletes()
        {
            int totalAthletes = 0;
            string query = "SELECT COUNT(*) FROM Athlete";
            using (SqlConnection connection = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                totalAthletes = (int)cmd.ExecuteScalar();
            }
            return totalAthletes;
        }

        private decimal GetIncomeForMonth()
        {
            int month = DateTime.Now.Month;  // Current month
            int year = DateTime.Now.Year;    // Current year
            string query = @"
                SELECT 
                    SUM(I.TotalCost) AS TotalIncome
                FROM 
                    Invoice I
                WHERE 
                    Month(I.Date) = @Month AND YEAR(I.Date) = @Year;
            ";

            using (SqlConnection connection = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Month", month);
                command.Parameters.AddWithValue("@Year", year);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    decimal totalIncome = Convert.ToDecimal(result);
                    return totalIncome;
                }
                else
                {
                    return 0;
                }
            }
        }


        private int GetUpcomingCompetitions()
        {
            int upcomingCompetitions = 0;
            string query = "SELECT COUNT(*) FROM Competition WHERE Date > GETDATE()";
            using (SqlConnection connection = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                upcomingCompetitions = (int)cmd.ExecuteScalar();
            }
            return upcomingCompetitions;
        }

        private void btnTrainingPlanManagement_Click(object sender, EventArgs e)
        {
            TrainingPlanManagement trainingPlan = new TrainingPlanManagement();
            trainingPlan.Show();
        }

        private void btnCompetitionEnrollment_Click(object sender, EventArgs e)
        {
            CompetitionEnrollment competitionEnrollment = new CompetitionEnrollment();
            competitionEnrollment.Show();
        }
        
                  

        private void btnPrivateCoaching_Click(object sender, EventArgs e)
        {
            PrivateCoaching coaching = new PrivateCoaching();
            coaching.Show();

        }
    }
}
