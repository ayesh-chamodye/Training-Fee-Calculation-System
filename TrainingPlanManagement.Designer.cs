namespace Training_Fee_Calculation_System
{
    partial class TrainingPlanManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTrainingPlans;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.TextBox txtMaxPrivateCoachingHours;
        private System.Windows.Forms.TextBox txtCostPerWeek;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblMaxPrivateCoachingHours;
        private System.Windows.Forms.Label lblCostPerWeek;
        private System.Windows.Forms.Label lblStatus;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingPlanManagement));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTrainingPlans = new System.Windows.Forms.DataGridView();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.txtMaxPrivateCoachingHours = new System.Windows.Forms.TextBox();
            this.txtCostPerWeek = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblMaxPrivateCoachingHours = new System.Windows.Forms.Label();
            this.lblCostPerWeek = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingPlans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Training Plan Management";
            // 
            // dgvTrainingPlans
            // 
            this.dgvTrainingPlans.AllowUserToAddRows = false;
            this.dgvTrainingPlans.AllowUserToDeleteRows = false;
            this.dgvTrainingPlans.AllowUserToResizeRows = false;
            this.dgvTrainingPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingPlans.Location = new System.Drawing.Point(20, 60);
            this.dgvTrainingPlans.Name = "dgvTrainingPlans";
            this.dgvTrainingPlans.ReadOnly = true;
            this.dgvTrainingPlans.RowHeadersVisible = false;
            this.dgvTrainingPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainingPlans.Size = new System.Drawing.Size(554, 200);
            this.dgvTrainingPlans.TabIndex = 1;
            this.dgvTrainingPlans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainingPlans_CellClick);
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(173, 280);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(200, 20);
            this.txtPlanName.TabIndex = 2;
            // 
            // txtMaxPrivateCoachingHours
            // 
            this.txtMaxPrivateCoachingHours.Location = new System.Drawing.Point(173, 320);
            this.txtMaxPrivateCoachingHours.Name = "txtMaxPrivateCoachingHours";
            this.txtMaxPrivateCoachingHours.Size = new System.Drawing.Size(200, 20);
            this.txtMaxPrivateCoachingHours.TabIndex = 3;
            // 
            // txtCostPerWeek
            // 
            this.txtCostPerWeek.Location = new System.Drawing.Point(173, 360);
            this.txtCostPerWeek.Name = "txtCostPerWeek";
            this.txtCostPerWeek.Size = new System.Drawing.Size(200, 20);
            this.txtCostPerWeek.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(474, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Plan";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(474, 320);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Plan";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(474, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Plan";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(474, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlanName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlanName.Location = new System.Drawing.Point(20, 280);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(62, 13);
            this.lblPlanName.TabIndex = 9;
            this.lblPlanName.Text = "Plan Name:";
            // 
            // lblMaxPrivateCoachingHours
            // 
            this.lblMaxPrivateCoachingHours.AutoSize = true;
            this.lblMaxPrivateCoachingHours.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxPrivateCoachingHours.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMaxPrivateCoachingHours.Location = new System.Drawing.Point(20, 320);
            this.lblMaxPrivateCoachingHours.Name = "lblMaxPrivateCoachingHours";
            this.lblMaxPrivateCoachingHours.Size = new System.Drawing.Size(145, 13);
            this.lblMaxPrivateCoachingHours.TabIndex = 10;
            this.lblMaxPrivateCoachingHours.Text = "Max Private Coaching Hours:";
            // 
            // lblCostPerWeek
            // 
            this.lblCostPerWeek.AutoSize = true;
            this.lblCostPerWeek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCostPerWeek.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCostPerWeek.Location = new System.Drawing.Point(20, 360);
            this.lblCostPerWeek.Name = "lblCostPerWeek";
            this.lblCostPerWeek.Size = new System.Drawing.Size(82, 13);
            this.lblCostPerWeek.TabIndex = 11;
            this.lblCostPerWeek.Text = "Cost Per Week:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(20, 440);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // TrainingPlanManagement
            // 
            this.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvTrainingPlans);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.txtMaxPrivateCoachingHours);
            this.Controls.Add(this.txtCostPerWeek);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPlanName);
            this.Controls.Add(this.lblMaxPrivateCoachingHours);
            this.Controls.Add(this.lblCostPerWeek);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainingPlanManagement";
            this.Text = "Training Plan Management";
            this.Load += new System.EventHandler(this.TrainingPlanManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingPlans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
