namespace Training_Fee_Calculation_System
{
    partial class AthleteManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAthletes;
        private System.Windows.Forms.Button btnAddAthlete;
        private System.Windows.Forms.Button btnEditAthlete;
        private System.Windows.Forms.Button btnDeleteAthlete;
        private System.Windows.Forms.TextBox txtName;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthleteManagement));
            this.dgvAthletes = new System.Windows.Forms.DataGridView();
            this.btnAddAthlete = new System.Windows.Forms.Button();
            this.btnEditAthlete = new System.Windows.Forms.Button();
            this.btnDeleteAthlete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCampeignWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kickBlastDataSet = new Training_Fee_Calculation_System.KickBlastDataSet();
            this.branchTableAdapter = new Training_Fee_Calculation_System.KickBlastDataSetTableAdapters.BranchTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbTrainingPlans = new System.Windows.Forms.ComboBox();
            this.trainingPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kickBlastDataSet1 = new Training_Fee_Calculation_System.KickBlastDataSet1();
            this.trainingPlanTableAdapter = new Training_Fee_Calculation_System.KickBlastDataSet1TableAdapters.TrainingPlanTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickBlastDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickBlastDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAthletes
            // 
            this.dgvAthletes.AllowUserToAddRows = false;
            this.dgvAthletes.AllowUserToDeleteRows = false;
            this.dgvAthletes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthletes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAthletes.Location = new System.Drawing.Point(12, 192);
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.RowHeadersVisible = false;
            this.dgvAthletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthletes.Size = new System.Drawing.Size(760, 257);
            this.dgvAthletes.TabIndex = 0;
            this.dgvAthletes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAthletes_CellClick);
            // 
            // btnAddAthlete
            // 
            this.btnAddAthlete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAthlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAthlete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAthlete.Location = new System.Drawing.Point(12, 12);
            this.btnAddAthlete.Name = "btnAddAthlete";
            this.btnAddAthlete.Size = new System.Drawing.Size(75, 23);
            this.btnAddAthlete.TabIndex = 1;
            this.btnAddAthlete.Text = "Add Athlete";
            this.btnAddAthlete.UseVisualStyleBackColor = false;
            this.btnAddAthlete.Click += new System.EventHandler(this.btnAddAthlete_Click);
            // 
            // btnEditAthlete
            // 
            this.btnEditAthlete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditAthlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAthlete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditAthlete.Location = new System.Drawing.Point(93, 12);
            this.btnEditAthlete.Name = "btnEditAthlete";
            this.btnEditAthlete.Size = new System.Drawing.Size(75, 23);
            this.btnEditAthlete.TabIndex = 2;
            this.btnEditAthlete.Text = "Edit Athlete";
            this.btnEditAthlete.UseVisualStyleBackColor = false;
            this.btnEditAthlete.Click += new System.EventHandler(this.btnEditAthlete_Click);
            // 
            // btnDeleteAthlete
            // 
            this.btnDeleteAthlete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAthlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAthlete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteAthlete.Location = new System.Drawing.Point(174, 12);
            this.btnDeleteAthlete.Name = "btnDeleteAthlete";
            this.btnDeleteAthlete.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteAthlete.TabIndex = 3;
            this.btnDeleteAthlete.Text = "Delete Athlete";
            this.btnDeleteAthlete.UseVisualStyleBackColor = false;
            this.btnDeleteAthlete.Click += new System.EventHandler(this.btnDeleteAthlete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(218, 62);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(134, 20);
            this.dtDOB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(215, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date of Birth";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(358, 62);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(355, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(522, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact No";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(522, 62);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 20);
            this.txtContact.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Current Weight";
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.Location = new System.Drawing.Point(12, 105);
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(200, 20);
            this.txtCurrentWeight.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(215, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Campatition Weight";
            // 
            // txtCampeignWeight
            // 
            this.txtCampeignWeight.Location = new System.Drawing.Point(215, 105);
            this.txtCampeignWeight.Name = "txtCampeignWeight";
            this.txtCampeignWeight.Size = new System.Drawing.Size(137, 20);
            this.txtCampeignWeight.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(522, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Branch";
            // 
            // cmbBranch
            // 
            this.cmbBranch.DataSource = this.branchBindingSource;
            this.cmbBranch.DisplayMember = "BranchName";
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(525, 105);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(197, 21);
            this.cmbBranch.TabIndex = 18;
            this.cmbBranch.ValueMember = "BranchID";
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.kickBlastDataSet;
            // 
            // kickBlastDataSet
            // 
            this.kickBlastDataSet.DataSetName = "KickBlastDataSet";
            this.kickBlastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(264, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(615, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(409, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 21;
            // 
            // cbTrainingPlans
            // 
            this.cbTrainingPlans.DataSource = this.trainingPlanBindingSource;
            this.cbTrainingPlans.DisplayMember = "PlanName";
            this.cbTrainingPlans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainingPlans.Location = new System.Drawing.Point(361, 105);
            this.cbTrainingPlans.Name = "cbTrainingPlans";
            this.cbTrainingPlans.Size = new System.Drawing.Size(158, 21);
            this.cbTrainingPlans.TabIndex = 26;
            this.cbTrainingPlans.ValueMember = "TrainingPlanID";
            // 
            // trainingPlanBindingSource
            // 
            this.trainingPlanBindingSource.DataMember = "TrainingPlan";
            this.trainingPlanBindingSource.DataSource = this.kickBlastDataSet1;
            // 
            // kickBlastDataSet1
            // 
            this.kickBlastDataSet1.DataSetName = "KickBlastDataSet1";
            this.kickBlastDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingPlanTableAdapter
            // 
            this.trainingPlanTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(358, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Training Plan";
            // 
            // AthleteManagement
            // 
            this.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTrainingPlans);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCampeignWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDeleteAthlete);
            this.Controls.Add(this.btnEditAthlete);
            this.Controls.Add(this.btnAddAthlete);
            this.Controls.Add(this.dgvAthletes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AthleteManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athlete Management";
            this.Load += new System.EventHandler(this.AthleteManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickBlastDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickBlastDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCampeignWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBranch;
        private KickBlastDataSet kickBlastDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private KickBlastDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbTrainingPlans;
        private KickBlastDataSet1 kickBlastDataSet1;
        private System.Windows.Forms.BindingSource trainingPlanBindingSource;
        private KickBlastDataSet1TableAdapters.TrainingPlanTableAdapter trainingPlanTableAdapter;
        private System.Windows.Forms.Label label9;
    }
}
