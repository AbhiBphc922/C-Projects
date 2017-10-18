namespace PM_Search_UI
{
    partial class frmAddPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoFieldEmpty_PersonDetails = new System.Windows.Forms.Label();
            this.btnCancel_PersonDetails = new System.Windows.Forms.Button();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.btnAdd_PersonDetails = new System.Windows.Forms.Button();
            this.lblAddVoterId_PersonDetails = new System.Windows.Forms.Label();
            this.txtAddVoterId = new System.Windows.Forms.TextBox();
            this.txtAddDate = new System.Windows.Forms.TextBox();
            this.lblAddBirthDate_PersonDetails = new System.Windows.Forms.Label();
            this.dtpAddDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddFirstName_PersonDetails = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.cboAddSex = new System.Windows.Forms.ComboBox();
            this.lblAddSex_PersonDetails = new System.Windows.Forms.Label();
            this.lblAddLastName_PersonDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNoFieldEmpty_PersonDetails);
            this.panel1.Controls.Add(this.btnCancel_PersonDetails);
            this.panel1.Controls.Add(this.txtAddFirstName);
            this.panel1.Controls.Add(this.btnAdd_PersonDetails);
            this.panel1.Controls.Add(this.lblAddVoterId_PersonDetails);
            this.panel1.Controls.Add(this.txtAddVoterId);
            this.panel1.Controls.Add(this.txtAddDate);
            this.panel1.Controls.Add(this.lblAddBirthDate_PersonDetails);
            this.panel1.Controls.Add(this.dtpAddDOB);
            this.panel1.Controls.Add(this.lblAddFirstName_PersonDetails);
            this.panel1.Controls.Add(this.txtAddLastName);
            this.panel1.Controls.Add(this.cboAddSex);
            this.panel1.Controls.Add(this.lblAddSex_PersonDetails);
            this.panel1.Controls.Add(this.lblAddLastName_PersonDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 572);
            this.panel1.TabIndex = 27;
            // 
            // lblNoFieldEmpty_PersonDetails
            // 
            this.lblNoFieldEmpty_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoFieldEmpty_PersonDetails.AutoSize = true;
            this.lblNoFieldEmpty_PersonDetails.ForeColor = System.Drawing.Color.Red;
            this.lblNoFieldEmpty_PersonDetails.Location = new System.Drawing.Point(156, 18);
            this.lblNoFieldEmpty_PersonDetails.Name = "lblNoFieldEmpty_PersonDetails";
            this.lblNoFieldEmpty_PersonDetails.Size = new System.Drawing.Size(173, 20);
            this.lblNoFieldEmpty_PersonDetails.TabIndex = 26;
            this.lblNoFieldEmpty_PersonDetails.Text = "Fields cannot be empty";
            // 
            // btnCancel_PersonDetails
            // 
            this.btnCancel_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel_PersonDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel_PersonDetails.Location = new System.Drawing.Point(277, 454);
            this.btnCancel_PersonDetails.Name = "btnCancel_PersonDetails";
            this.btnCancel_PersonDetails.Size = new System.Drawing.Size(97, 36);
            this.btnCancel_PersonDetails.TabIndex = 7;
            this.btnCancel_PersonDetails.Text = "Cancel";
            this.btnCancel_PersonDetails.UseVisualStyleBackColor = false;
            this.btnCancel_PersonDetails.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddFirstName.Location = new System.Drawing.Point(139, 72);
            this.txtAddFirstName.MaxLength = 50;
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(235, 26);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // btnAdd_PersonDetails
            // 
            this.btnAdd_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd_PersonDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd_PersonDetails.Location = new System.Drawing.Point(139, 454);
            this.btnAdd_PersonDetails.Name = "btnAdd_PersonDetails";
            this.btnAdd_PersonDetails.Size = new System.Drawing.Size(103, 36);
            this.btnAdd_PersonDetails.TabIndex = 6;
            this.btnAdd_PersonDetails.Text = "Add";
            this.btnAdd_PersonDetails.UseVisualStyleBackColor = false;
            this.btnAdd_PersonDetails.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddVoterId_PersonDetails
            // 
            this.lblAddVoterId_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddVoterId_PersonDetails.AutoSize = true;
            this.lblAddVoterId_PersonDetails.Location = new System.Drawing.Point(20, 390);
            this.lblAddVoterId_PersonDetails.Name = "lblAddVoterId_PersonDetails";
            this.lblAddVoterId_PersonDetails.Size = new System.Drawing.Size(73, 20);
            this.lblAddVoterId_PersonDetails.TabIndex = 2;
            this.lblAddVoterId_PersonDetails.Text = "VoterID :";
            // 
            // txtAddVoterId
            // 
            this.txtAddVoterId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddVoterId.Location = new System.Drawing.Point(139, 387);
            this.txtAddVoterId.MaxLength = 6;
            this.txtAddVoterId.Name = "txtAddVoterId";
            this.txtAddVoterId.Size = new System.Drawing.Size(235, 26);
            this.txtAddVoterId.TabIndex = 5;
            // 
            // txtAddDate
            // 
            this.txtAddDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddDate.Location = new System.Drawing.Point(139, 300);
            this.txtAddDate.MaxLength = 10;
            this.txtAddDate.Name = "txtAddDate";
            this.txtAddDate.ReadOnly = true;
            this.txtAddDate.Size = new System.Drawing.Size(201, 26);
            this.txtAddDate.TabIndex = 4;
            // 
            // lblAddBirthDate_PersonDetails
            // 
            this.lblAddBirthDate_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddBirthDate_PersonDetails.AutoSize = true;
            this.lblAddBirthDate_PersonDetails.Location = new System.Drawing.Point(20, 303);
            this.lblAddBirthDate_PersonDetails.Name = "lblAddBirthDate_PersonDetails";
            this.lblAddBirthDate_PersonDetails.Size = new System.Drawing.Size(85, 20);
            this.lblAddBirthDate_PersonDetails.TabIndex = 3;
            this.lblAddBirthDate_PersonDetails.Text = "BirthDate :";
            // 
            // dtpAddDOB
            // 
            this.dtpAddDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAddDOB.CustomFormat = "";
            this.dtpAddDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddDOB.Location = new System.Drawing.Point(346, 298);
            this.dtpAddDOB.Name = "dtpAddDOB";
            this.dtpAddDOB.Size = new System.Drawing.Size(28, 26);
            this.dtpAddDOB.TabIndex = 4;
            this.dtpAddDOB.ValueChanged += new System.EventHandler(this.dtpAddDOB_ValueChanged);
            // 
            // lblAddFirstName_PersonDetails
            // 
            this.lblAddFirstName_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddFirstName_PersonDetails.AutoSize = true;
            this.lblAddFirstName_PersonDetails.Location = new System.Drawing.Point(20, 75);
            this.lblAddFirstName_PersonDetails.Name = "lblAddFirstName_PersonDetails";
            this.lblAddFirstName_PersonDetails.Size = new System.Drawing.Size(94, 20);
            this.lblAddFirstName_PersonDetails.TabIndex = 6;
            this.lblAddFirstName_PersonDetails.Text = "First Name :";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddLastName.Location = new System.Drawing.Point(139, 155);
            this.txtAddLastName.MaxLength = 50;
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(235, 26);
            this.txtAddLastName.TabIndex = 2;
            // 
            // cboAddSex
            // 
            this.cboAddSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAddSex.FormattingEnabled = true;
            this.cboAddSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboAddSex.Location = new System.Drawing.Point(139, 221);
            this.cboAddSex.MaxLength = 10;
            this.cboAddSex.Name = "cboAddSex";
            this.cboAddSex.Size = new System.Drawing.Size(235, 28);
            this.cboAddSex.TabIndex = 3;
            // 
            // lblAddSex_PersonDetails
            // 
            this.lblAddSex_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddSex_PersonDetails.AutoSize = true;
            this.lblAddSex_PersonDetails.Location = new System.Drawing.Point(20, 224);
            this.lblAddSex_PersonDetails.Name = "lblAddSex_PersonDetails";
            this.lblAddSex_PersonDetails.Size = new System.Drawing.Size(44, 20);
            this.lblAddSex_PersonDetails.TabIndex = 4;
            this.lblAddSex_PersonDetails.Text = "Sex :";
            // 
            // lblAddLastName_PersonDetails
            // 
            this.lblAddLastName_PersonDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddLastName_PersonDetails.AutoSize = true;
            this.lblAddLastName_PersonDetails.Location = new System.Drawing.Point(20, 158);
            this.lblAddLastName_PersonDetails.Name = "lblAddLastName_PersonDetails";
            this.lblAddLastName_PersonDetails.Size = new System.Drawing.Size(94, 20);
            this.lblAddLastName_PersonDetails.TabIndex = 5;
            this.lblAddLastName_PersonDetails.Text = "Last Name :";
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(494, 572);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Person Details";
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel_PersonDetails;
        private System.Windows.Forms.Button btnAdd_PersonDetails;
        public System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label lblAddVoterId_PersonDetails;
        public System.Windows.Forms.TextBox txtAddVoterId;
        public System.Windows.Forms.TextBox txtAddDate;
        private System.Windows.Forms.Label lblAddBirthDate_PersonDetails;
        public System.Windows.Forms.DateTimePicker dtpAddDOB;
        private System.Windows.Forms.Label lblAddFirstName_PersonDetails;
        public System.Windows.Forms.TextBox txtAddLastName;
        public System.Windows.Forms.ComboBox cboAddSex;
        private System.Windows.Forms.Label lblAddSex_PersonDetails;
        private System.Windows.Forms.Label lblAddLastName_PersonDetails;
        private System.Windows.Forms.Label lblNoFieldEmpty_PersonDetails;
    }
}