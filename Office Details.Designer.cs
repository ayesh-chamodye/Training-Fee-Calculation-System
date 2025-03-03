namespace TrainingFeeCalculationSystem
{
    partial class Office_Details
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBranch;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.TabPage tabPageCoach;




        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Office_Details));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBranch = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelBranchName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelManagerName = new System.Windows.Forms.Label();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelStaffAddress = new System.Windows.Forms.Label();
            this.labelAvailabilityHours = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtAvailabilityHours = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.tabPageCoach = new System.Windows.Forms.TabPage();
            this.btnDeleteCoach = new System.Windows.Forms.Button();
            this.btnUpdateCoach = new System.Windows.Forms.Button();
            this.labelCoachName = new System.Windows.Forms.Label();
            this.labelCoachAddress = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.labelCoachAvailabilityHours = new System.Windows.Forms.Label();
            this.labelCoachContactNo = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.txtCoachAddress = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtCoachAvailabilityHours = new System.Windows.Forms.TextBox();
            this.txtCoachContactNo = new System.Windows.Forms.TextBox();
            this.btnAddCoach = new System.Windows.Forms.Button();
            this.dgvCoaches = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            this.tabPageStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tabPageCoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBranch);
            this.tabControl1.Controls.Add(this.tabPageStaff);
            this.tabControl1.Controls.Add(this.tabPageCoach);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBranch
            // 
            this.tabPageBranch.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.tabPageBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageBranch.Controls.Add(this.button4);
            this.tabPageBranch.Controls.Add(this.button5);
            this.tabPageBranch.Controls.Add(this.labelBranchName);
            this.tabPageBranch.Controls.Add(this.labelLocation);
            this.tabPageBranch.Controls.Add(this.labelManagerName);
            this.tabPageBranch.Controls.Add(this.labelContactNo);
            this.tabPageBranch.Controls.Add(this.txtBranchName);
            this.tabPageBranch.Controls.Add(this.txtLocation);
            this.tabPageBranch.Controls.Add(this.txtManagerName);
            this.tabPageBranch.Controls.Add(this.txtContactNo);
            this.tabPageBranch.Controls.Add(this.btnAddBranch);
            this.tabPageBranch.Controls.Add(this.dgvBranches);
            this.tabPageBranch.Location = new System.Drawing.Point(4, 22);
            this.tabPageBranch.Name = "tabPageBranch";
            this.tabPageBranch.Size = new System.Drawing.Size(812, 594);
            this.tabPageBranch.TabIndex = 0;
            this.tabPageBranch.Text = "Branch Management";
            this.tabPageBranch.Enter += new System.EventHandler(this.tabPageBranch_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(393, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete Branch";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(266, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Edit Branch";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // labelBranchName
            // 
            this.labelBranchName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBranchName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBranchName.Location = new System.Drawing.Point(20, 20);
            this.labelBranchName.Name = "labelBranchName";
            this.labelBranchName.Size = new System.Drawing.Size(100, 23);
            this.labelBranchName.TabIndex = 0;
            this.labelBranchName.Text = "Branch Name:";
            // 
            // labelLocation
            // 
            this.labelLocation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLocation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLocation.Location = new System.Drawing.Point(20, 60);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(100, 23);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location:";
            // 
            // labelManagerName
            // 
            this.labelManagerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManagerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelManagerName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelManagerName.Location = new System.Drawing.Point(20, 100);
            this.labelManagerName.Name = "labelManagerName";
            this.labelManagerName.Size = new System.Drawing.Size(100, 23);
            this.labelManagerName.TabIndex = 2;
            this.labelManagerName.Text = "Manager Name:";
            // 
            // labelContactNo
            // 
            this.labelContactNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelContactNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelContactNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelContactNo.Location = new System.Drawing.Point(20, 140);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(100, 23);
            this.labelContactNo.TabIndex = 3;
            this.labelContactNo.Text = "Contact No:";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(150, 20);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(200, 20);
            this.txtBranchName.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(150, 60);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(150, 100);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(200, 20);
            this.txtManagerName.TabIndex = 6;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(150, 140);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 20);
            this.txtContactNo.TabIndex = 7;
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddBranch.Location = new System.Drawing.Point(150, 180);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(100, 23);
            this.btnAddBranch.TabIndex = 8;
            this.btnAddBranch.Text = "Add Branch";
            this.btnAddBranch.UseVisualStyleBackColor = false;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // dgvBranches
            // 
            this.dgvBranches.Location = new System.Drawing.Point(20, 220);
            this.dgvBranches.Name = "dgvBranches";
            this.dgvBranches.Size = new System.Drawing.Size(740, 300);
            this.dgvBranches.TabIndex = 9;
            this.dgvBranches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBranches_CellClick);
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.tabPageStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageStaff.Controls.Add(this.btnDeleteStaff);
            this.tabPageStaff.Controls.Add(this.btnUpdateStaff);
            this.tabPageStaff.Controls.Add(this.labelStaffName);
            this.tabPageStaff.Controls.Add(this.labelRole);
            this.tabPageStaff.Controls.Add(this.labelSalary);
            this.tabPageStaff.Controls.Add(this.labelStaffAddress);
            this.tabPageStaff.Controls.Add(this.labelAvailabilityHours);
            this.tabPageStaff.Controls.Add(this.txtStaffName);
            this.tabPageStaff.Controls.Add(this.txtRole);
            this.tabPageStaff.Controls.Add(this.txtSalary);
            this.tabPageStaff.Controls.Add(this.txtStaffAddress);
            this.tabPageStaff.Controls.Add(this.txtAvailabilityHours);
            this.tabPageStaff.Controls.Add(this.btnAddStaff);
            this.tabPageStaff.Controls.Add(this.dgvStaff);
            this.tabPageStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Size = new System.Drawing.Size(812, 594);
            this.tabPageStaff.TabIndex = 1;
            this.tabPageStaff.Text = "Staff Management";
            this.tabPageStaff.Enter += new System.EventHandler(this.tabPageStaff_Enter);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteStaff.Location = new System.Drawing.Point(397, 220);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteStaff.TabIndex = 15;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateStaff.Location = new System.Drawing.Point(270, 220);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateStaff.TabIndex = 14;
            this.btnUpdateStaff.Text = "Edit Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // labelStaffName
            // 
            this.labelStaffName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStaffName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStaffName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelStaffName.Location = new System.Drawing.Point(20, 20);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(100, 23);
            this.labelStaffName.TabIndex = 0;
            this.labelStaffName.Text = "Staff Name:";
            // 
            // labelRole
            // 
            this.labelRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRole.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRole.Location = new System.Drawing.Point(20, 60);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(100, 23);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Role:";
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSalary.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSalary.Location = new System.Drawing.Point(20, 100);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(100, 23);
            this.labelSalary.TabIndex = 2;
            this.labelSalary.Text = "Salary:";
            // 
            // labelStaffAddress
            // 
            this.labelStaffAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStaffAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStaffAddress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelStaffAddress.Location = new System.Drawing.Point(20, 140);
            this.labelStaffAddress.Name = "labelStaffAddress";
            this.labelStaffAddress.Size = new System.Drawing.Size(100, 23);
            this.labelStaffAddress.TabIndex = 3;
            this.labelStaffAddress.Text = "Staff Address:";
            // 
            // labelAvailabilityHours
            // 
            this.labelAvailabilityHours.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAvailabilityHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAvailabilityHours.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelAvailabilityHours.Location = new System.Drawing.Point(20, 180);
            this.labelAvailabilityHours.Name = "labelAvailabilityHours";
            this.labelAvailabilityHours.Size = new System.Drawing.Size(100, 23);
            this.labelAvailabilityHours.TabIndex = 4;
            this.labelAvailabilityHours.Text = "Availability Hours:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(150, 20);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(200, 20);
            this.txtStaffName.TabIndex = 5;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(150, 60);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(200, 20);
            this.txtRole.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(150, 100);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(150, 140);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(200, 20);
            this.txtStaffAddress.TabIndex = 8;
            // 
            // txtAvailabilityHours
            // 
            this.txtAvailabilityHours.Location = new System.Drawing.Point(150, 180);
            this.txtAvailabilityHours.Name = "txtAvailabilityHours";
            this.txtAvailabilityHours.Size = new System.Drawing.Size(200, 20);
            this.txtAvailabilityHours.TabIndex = 9;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStaff.Location = new System.Drawing.Point(150, 220);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(100, 23);
            this.btnAddStaff.TabIndex = 10;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.Location = new System.Drawing.Point(20, 260);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(740, 300);
            this.dgvStaff.TabIndex = 11;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStaff_CellClick);
            // 
            // tabPageCoach
            // 
            this.tabPageCoach.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.tabPageCoach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCoach.Controls.Add(this.btnDeleteCoach);
            this.tabPageCoach.Controls.Add(this.btnUpdateCoach);
            this.tabPageCoach.Controls.Add(this.labelCoachName);
            this.tabPageCoach.Controls.Add(this.labelCoachAddress);
            this.tabPageCoach.Controls.Add(this.labelSpecialization);
            this.tabPageCoach.Controls.Add(this.labelCoachAvailabilityHours);
            this.tabPageCoach.Controls.Add(this.labelCoachContactNo);
            this.tabPageCoach.Controls.Add(this.txtCoachName);
            this.tabPageCoach.Controls.Add(this.txtCoachAddress);
            this.tabPageCoach.Controls.Add(this.txtSpecialization);
            this.tabPageCoach.Controls.Add(this.txtCoachAvailabilityHours);
            this.tabPageCoach.Controls.Add(this.txtCoachContactNo);
            this.tabPageCoach.Controls.Add(this.btnAddCoach);
            this.tabPageCoach.Controls.Add(this.dgvCoaches);
            this.tabPageCoach.Location = new System.Drawing.Point(4, 22);
            this.tabPageCoach.Name = "tabPageCoach";
            this.tabPageCoach.Size = new System.Drawing.Size(812, 594);
            this.tabPageCoach.TabIndex = 2;
            this.tabPageCoach.Text = "Coach Management";
            this.tabPageCoach.Enter += new System.EventHandler(this.tabPageCoach_Enter);
            // 
            // btnDeleteCoach
            // 
            this.btnDeleteCoach.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCoach.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteCoach.Location = new System.Drawing.Point(394, 220);
            this.btnDeleteCoach.Name = "btnDeleteCoach";
            this.btnDeleteCoach.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteCoach.TabIndex = 13;
            this.btnDeleteCoach.Text = "Delete Coach";
            this.btnDeleteCoach.UseVisualStyleBackColor = false;
            this.btnDeleteCoach.Click += new System.EventHandler(this.btnDeleteCoach_Click);
            // 
            // btnUpdateCoach
            // 
            this.btnUpdateCoach.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCoach.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateCoach.Location = new System.Drawing.Point(267, 220);
            this.btnUpdateCoach.Name = "btnUpdateCoach";
            this.btnUpdateCoach.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateCoach.TabIndex = 12;
            this.btnUpdateCoach.Text = "Edit Coach";
            this.btnUpdateCoach.UseVisualStyleBackColor = false;
            this.btnUpdateCoach.Click += new System.EventHandler(this.btnUpdateCoach_Click);
            // 
            // labelCoachName
            // 
            this.labelCoachName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCoachName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCoachName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCoachName.Location = new System.Drawing.Point(20, 20);
            this.labelCoachName.Name = "labelCoachName";
            this.labelCoachName.Size = new System.Drawing.Size(100, 23);
            this.labelCoachName.TabIndex = 0;
            this.labelCoachName.Text = "Coach Name:";
            // 
            // labelCoachAddress
            // 
            this.labelCoachAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCoachAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCoachAddress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCoachAddress.Location = new System.Drawing.Point(20, 60);
            this.labelCoachAddress.Name = "labelCoachAddress";
            this.labelCoachAddress.Size = new System.Drawing.Size(100, 23);
            this.labelCoachAddress.TabIndex = 1;
            this.labelCoachAddress.Text = "Coach Address:";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSpecialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSpecialization.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSpecialization.Location = new System.Drawing.Point(20, 100);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(100, 23);
            this.labelSpecialization.TabIndex = 2;
            this.labelSpecialization.Text = "Specialization:";
            // 
            // labelCoachAvailabilityHours
            // 
            this.labelCoachAvailabilityHours.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCoachAvailabilityHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCoachAvailabilityHours.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCoachAvailabilityHours.Location = new System.Drawing.Point(20, 140);
            this.labelCoachAvailabilityHours.Name = "labelCoachAvailabilityHours";
            this.labelCoachAvailabilityHours.Size = new System.Drawing.Size(100, 23);
            this.labelCoachAvailabilityHours.TabIndex = 3;
            this.labelCoachAvailabilityHours.Text = "Availability Hours:";
            // 
            // labelCoachContactNo
            // 
            this.labelCoachContactNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCoachContactNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCoachContactNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCoachContactNo.Location = new System.Drawing.Point(20, 180);
            this.labelCoachContactNo.Name = "labelCoachContactNo";
            this.labelCoachContactNo.Size = new System.Drawing.Size(100, 23);
            this.labelCoachContactNo.TabIndex = 4;
            this.labelCoachContactNo.Text = "Contact No:";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(150, 20);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(200, 20);
            this.txtCoachName.TabIndex = 5;
            // 
            // txtCoachAddress
            // 
            this.txtCoachAddress.Location = new System.Drawing.Point(150, 60);
            this.txtCoachAddress.Name = "txtCoachAddress";
            this.txtCoachAddress.Size = new System.Drawing.Size(200, 20);
            this.txtCoachAddress.TabIndex = 6;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(150, 100);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(200, 20);
            this.txtSpecialization.TabIndex = 7;
            // 
            // txtCoachAvailabilityHours
            // 
            this.txtCoachAvailabilityHours.Location = new System.Drawing.Point(150, 140);
            this.txtCoachAvailabilityHours.Name = "txtCoachAvailabilityHours";
            this.txtCoachAvailabilityHours.Size = new System.Drawing.Size(200, 20);
            this.txtCoachAvailabilityHours.TabIndex = 8;
            // 
            // txtCoachContactNo
            // 
            this.txtCoachContactNo.Location = new System.Drawing.Point(150, 180);
            this.txtCoachContactNo.Name = "txtCoachContactNo";
            this.txtCoachContactNo.Size = new System.Drawing.Size(200, 20);
            this.txtCoachContactNo.TabIndex = 9;
            // 
            // btnAddCoach
            // 
            this.btnAddCoach.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoach.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCoach.Location = new System.Drawing.Point(150, 220);
            this.btnAddCoach.Name = "btnAddCoach";
            this.btnAddCoach.Size = new System.Drawing.Size(100, 23);
            this.btnAddCoach.TabIndex = 10;
            this.btnAddCoach.Text = "Add Coach";
            this.btnAddCoach.UseVisualStyleBackColor = false;
            this.btnAddCoach.Click += new System.EventHandler(this.btnAddCoach_Click);
            // 
            // dgvCoaches
            // 
            this.dgvCoaches.Location = new System.Drawing.Point(20, 260);
            this.dgvCoaches.Name = "dgvCoaches";
            this.dgvCoaches.Size = new System.Drawing.Size(740, 300);
            this.dgvCoaches.TabIndex = 11;
            this.dgvCoaches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCoaches_CellClick);
            // 
            // Office_Details
            // 
            this.ClientSize = new System.Drawing.Size(820, 620);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Office_Details";
            this.Text = "Office Details";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBranch.ResumeLayout(false);
            this.tabPageBranch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            this.tabPageStaff.ResumeLayout(false);
            this.tabPageStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabPageCoach.ResumeLayout(false);
            this.tabPageCoach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).EndInit();
            this.ResumeLayout(false);

        }

        // Branch Tab Controls
        private System.Windows.Forms.Label labelBranchName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelManagerName;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.DataGridView dgvBranches;

        // Staff Tab Controls
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelStaffAddress;
        private System.Windows.Forms.Label labelAvailabilityHours;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtAvailabilityHours;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView dgvStaff;

        // Coach Tab Controls
        private System.Windows.Forms.Label labelCoachName;
        private System.Windows.Forms.Label labelCoachAddress;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.Label labelCoachAvailabilityHours;
        private System.Windows.Forms.Label labelCoachContactNo;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.TextBox txtCoachAddress;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtCoachAvailabilityHours;
        private System.Windows.Forms.TextBox txtCoachContactNo;
        private System.Windows.Forms.Button btnAddCoach;
        private System.Windows.Forms.DataGridView dgvCoaches;
        private System.Windows.Forms.Button btnUpdateCoach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteCoach;
    }
}