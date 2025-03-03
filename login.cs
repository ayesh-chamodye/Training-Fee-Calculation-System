using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Training_Fee_Calculation_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text;

            //Validate Input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check Credentials
            bool valid = AuthenticateUser(username, password);
            if (valid)
            {
                MessageBox.Show($"Login successful! Welcome, {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Hide login form after successful login
                //Redirecting to dashboard
                Home home = new Home();
                home.Username = username;
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void chbox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_show_password.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }




        // Authenticate User from Database
        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                conn.Open();
                string query = $"SELECT '#' FROM Users WHERE Username = @Username AND PasswordHash = HASHBYTES('SHA2_256', @Password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Hashing applied
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {



                            // Compare hashed password
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return false; // Login failed
        }


    }
}
