namespace Training_Fee_Calculation_System
{
    partial class FeeCalculation
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbAthlete;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Label lblAthlete;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTotalCost;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeCalculation));
            this.cmbAthlete = new System.Windows.Forms.ComboBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.lblAthlete = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.cmbTrainingPlan = new System.Windows.Forms.ComboBox();
            this.lblTrainingPlan = new System.Windows.Forms.Label();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbAthlete
            // 
            this.cmbAthlete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAthlete.FormattingEnabled = true;
            this.cmbAthlete.Location = new System.Drawing.Point(150, 30);
            this.cmbAthlete.Name = "cmbAthlete";
            this.cmbAthlete.Size = new System.Drawing.Size(200, 21);
            this.cmbAthlete.TabIndex = 0;
            this.cmbAthlete.SelectedIndexChanged += new System.EventHandler(this.cmbAthlete_SelectedIndexChanged);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(150, 158);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(200, 20);
            this.txtTotalCost.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(67, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveInvoice.Location = new System.Drawing.Point(217, 214);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(100, 30);
            this.btnSaveInvoice.TabIndex = 4;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // lblAthlete
            // 
            this.lblAthlete.AutoSize = true;
            this.lblAthlete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAthlete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAthlete.Location = new System.Drawing.Point(50, 33);
            this.lblAthlete.Name = "lblAthlete";
            this.lblAthlete.Size = new System.Drawing.Size(43, 13);
            this.lblAthlete.TabIndex = 5;
            this.lblAthlete.Text = "Athlete:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMonth.Location = new System.Drawing.Point(50, 73);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalCost.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalCost.Location = new System.Drawing.Point(50, 161);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // cmbTrainingPlan
            // 
            this.cmbTrainingPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrainingPlan.FormattingEnabled = true;
            this.cmbTrainingPlan.Location = new System.Drawing.Point(150, 115);
            this.cmbTrainingPlan.Name = "cmbTrainingPlan";
            this.cmbTrainingPlan.Size = new System.Drawing.Size(200, 21);
            this.cmbTrainingPlan.TabIndex = 8;
            // 
            // lblTrainingPlan
            // 
            this.lblTrainingPlan.AutoSize = true;
            this.lblTrainingPlan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrainingPlan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTrainingPlan.Location = new System.Drawing.Point(50, 118);
            this.lblTrainingPlan.Name = "lblTrainingPlan";
            this.lblTrainingPlan.Size = new System.Drawing.Size(72, 13);
            this.lblTrainingPlan.TabIndex = 9;
            this.lblTrainingPlan.Text = "Training Plan:";
            // 
            // dtMonth
            // 
            this.dtMonth.CustomFormat = "yyyy-MM";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(150, 73);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.ShowUpDown = true;
            this.dtMonth.Size = new System.Drawing.Size(200, 20);
            this.dtMonth.TabIndex = 10;
            // 
            // FeeCalculation
            // 
            this.BackgroundImage = global::Training_Fee_Calculation_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 278);
            this.Controls.Add(this.dtMonth);
            this.Controls.Add(this.cmbTrainingPlan);
            this.Controls.Add(this.lblTrainingPlan);
            this.Controls.Add(this.cmbAthlete);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.lblAthlete);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTotalCost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeeCalculation";
            this.Text = "Fee Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbTrainingPlan;
        private System.Windows.Forms.Label lblTrainingPlan;
        private System.Windows.Forms.DateTimePicker dtMonth;
    }
}
