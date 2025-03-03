using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Training_Fee_Calculation_System;

namespace TrainingFeeCalculationSystem
{
    public partial class Office_Details : Form
    {
        private int selectedBranchId;
        private int selectedStaffId;
        private int selectedCoachId;


        public Office_Details()
        {
            InitializeComponent();
        }

        private void Office_Details_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
            conn.Open();
            LoadBranchData();
            LoadStaffData();
            LoadCoachData();
        }

        //Load data to entry fields

        private void DgvBranches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBranches.Rows[e.RowIndex];
                selectedBranchId = Convert.ToInt32(row.Cells["BranchID"].Value);
                txtBranchName.Text = row.Cells["BranchName"].Value.ToString();
                txtLocation.Text = row.Cells["Location"].Value.ToString();
                txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
                txtManagerName.Text = row.Cells["ContactNo"].Value.ToString();


            }
        }

        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                selectedStaffId = Convert.ToInt32(row.Cells["StaffID"].Value);
                txtStaffName.Text = row.Cells["Name"].Value.ToString();
                txtRole.Text = row.Cells["Role"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                txtStaffAddress.Text = row.Cells["Address"].Value.ToString();
                txtAvailabilityHours.Text = row.Cells["AvailabilityHours"].Value.ToString();
            }
        }

        private void DgvCoaches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCoaches.Rows[e.RowIndex];
                selectedCoachId = Convert.ToInt32(row.Cells["CoachID"].Value);
                txtCoachName.Text = row.Cells["Name"].Value.ToString();
                txtCoachAddress.Text = row.Cells["Address"].Value.ToString();
                txtSpecialization.Text = row.Cells["Specialization"].Value.ToString();
                txtCoachAvailabilityHours.Text = row.Cells["AvailabilityHours"].Value.ToString();
                txtCoachContactNo.Text = row.Cells["ContactNo"].Value.ToString();
            }
        }

        //BRANCH CRUD METHODS
        private void LoadBranchData()
        {
            SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Branch", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBranches.DataSource = dt;
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "INSERT INTO Branch (BranchName, Location, ManagerName, ContactNo) VALUES (@BranchName, @Location, @ManagerName, @ContactNo)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BranchName", txtBranchName.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@ManagerName", txtManagerName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Branch added successfully.");
                LoadBranchData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding branch: " + ex.Message);
            }
            
        }

        private void btnUpdateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "UPDATE Branch SET BranchName=@BranchName, Location=@Location, ManagerName=@ManagerName, ContactNo=@ContactNo WHERE BranchID=@BranchID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BranchID", dgvBranches.SelectedRows[0].Cells["BranchID"].Value);
                    cmd.Parameters.AddWithValue("@BranchName", txtBranchName.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@ManagerName", txtManagerName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Branch updated successfully.");
                LoadBranchData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating branch: " + ex.Message);
            }
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "DELETE FROM Branch WHERE BranchID=@BranchID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BranchID", dgvBranches.SelectedRows[0].Cells["BranchID"].Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Branch deleted successfully.");
                LoadBranchData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting branch: " + ex.Message);
            }
        }

        //STAFF CRUD METHODS
        private void LoadStaffData()
        {
            SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Staff", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStaff.DataSource = dt;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "INSERT INTO Staff (Name, Role, Salary, Address, AvailabilityHours, BranchID) VALUES (@Name, @Role, @Salary, @Address, @AvailabilityHours, @BranchID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtStaffName.Text);
                    cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    cmd.Parameters.AddWithValue("@Address", txtStaffAddress.Text);
                    cmd.Parameters.AddWithValue("@AvailabilityHours", txtAvailabilityHours.Text);
                    cmd.Parameters.AddWithValue("@BranchID", 1);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Staff added successfully.");
                LoadStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding staff: " + ex.Message);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "UPDATE Staff SET Name=@Name, Role=@Role, Salary=@Salary, Address=@Address, AvailabilityHours=@AvailabilityHours WHERE StaffID=@StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", selectedStaffId);
                    cmd.Parameters.AddWithValue("@Name", txtStaffName.Text);
                    cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    cmd.Parameters.AddWithValue("@Address", txtStaffAddress.Text);
                    cmd.Parameters.AddWithValue("@AvailabilityHours", txtAvailabilityHours.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Staff updated successfully.");
                LoadStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff: " + ex.Message);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "DELETE FROM Staff WHERE StaffID=@StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", dgvStaff.SelectedRows[0].Cells["StaffID"].Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Staff deleted successfully.");
                LoadStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff: " + ex.Message);
            }
        }

        //COACH CRUD METHODS
        private void LoadCoachData()
        {
            SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Coach", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCoaches.DataSource = dt;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            if (txtCoachName.Text == null && txtCoachAddress.Text == null && txtCoachContactNo.Text == null && txtCoachAvailabilityHours == null)
            {
                MessageBox.Show("Please fill all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "INSERT INTO Coach (Name, Address, Specialization, AvailabilityHours, ContactNo, BranchID) VALUES (@Name, @Address, @Specialization, @AvailabilityHours, @ContactNo, @BranchID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtCoachName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtCoachAddress.Text);
                    cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text);
                    cmd.Parameters.AddWithValue("@AvailabilityHours", txtCoachAvailabilityHours.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtCoachContactNo.Text);
                    cmd.Parameters.AddWithValue("@BranchID", 1);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Coach added successfully.");
                LoadCoachData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding coach: " + ex.Message);
            }
        }

        private void btnUpdateCoach_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "UPDATE Coach SET Name=@Name, Address=@Address, Specialization=@Specialization,AvailabilityHours=@AvailabilityHours, ContactNo=@ContactNo WHERE CoachID=@CoachID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtCoachName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtCoachAddress.Text);
                    cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text);
                    cmd.Parameters.AddWithValue("@AvailabilityHours", txtCoachAvailabilityHours.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtCoachContactNo.Text);
                    cmd.Parameters.AddWithValue("@CoachID", selectedCoachId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Coach updated successfully.");
                LoadCoachData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating branch: " + ex.Message);
            }
        }
        private void btnDeleteCoach_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ApplicationSettings.ConnetionString());
                conn.Open();
                string query = "DELETE Coach  WHERE BranchID=@BranchID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtCoachName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtCoachAddress.Text);
                    cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text);
                    cmd.Parameters.AddWithValue("@AvailabilityHours", txtCoachAvailabilityHours.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtCoachContactNo.Text);
                    cmd.Parameters.AddWithValue("@BranchID", 1);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Coach updated successfully.");
                LoadBranchData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating branch: " + ex.Message);
            }
        }

        private void tabPageBranch_Enter(object sender, EventArgs e)
        {
            LoadBranchData();
        }

        private void tabPageStaff_Enter(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void tabPageCoach_Enter(object sender, EventArgs e)
        {
            LoadCoachData();
        }

        
    }
}
