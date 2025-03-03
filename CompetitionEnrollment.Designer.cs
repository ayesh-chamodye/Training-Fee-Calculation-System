namespace Training_Fee_Calculation_System
{
    partial class CompetitionEnrollment
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvAthletes;
        private System.Windows.Forms.ComboBox cmbCompetitions;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblAthletes;
        private System.Windows.Forms.Label lblSelectCompetition;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitionEnrollment));
            this.dgvAthletes = new System.Windows.Forms.DataGridView();
            this.cmbCompetitions = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblAthletes = new System.Windows.Forms.Label();
            this.lblSelectCompetition = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.lvRegisteredCompatition = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAthletes
            // 
            this.dgvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthletes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAthletes.Location = new System.Drawing.Point(12, 40);
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthletes.Size = new System.Drawing.Size(526, 200);
            this.dgvAthletes.TabIndex = 0;
            this.dgvAthletes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAthletes_CellClick);
            // 
            // cmbCompetitions
            // 
            this.cmbCompetitions.FormattingEnabled = true;
            this.cmbCompetitions.Location = new System.Drawing.Point(12, 270);
            this.cmbCompetitions.Name = "cmbCompetitions";
            this.cmbCompetitions.Size = new System.Drawing.Size(200, 21);
            this.cmbCompetitions.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Location = new System.Drawing.Point(230, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register Athlete";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblAthletes
            // 
            this.lblAthletes.AutoSize = true;
            this.lblAthletes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAthletes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAthletes.Location = new System.Drawing.Point(12, 20);
            this.lblAthletes.Name = "lblAthletes";
            this.lblAthletes.Size = new System.Drawing.Size(45, 13);
            this.lblAthletes.TabIndex = 3;
            this.lblAthletes.Text = "Athletes";
            // 
            // lblSelectCompetition
            // 
            this.lblSelectCompetition.AutoSize = true;
            this.lblSelectCompetition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectCompetition.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSelectCompetition.Location = new System.Drawing.Point(12, 250);
            this.lblSelectCompetition.Name = "lblSelectCompetition";
            this.lblSelectCompetition.Size = new System.Drawing.Size(95, 13);
            this.lblSelectCompetition.TabIndex = 4;
            this.lblSelectCompetition.Text = "Select Competition";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(206, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(412, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUnregister
            // 
            this.btnUnregister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnregister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnregister.Location = new System.Drawing.Point(433, 388);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(105, 30);
            this.btnUnregister.TabIndex = 24;
            this.btnUnregister.Text = "Unregister Athlete";
            this.btnUnregister.UseVisualStyleBackColor = false;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // lvRegisteredCompatition
            // 
            this.lvRegisteredCompatition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvRegisteredCompatition.FullRowSelect = true;
            this.lvRegisteredCompatition.HideSelection = false;
            this.lvRegisteredCompatition.Location = new System.Drawing.Point(15, 321);
            this.lvRegisteredCompatition.Name = "lvRegisteredCompatition";
            this.lvRegisteredCompatition.Size = new System.Drawing.Size(391, 97);
            this.lvRegisteredCompatition.TabIndex = 25;
            this.lvRegisteredCompatition.UseCompatibleStateImageBehavior = false;
            this.lvRegisteredCompatition.View = System.Windows.Forms.View.Details;
            this.lvRegisteredCompatition.SelectedIndexChanged += new System.EventHandler(this.lvRegisteredCompatition_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Date";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Weight Class";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registered Competition";
            // 
            // CompetitionEnrollment
            // 
            this.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvRegisteredCompatition);
            this.Controls.Add(this.btnUnregister);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSelectCompetition);
            this.Controls.Add(this.lblAthletes);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbCompetitions);
            this.Controls.Add(this.dgvAthletes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompetitionEnrollment";
            this.Text = "Competition Enrollment";
            this.Load += new System.EventHandler(this.CompetitionEnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.ListView lvRegisteredCompatition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
