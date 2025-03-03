namespace Training_Fee_Calculation_System
{
    partial class PrivateCoaching
    {
        private System.ComponentModel.IContainer components = null; 
        private System.Windows.Forms.ComboBox cmbAthlete;
        private System.Windows.Forms.ComboBox cmbCoach;
        private System.Windows.Forms.DateTimePicker dtpCoachingDate;
        private System.Windows.Forms.TextBox txtCoachingHours;
        private System.Windows.Forms.Label lblAthlete;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblCoachingDate;
        private System.Windows.Forms.Label lblCoachingHours;
        private System.Windows.Forms.Button btnSubmitCoaching;
        private System.Windows.Forms.DataGridView dgvPrivateCoaching;
        private System.Windows.Forms.Label lblMessage;

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
            this.cmbAthlete = new System.Windows.Forms.ComboBox();
            this.cmbCoach = new System.Windows.Forms.ComboBox();
            this.dtpCoachingDate = new System.Windows.Forms.DateTimePicker();
            this.txtCoachingHours = new System.Windows.Forms.TextBox();
            this.lblAthlete = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblCoachingDate = new System.Windows.Forms.Label();
            this.lblCoachingHours = new System.Windows.Forms.Label();
            this.btnSubmitCoaching = new System.Windows.Forms.Button();
            this.dgvPrivateCoaching = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivateCoaching)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAthlete
            // 
            this.cmbAthlete.FormattingEnabled = true;
            this.cmbAthlete.Location = new System.Drawing.Point(120, 30);
            this.cmbAthlete.Name = "cmbAthlete";
            this.cmbAthlete.Size = new System.Drawing.Size(200, 21);
            this.cmbAthlete.TabIndex = 0;
            // 
            // cmbCoach
            // 
            this.cmbCoach.FormattingEnabled = true;
            this.cmbCoach.Location = new System.Drawing.Point(120, 70);
            this.cmbCoach.Name = "cmbCoach";
            this.cmbCoach.Size = new System.Drawing.Size(200, 21);
            this.cmbCoach.TabIndex = 1;
            // 
            // dtpCoachingDate
            // 
            this.dtpCoachingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCoachingDate.Location = new System.Drawing.Point(120, 110);
            this.dtpCoachingDate.Name = "dtpCoachingDate";
            this.dtpCoachingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCoachingDate.TabIndex = 2;
            // 
            // txtCoachingHours
            // 
            this.txtCoachingHours.Location = new System.Drawing.Point(120, 150);
            this.txtCoachingHours.Name = "txtCoachingHours";
            this.txtCoachingHours.Size = new System.Drawing.Size(100, 20);
            this.txtCoachingHours.TabIndex = 3;
            // 
            // lblAthlete
            // 
            this.lblAthlete.AutoSize = true;
            this.lblAthlete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAthlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAthlete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAthlete.Location = new System.Drawing.Point(30, 30);
            this.lblAthlete.Name = "lblAthlete";
            this.lblAthlete.Size = new System.Drawing.Size(43, 13);
            this.lblAthlete.TabIndex = 4;
            this.lblAthlete.Text = "Athlete:";
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCoach.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCoach.Location = new System.Drawing.Point(30, 70);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(41, 13);
            this.lblCoach.TabIndex = 5;
            this.lblCoach.Text = "Coach:";
            // 
            // lblCoachingDate
            // 
            this.lblCoachingDate.AutoSize = true;
            this.lblCoachingDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCoachingDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCoachingDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCoachingDate.Location = new System.Drawing.Point(30, 110);
            this.lblCoachingDate.Name = "lblCoachingDate";
            this.lblCoachingDate.Size = new System.Drawing.Size(81, 13);
            this.lblCoachingDate.TabIndex = 6;
            this.lblCoachingDate.Text = "Coaching Date:";
            // 
            // lblCoachingHours
            // 
            this.lblCoachingHours.AutoSize = true;
            this.lblCoachingHours.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCoachingHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCoachingHours.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCoachingHours.Location = new System.Drawing.Point(30, 150);
            this.lblCoachingHours.Name = "lblCoachingHours";
            this.lblCoachingHours.Size = new System.Drawing.Size(86, 13);
            this.lblCoachingHours.TabIndex = 7;
            this.lblCoachingHours.Text = "Coaching Hours:";
            // 
            // btnSubmitCoaching
            // 
            this.btnSubmitCoaching.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitCoaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitCoaching.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmitCoaching.Location = new System.Drawing.Point(120, 190);
            this.btnSubmitCoaching.Name = "btnSubmitCoaching";
            this.btnSubmitCoaching.Size = new System.Drawing.Size(200, 23);
            this.btnSubmitCoaching.TabIndex = 8;
            this.btnSubmitCoaching.Text = "Submit Coaching Session";
            this.btnSubmitCoaching.UseVisualStyleBackColor = false;
            this.btnSubmitCoaching.Click += new System.EventHandler(this.btnSubmitCoaching_Click);
            // 
            // dgvPrivateCoaching
            // 
            this.dgvPrivateCoaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivateCoaching.Location = new System.Drawing.Point(30, 230);
            this.dgvPrivateCoaching.Name = "dgvPrivateCoaching";
            this.dgvPrivateCoaching.Size = new System.Drawing.Size(740, 250);
            this.dgvPrivateCoaching.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 500);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 10;
            // 
            // PrivateCoaching
            // 
            this.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvPrivateCoaching);
            this.Controls.Add(this.btnSubmitCoaching);
            this.Controls.Add(this.lblCoachingHours);
            this.Controls.Add(this.lblCoachingDate);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.lblAthlete);
            this.Controls.Add(this.txtCoachingHours);
            this.Controls.Add(this.dtpCoachingDate);
            this.Controls.Add(this.cmbCoach);
            this.Controls.Add(this.cmbAthlete);
            this.Name = "PrivateCoaching";
            this.Text = "Private Coaching Form";
            this.Load += new System.EventHandler(this.PrivateCoachingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivateCoaching)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
