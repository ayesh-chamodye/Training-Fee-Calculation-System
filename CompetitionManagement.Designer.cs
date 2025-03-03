namespace Training_Fee_Calculation_System
{
    partial class CompetitionManagement
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitionManagement));
            this.txtCompetitionName = new System.Windows.Forms.TextBox();
            this.txtWeightCategory = new System.Windows.Forms.TextBox();
            this.txtCostPerCompetition = new System.Windows.Forms.TextBox();
            this.dtpCompetitionDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.btnUpdateCompetition = new System.Windows.Forms.Button();
            this.btnDeleteCompetition = new System.Windows.Forms.Button();
            this.dgvCompetitions = new System.Windows.Forms.DataGridView();
            this.lblCompetitionName = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblCostPerCompetition = new System.Windows.Forms.Label();
            this.lblCompetitionDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompetitionName
            // 
            this.txtCompetitionName.Location = new System.Drawing.Point(200, 30);
            this.txtCompetitionName.Name = "txtCompetitionName";
            this.txtCompetitionName.Size = new System.Drawing.Size(200, 20);
            this.txtCompetitionName.TabIndex = 0;
            // 
            // txtWeightCategory
            // 
            this.txtWeightCategory.Location = new System.Drawing.Point(200, 70);
            this.txtWeightCategory.Name = "txtWeightCategory";
            this.txtWeightCategory.Size = new System.Drawing.Size(200, 20);
            this.txtWeightCategory.TabIndex = 1;
            // 
            // txtCostPerCompetition
            // 
            this.txtCostPerCompetition.Location = new System.Drawing.Point(200, 110);
            this.txtCostPerCompetition.Name = "txtCostPerCompetition";
            this.txtCostPerCompetition.Size = new System.Drawing.Size(200, 20);
            this.txtCostPerCompetition.TabIndex = 2;
            // 
            // dtpCompetitionDate
            // 
            this.dtpCompetitionDate.Location = new System.Drawing.Point(200, 150);
            this.dtpCompetitionDate.Name = "dtpCompetitionDate";
            this.dtpCompetitionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCompetitionDate.TabIndex = 3;
            // 
            // btnAddCompetition
            // 
            this.btnAddCompetition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompetition.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCompetition.Location = new System.Drawing.Point(150, 190);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(75, 30);
            this.btnAddCompetition.TabIndex = 4;
            this.btnAddCompetition.Text = "Add";
            this.btnAddCompetition.UseVisualStyleBackColor = false;
            this.btnAddCompetition.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // btnUpdateCompetition
            // 
            this.btnUpdateCompetition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompetition.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateCompetition.Location = new System.Drawing.Point(250, 190);
            this.btnUpdateCompetition.Name = "btnUpdateCompetition";
            this.btnUpdateCompetition.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateCompetition.TabIndex = 5;
            this.btnUpdateCompetition.Text = "Update";
            this.btnUpdateCompetition.UseVisualStyleBackColor = false;
            this.btnUpdateCompetition.Click += new System.EventHandler(this.btnUpdateCompetition_Click);
            // 
            // btnDeleteCompetition
            // 
            this.btnDeleteCompetition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompetition.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteCompetition.Location = new System.Drawing.Point(350, 190);
            this.btnDeleteCompetition.Name = "btnDeleteCompetition";
            this.btnDeleteCompetition.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteCompetition.TabIndex = 6;
            this.btnDeleteCompetition.Text = "Delete";
            this.btnDeleteCompetition.UseVisualStyleBackColor = false;
            this.btnDeleteCompetition.Click += new System.EventHandler(this.btnDeleteCompetition_Click);
            // 
            // dgvCompetitions
            // 
            this.dgvCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetitions.Location = new System.Drawing.Point(50, 230);
            this.dgvCompetitions.Name = "dgvCompetitions";
            this.dgvCompetitions.Size = new System.Drawing.Size(500, 150);
            this.dgvCompetitions.TabIndex = 7;
            this.dgvCompetitions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompetitions_CellClick);
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.AutoSize = true;
            this.lblCompetitionName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompetitionName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompetitionName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCompetitionName.Location = new System.Drawing.Point(50, 30);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(93, 13);
            this.lblCompetitionName.TabIndex = 8;
            this.lblCompetitionName.Text = "Competition Name";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWeightCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWeightCategory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWeightCategory.Location = new System.Drawing.Point(50, 70);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(86, 13);
            this.lblWeightCategory.TabIndex = 9;
            this.lblWeightCategory.Text = "Weight Category";
            // 
            // lblCostPerCompetition
            // 
            this.lblCostPerCompetition.AutoSize = true;
            this.lblCostPerCompetition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCostPerCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCostPerCompetition.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCostPerCompetition.Location = new System.Drawing.Point(49, 115);
            this.lblCostPerCompetition.Name = "lblCostPerCompetition";
            this.lblCostPerCompetition.Size = new System.Drawing.Size(129, 13);
            this.lblCostPerCompetition.TabIndex = 10;
            this.lblCostPerCompetition.Text = "Cost per Competition (Rs.)";
            // 
            // lblCompetitionDate
            // 
            this.lblCompetitionDate.AutoSize = true;
            this.lblCompetitionDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompetitionDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompetitionDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCompetitionDate.Location = new System.Drawing.Point(50, 150);
            this.lblCompetitionDate.Name = "lblCompetitionDate";
            this.lblCompetitionDate.Size = new System.Drawing.Size(88, 13);
            this.lblCompetitionDate.TabIndex = 11;
            this.lblCompetitionDate.Text = "Competition Date";
            // 
            // CompetitionManagement
            // 
            this.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblCompetitionDate);
            this.Controls.Add(this.lblCostPerCompetition);
            this.Controls.Add(this.lblWeightCategory);
            this.Controls.Add(this.lblCompetitionName);
            this.Controls.Add(this.dgvCompetitions);
            this.Controls.Add(this.btnDeleteCompetition);
            this.Controls.Add(this.btnUpdateCompetition);
            this.Controls.Add(this.btnAddCompetition);
            this.Controls.Add(this.dtpCompetitionDate);
            this.Controls.Add(this.txtCostPerCompetition);
            this.Controls.Add(this.txtWeightCategory);
            this.Controls.Add(this.txtCompetitionName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompetitionManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCompetitionName;
        private System.Windows.Forms.TextBox txtWeightCategory;
        private System.Windows.Forms.TextBox txtCostPerCompetition;
        private System.Windows.Forms.DateTimePicker dtpCompetitionDate;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.Button btnUpdateCompetition;
        private System.Windows.Forms.Button btnDeleteCompetition;
        private System.Windows.Forms.DataGridView dgvCompetitions;
        private System.Windows.Forms.Label lblCompetitionName;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblCostPerCompetition;
        private System.Windows.Forms.Label lblCompetitionDate;
    }
}
