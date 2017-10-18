namespace PM_Search_UI
{
    partial class frmUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNoFieldEmpty = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePersonID = new System.Windows.Forms.TextBox();
            this.lblUpdatePersonID = new System.Windows.Forms.Label();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.lblUpdateVoterId = new System.Windows.Forms.Label();
            this.txtUpdateVoterID = new System.Windows.Forms.TextBox();
            this.txtUpdatedate = new System.Windows.Forms.TextBox();
            this.lblUpdateBirthDate = new System.Windows.Forms.Label();
            this.dtpUpdateDOB = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateFName = new System.Windows.Forms.Label();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.cboUpdateSex_ = new System.Windows.Forms.ComboBox();
            this.lblUpdateSex = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblNoFieldEmpty);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtUpdatePersonID);
            this.panel1.Controls.Add(this.lblUpdatePersonID);
            this.panel1.Controls.Add(this.txtUpdateFName);
            this.panel1.Controls.Add(this.lblUpdateVoterId);
            this.panel1.Controls.Add(this.txtUpdateVoterID);
            this.panel1.Controls.Add(this.txtUpdatedate);
            this.panel1.Controls.Add(this.lblUpdateBirthDate);
            this.panel1.Controls.Add(this.dtpUpdateDOB);
            this.panel1.Controls.Add(this.lblUpdateFName);
            this.panel1.Controls.Add(this.txtUpdateLName);
            this.panel1.Controls.Add(this.cboUpdateSex_);
            this.panel1.Controls.Add(this.lblUpdateSex);
            this.panel1.Controls.Add(this.lblUpdateLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 421);
            this.panel1.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(669, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoFieldEmpty
            // 
            this.lblNoFieldEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoFieldEmpty.AutoSize = true;
            this.lblNoFieldEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblNoFieldEmpty.Location = new System.Drawing.Point(301, 11);
            this.lblNoFieldEmpty.Name = "lblNoFieldEmpty";
            this.lblNoFieldEmpty.Size = new System.Drawing.Size(173, 20);
            this.lblNoFieldEmpty.TabIndex = 27;
            this.lblNoFieldEmpty.Text = "Fields cannot be empty";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(533, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdatePersonID
            // 
            this.txtUpdatePersonID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatePersonID.Location = new System.Drawing.Point(138, 72);
            this.txtUpdatePersonID.MaxLength = 9;
            this.txtUpdatePersonID.Name = "txtUpdatePersonID";
            this.txtUpdatePersonID.ReadOnly = true;
            this.txtUpdatePersonID.Size = new System.Drawing.Size(235, 26);
            this.txtUpdatePersonID.TabIndex = 9;
            // 
            // lblUpdatePersonID
            // 
            this.lblUpdatePersonID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatePersonID.AutoSize = true;
            this.lblUpdatePersonID.Location = new System.Drawing.Point(20, 75);
            this.lblUpdatePersonID.Name = "lblUpdatePersonID";
            this.lblUpdatePersonID.Size = new System.Drawing.Size(84, 20);
            this.lblUpdatePersonID.TabIndex = 0;
            this.lblUpdatePersonID.Text = "PersonID :";
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdateFName.Location = new System.Drawing.Point(533, 72);
            this.txtUpdateFName.MaxLength = 50;
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(235, 26);
            this.txtUpdateFName.TabIndex = 1;
            // 
            // lblUpdateVoterId
            // 
            this.lblUpdateVoterId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateVoterId.AutoSize = true;
            this.lblUpdateVoterId.Location = new System.Drawing.Point(412, 248);
            this.lblUpdateVoterId.Name = "lblUpdateVoterId";
            this.lblUpdateVoterId.Size = new System.Drawing.Size(73, 20);
            this.lblUpdateVoterId.TabIndex = 2;
            this.lblUpdateVoterId.Text = "VoterID :";
            // 
            // txtUpdateVoterID
            // 
            this.txtUpdateVoterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdateVoterID.Location = new System.Drawing.Point(533, 245);
            this.txtUpdateVoterID.MaxLength = 6;
            this.txtUpdateVoterID.Name = "txtUpdateVoterID";
            this.txtUpdateVoterID.Size = new System.Drawing.Size(235, 26);
            this.txtUpdateVoterID.TabIndex = 5;
            // 
            // txtUpdatedate
            // 
            this.txtUpdatedate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatedate.Location = new System.Drawing.Point(138, 244);
            this.txtUpdatedate.MaxLength = 10;
            this.txtUpdatedate.Name = "txtUpdatedate";
            this.txtUpdatedate.ReadOnly = true;
            this.txtUpdatedate.Size = new System.Drawing.Size(201, 26);
            this.txtUpdatedate.TabIndex = 4;
            // 
            // lblUpdateBirthDate
            // 
            this.lblUpdateBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateBirthDate.AutoSize = true;
            this.lblUpdateBirthDate.Location = new System.Drawing.Point(20, 247);
            this.lblUpdateBirthDate.Name = "lblUpdateBirthDate";
            this.lblUpdateBirthDate.Size = new System.Drawing.Size(85, 20);
            this.lblUpdateBirthDate.TabIndex = 3;
            this.lblUpdateBirthDate.Text = "BirthDate :";
            // 
            // dtpUpdateDOB
            // 
            this.dtpUpdateDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpUpdateDOB.CustomFormat = "";
            this.dtpUpdateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateDOB.Location = new System.Drawing.Point(345, 243);
            this.dtpUpdateDOB.Name = "dtpUpdateDOB";
            this.dtpUpdateDOB.Size = new System.Drawing.Size(28, 26);
            this.dtpUpdateDOB.TabIndex = 4;
            // 
            // lblUpdateFName
            // 
            this.lblUpdateFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateFName.AutoSize = true;
            this.lblUpdateFName.Location = new System.Drawing.Point(412, 75);
            this.lblUpdateFName.Name = "lblUpdateFName";
            this.lblUpdateFName.Size = new System.Drawing.Size(94, 20);
            this.lblUpdateFName.TabIndex = 6;
            this.lblUpdateFName.Text = "First Name :";
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdateLName.Location = new System.Drawing.Point(139, 159);
            this.txtUpdateLName.MaxLength = 50;
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(235, 26);
            this.txtUpdateLName.TabIndex = 2;
            // 
            // cboUpdateSex_
            // 
            this.cboUpdateSex_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboUpdateSex_.FormattingEnabled = true;
            this.cboUpdateSex_.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboUpdateSex_.Location = new System.Drawing.Point(533, 159);
            this.cboUpdateSex_.MaxLength = 10;
            this.cboUpdateSex_.Name = "cboUpdateSex_";
            this.cboUpdateSex_.Size = new System.Drawing.Size(235, 28);
            this.cboUpdateSex_.TabIndex = 3;
            // 
            // lblUpdateSex
            // 
            this.lblUpdateSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateSex.AutoSize = true;
            this.lblUpdateSex.Location = new System.Drawing.Point(412, 162);
            this.lblUpdateSex.Name = "lblUpdateSex";
            this.lblUpdateSex.Size = new System.Drawing.Size(44, 20);
            this.lblUpdateSex.TabIndex = 4;
            this.lblUpdateSex.Text = "Sex :";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(20, 162);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(94, 20);
            this.lblUpdateLastName.TabIndex = 5;
            this.lblUpdateLastName.Text = "Last Name :";
            // 
            // frmUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(838, 421);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Person Details";
            this.Load += new System.EventHandler(this.frmUpdatePerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoFieldEmpty;
        public System.Windows.Forms.TextBox txtUpdatePersonID;
        private System.Windows.Forms.Label lblUpdatePersonID;
        public System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.Label lblUpdateVoterId;
        public System.Windows.Forms.TextBox txtUpdateVoterID;
        public System.Windows.Forms.TextBox txtUpdatedate;
        private System.Windows.Forms.Label lblUpdateBirthDate;
        public System.Windows.Forms.DateTimePicker dtpUpdateDOB;
        private System.Windows.Forms.Label lblUpdateFName;
        public System.Windows.Forms.TextBox txtUpdateLName;
        public System.Windows.Forms.ComboBox cboUpdateSex_;
        private System.Windows.Forms.Label lblUpdateSex;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}