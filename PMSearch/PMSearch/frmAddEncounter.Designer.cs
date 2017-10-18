namespace PM_Search_UI
{
    partial class frmAddEncounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEncounter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddMedication = new System.Windows.Forms.TextBox();
            this.txtAddPhysician = new System.Windows.Forms.TextBox();
            this.lblAddMedication = new System.Windows.Forms.Label();
            this.lblNoFieldEmpty_EncounterForm = new System.Windows.Forms.Label();
            this.lblAddPhysician = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblVoterId = new System.Windows.Forms.Label();
            this.txtAddPersonId = new System.Windows.Forms.TextBox();
            this.lblAddPersonId = new System.Windows.Forms.Label();
            this.txtVoterId = new System.Windows.Forms.TextBox();
            this.txtBDate = new System.Windows.Forms.TextBox();
            this.lblAddBirthDate = new System.Windows.Forms.Label();
            this.dtpAddBD = new System.Windows.Forms.DateTimePicker();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.cboAddSex = new System.Windows.Forms.ComboBox();
            this.lblPersonSex = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 477);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtAddMedication);
            this.panel2.Controls.Add(this.txtAddPhysician);
            this.panel2.Controls.Add(this.lblAddMedication);
            this.panel2.Controls.Add(this.lblNoFieldEmpty_EncounterForm);
            this.panel2.Controls.Add(this.lblAddPhysician);
            this.panel2.Controls.Add(this.txtFName);
            this.panel2.Controls.Add(this.lblVoterId);
            this.panel2.Controls.Add(this.txtAddPersonId);
            this.panel2.Controls.Add(this.lblAddPersonId);
            this.panel2.Controls.Add(this.txtVoterId);
            this.panel2.Controls.Add(this.txtBDate);
            this.panel2.Controls.Add(this.lblAddBirthDate);
            this.panel2.Controls.Add(this.dtpAddBD);
            this.panel2.Controls.Add(this.lblFName);
            this.panel2.Controls.Add(this.txtLName);
            this.panel2.Controls.Add(this.cboAddSex);
            this.panel2.Controls.Add(this.lblPersonSex);
            this.panel2.Controls.Add(this.lblLName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 477);
            this.panel2.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(720, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 36);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(507, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtAddMedication
            // 
            this.txtAddMedication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddMedication.Location = new System.Drawing.Point(591, 324);
            this.txtAddMedication.MaxLength = 100;
            this.txtAddMedication.Name = "txtAddMedication";
            this.txtAddMedication.Size = new System.Drawing.Size(235, 26);
            this.txtAddMedication.TabIndex = 2;
            // 
            // txtAddPhysician
            // 
            this.txtAddPhysician.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddPhysician.Location = new System.Drawing.Point(170, 324);
            this.txtAddPhysician.MaxLength = 50;
            this.txtAddPhysician.Name = "txtAddPhysician";
            this.txtAddPhysician.Size = new System.Drawing.Size(235, 26);
            this.txtAddPhysician.TabIndex = 1;
            // 
            // lblAddMedication
            // 
            this.lblAddMedication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddMedication.AutoSize = true;
            this.lblAddMedication.Location = new System.Drawing.Point(467, 327);
            this.lblAddMedication.Name = "lblAddMedication";
            this.lblAddMedication.Size = new System.Drawing.Size(94, 20);
            this.lblAddMedication.TabIndex = 5;
            this.lblAddMedication.Text = "Medication :";
            // 
            // lblNoFieldEmpty_EncounterForm
            // 
            this.lblNoFieldEmpty_EncounterForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoFieldEmpty_EncounterForm.AutoSize = true;
            this.lblNoFieldEmpty_EncounterForm.ForeColor = System.Drawing.Color.Red;
            this.lblNoFieldEmpty_EncounterForm.Location = new System.Drawing.Point(356, 25);
            this.lblNoFieldEmpty_EncounterForm.Name = "lblNoFieldEmpty_EncounterForm";
            this.lblNoFieldEmpty_EncounterForm.Size = new System.Drawing.Size(173, 20);
            this.lblNoFieldEmpty_EncounterForm.TabIndex = 26;
            this.lblNoFieldEmpty_EncounterForm.Text = "Fields cannot be empty";
            // 
            // lblAddPhysician
            // 
            this.lblAddPhysician.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddPhysician.AutoSize = true;
            this.lblAddPhysician.Location = new System.Drawing.Point(40, 327);
            this.lblAddPhysician.Name = "lblAddPhysician";
            this.lblAddPhysician.Size = new System.Drawing.Size(83, 20);
            this.lblAddPhysician.TabIndex = 6;
            this.lblAddPhysician.Text = "Physician :";
            // 
            // txtFName
            // 
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFName.Location = new System.Drawing.Point(591, 77);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(235, 26);
            this.txtFName.TabIndex = 11;
            // 
            // lblVoterId
            // 
            this.lblVoterId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterId.AutoSize = true;
            this.lblVoterId.Location = new System.Drawing.Point(467, 247);
            this.lblVoterId.Name = "lblVoterId";
            this.lblVoterId.Size = new System.Drawing.Size(73, 20);
            this.lblVoterId.TabIndex = 2;
            this.lblVoterId.Text = "VoterID :";
            // 
            // txtAddPersonId
            // 
            this.txtAddPersonId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddPersonId.Location = new System.Drawing.Point(170, 77);
            this.txtAddPersonId.Name = "txtAddPersonId";
            this.txtAddPersonId.ReadOnly = true;
            this.txtAddPersonId.Size = new System.Drawing.Size(235, 26);
            this.txtAddPersonId.TabIndex = 10;
            // 
            // lblAddPersonId
            // 
            this.lblAddPersonId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddPersonId.AutoSize = true;
            this.lblAddPersonId.Location = new System.Drawing.Point(37, 80);
            this.lblAddPersonId.Name = "lblAddPersonId";
            this.lblAddPersonId.Size = new System.Drawing.Size(88, 20);
            this.lblAddPersonId.TabIndex = 2;
            this.lblAddPersonId.Text = "Person ID :";
            // 
            // txtVoterId
            // 
            this.txtVoterId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterId.Location = new System.Drawing.Point(591, 244);
            this.txtVoterId.Name = "txtVoterId";
            this.txtVoterId.ReadOnly = true;
            this.txtVoterId.Size = new System.Drawing.Size(235, 26);
            this.txtVoterId.TabIndex = 10;
            // 
            // txtBDate
            // 
            this.txtBDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBDate.Location = new System.Drawing.Point(170, 244);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.ReadOnly = true;
            this.txtBDate.Size = new System.Drawing.Size(201, 26);
            this.txtBDate.TabIndex = 22;
            // 
            // lblAddBirthDate
            // 
            this.lblAddBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddBirthDate.AutoSize = true;
            this.lblAddBirthDate.Location = new System.Drawing.Point(40, 247);
            this.lblAddBirthDate.Name = "lblAddBirthDate";
            this.lblAddBirthDate.Size = new System.Drawing.Size(85, 20);
            this.lblAddBirthDate.TabIndex = 3;
            this.lblAddBirthDate.Text = "BirthDate :";
            // 
            // dtpAddBD
            // 
            this.dtpAddBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAddBD.CustomFormat = "";
            this.dtpAddBD.Enabled = false;
            this.dtpAddBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddBD.Location = new System.Drawing.Point(377, 247);
            this.dtpAddBD.Name = "dtpAddBD";
            this.dtpAddBD.Size = new System.Drawing.Size(28, 26);
            this.dtpAddBD.TabIndex = 23;
            // 
            // lblFName
            // 
            this.lblFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(446, 80);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(94, 20);
            this.lblFName.TabIndex = 6;
            this.lblFName.Text = "First Name :";
            // 
            // txtLName
            // 
            this.txtLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLName.Location = new System.Drawing.Point(170, 159);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(235, 26);
            this.txtLName.TabIndex = 7;
            // 
            // cboAddSex
            // 
            this.cboAddSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAddSex.Enabled = false;
            this.cboAddSex.FormattingEnabled = true;
            this.cboAddSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboAddSex.Location = new System.Drawing.Point(591, 159);
            this.cboAddSex.Name = "cboAddSex";
            this.cboAddSex.Size = new System.Drawing.Size(235, 28);
            this.cboAddSex.TabIndex = 21;
            // 
            // lblPersonSex
            // 
            this.lblPersonSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonSex.AutoSize = true;
            this.lblPersonSex.Location = new System.Drawing.Point(467, 162);
            this.lblPersonSex.Name = "lblPersonSex";
            this.lblPersonSex.Size = new System.Drawing.Size(44, 20);
            this.lblPersonSex.TabIndex = 4;
            this.lblPersonSex.Text = "Sex :";
            // 
            // lblLName
            // 
            this.lblLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(37, 162);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(94, 20);
            this.lblLName.TabIndex = 5;
            this.lblLName.Text = "Last Name :";
            // 
            // frmAddEncounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(876, 477);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEncounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Encounter Details";
            this.Load += new System.EventHandler(this.frmAddEncounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtAddMedication;
        public System.Windows.Forms.TextBox txtAddPhysician;
        private System.Windows.Forms.Label lblAddMedication;
        private System.Windows.Forms.Label lblNoFieldEmpty_EncounterForm;
        private System.Windows.Forms.Label lblAddPhysician;
        public System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblVoterId;
        public System.Windows.Forms.TextBox txtAddPersonId;
        private System.Windows.Forms.Label lblAddPersonId;
        public System.Windows.Forms.TextBox txtVoterId;
        public System.Windows.Forms.TextBox txtBDate;
        private System.Windows.Forms.Label lblAddBirthDate;
        public System.Windows.Forms.DateTimePicker dtpAddBD;
        private System.Windows.Forms.Label lblFName;
        public System.Windows.Forms.TextBox txtLName;
        public System.Windows.Forms.ComboBox cboAddSex;
        private System.Windows.Forms.Label lblPersonSex;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}