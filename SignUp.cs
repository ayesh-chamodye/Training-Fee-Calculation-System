using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Training_Fee_Calculation_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void chbox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_show_password.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_retype_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_retype_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text;
            string confirmPassword = txt_retype_password.Text;


            // ✅ Validation Checks
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username already exists. Choose a different one!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Insert Data
            try
            {
                using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, HASHBYTES('SHA2_256', @Password))";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // Hashing applied                        

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Signup successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            login login = new login();
                            login.Show();// Close signup form and open login page
                        }
                        else
                        {
                            MessageBox.Show("Signup failed. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if Username Exists
        private bool IsUsernameTaken(string username)
        {
            using (SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString()))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
