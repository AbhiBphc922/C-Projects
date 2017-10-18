namespace PM_Search_UI
{
    partial class frmAddPersonAndEncounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPersonAndEncounter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddMedicationNames = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddPhysicianName = new System.Windows.Forms.TextBox();
            this.lblAddMedication = new System.Windows.Forms.Label();
            this.lblNoFieldEmpty_PersonEncounterForm = new System.Windows.Forms.Label();
            this.lblAddPhysician = new System.Windows.Forms.Label();
            this.txtAddFName = new System.Windows.Forms.TextBox();
            this.lblAddVoterId = new System.Windows.Forms.Label();
            this.txtAddVoterID = new System.Windows.Forms.TextBox();
            this.txtAddBDate = new System.Windows.Forms.TextBox();
            this.lblAddBirthDate = new System.Windows.Forms.Label();
            this.dtpAddBD = new System.Windows.Forms.DateTimePicker();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.txtAddLName = new System.Windows.Forms.TextBox();
            this.cboAddsex = new System.Windows.Forms.ComboBox();
            this.lblAddSex = new System.Windows.Forms.Label();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtAddMedicationNames);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtAddPhysicianName);
            this.panel1.Controls.Add(this.lblAddMedication);
            this.panel1.Controls.Add(this.lblNoFieldEmpty_PersonEncounterForm);
            this.panel1.Controls.Add(this.lblAddPhysician);
            this.panel1.Controls.Add(this.txtAddFName);
            this.panel1.Controls.Add(this.lblAddVoterId);
            this.panel1.Controls.Add(this.txtAddVoterID);
            this.panel1.Controls.Add(this.txtAddBDate);
            this.panel1.Controls.Add(this.lblAddBirthDate);
            this.panel1.Controls.Add(this.dtpAddBD);
            this.panel1.Controls.Add(this.lblAddFirstName);
            this.panel1.Controls.Add(this.txtAddLName);
            this.panel1.Controls.Add(this.cboAddsex);
            this.panel1.Controls.Add(this.lblAddSex);
            this.panel1.Controls.Add(this.lblAddLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 446);
            this.panel1.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(715, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddMedicationNames
            // 
            this.txtAddMedicationNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddMedicationNames.Location = new System.Drawing.Point(148, 319);
            this.txtAddMedicationNames.MaxLength = 100;
            this.txtAddMedicationNames.Name = "txtAddMedicationNames";
            this.txtAddMedicationNames.Size = new System.Drawing.Size(235, 26);
            this.txtAddMedicationNames.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(569, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddPhysicianName
            // 
            this.txtAddPhysicianName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddPhysicianName.Location = new System.Drawing.Point(569, 234);
            this.txtAddPhysicianName.MaxLength = 50;
            this.txtAddPhysicianName.Name = "txtAddPhysicianName";
            this.txtAddPhysicianName.Size = new System.Drawing.Size(235, 26);
            this.txtAddPhysicianName.TabIndex = 6;
            // 
            // lblAddMedication
            // 
            this.lblAddMedication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddMedication.AutoSize = true;
            this.lblAddMedication.Location = new System.Drawing.Point(20, 322);
            this.lblAddMedication.Name = "lblAddMedication";
            this.lblAddMedication.Size = new System.Drawing.Size(94, 20);
            this.lblAddMedication.TabIndex = 5;
            this.lblAddMedication.Text = "Medication :";
            // 
            // lblNoFieldEmpty_PersonEncounterForm
            // 
            this.lblNoFieldEmpty_PersonEncounterForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoFieldEmpty_PersonEncounterForm.AutoSize = true;
            this.lblNoFieldEmpty_PersonEncounterForm.ForeColor = System.Drawing.Color.Red;
            this.lblNoFieldEmpty_PersonEncounterForm.Location = new System.Drawing.Point(320, 10);
            this.lblNoFieldEmpty_PersonEncounterForm.Name = "lblNoFieldEmpty_PersonEncounterForm";
            this.lblNoFieldEmpty_PersonEncounterForm.Size = new System.Drawing.Size(173, 20);
            this.lblNoFieldEmpty_PersonEncounterForm.TabIndex = 26;
            this.lblNoFieldEmpty_PersonEncounterForm.Text = "Fields cannot be empty";
            // 
            // lblAddPhysician
            // 
            this.lblAddPhysician.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddPhysician.AutoSize = true;
            this.lblAddPhysician.Location = new System.Drawing.Point(445, 237);
            this.lblAddPhysician.Name = "lblAddPhysician";
            this.lblAddPhysician.Size = new System.Drawing.Size(83, 20);
            this.lblAddPhysician.TabIndex = 6;
            this.lblAddPhysician.Text = "Physician :";
            // 
            // txtAddFName
            // 
            this.txtAddFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddFName.Location = new System.Drawing.Point(148, 67);
            this.txtAddFName.MaxLength = 50;
            this.txtAddFName.Name = "txtAddFName";
            this.txtAddFName.Size = new System.Drawing.Size(235, 26);
            this.txtAddFName.TabIndex = 1;
            // 
            // lblAddVoterId
            // 
            this.lblAddVoterId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddVoterId.AutoSize = true;
            this.lblAddVoterId.Location = new System.Drawing.Point(20, 240);
            this.lblAddVoterId.Name = "lblAddVoterId";
            this.lblAddVoterId.Size = new System.Drawing.Size(73, 20);
            this.lblAddVoterId.TabIndex = 2;
            this.lblAddVoterId.Text = "VoterID :";
            // 
            // txtAddVoterID
            // 
            this.txtAddVoterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddVoterID.Location = new System.Drawing.Point(148, 237);
            this.txtAddVoterID.MaxLength = 6;
            this.txtAddVoterID.Name = "txtAddVoterID";
            this.txtAddVoterID.Size = new System.Drawing.Size(235, 26);
            this.txtAddVoterID.TabIndex = 5;
            // 
            // txtAddBDate
            // 
            this.txtAddBDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddBDate.Location = new System.Drawing.Point(569, 157);
            this.txtAddBDate.MaxLength = 10;
            this.txtAddBDate.Name = "txtAddBDate";
            this.txtAddBDate.ReadOnly = true;
            this.txtAddBDate.Size = new System.Drawing.Size(201, 26);
            this.txtAddBDate.TabIndex = 4;
            // 
            // lblAddBirthDate
            // 
            this.lblAddBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddBirthDate.AutoSize = true;
            this.lblAddBirthDate.Location = new System.Drawing.Point(445, 160);
            this.lblAddBirthDate.Name = "lblAddBirthDate";
            this.lblAddBirthDate.Size = new System.Drawing.Size(85, 20);
            this.lblAddBirthDate.TabIndex = 3;
            this.lblAddBirthDate.Text = "BirthDate :";
            // 
            // dtpAddBD
            // 
            this.dtpAddBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAddBD.CustomFormat = "";
            this.dtpAddBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddBD.Location = new System.Drawing.Point(776, 154);
            this.dtpAddBD.Name = "dtpAddBD";
            this.dtpAddBD.Size = new System.Drawing.Size(28, 26);
            this.dtpAddBD.TabIndex = 4;
            this.dtpAddBD.ValueChanged += new System.EventHandler(this.dtpAddDOB_ValueChanged);
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(20, 70);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblAddFirstName.TabIndex = 6;
            this.lblAddFirstName.Text = "First Name :";
            // 
            // txtAddLName
            // 
            this.txtAddLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddLName.Location = new System.Drawing.Point(569, 64);
            this.txtAddLName.MaxLength = 50;
            this.txtAddLName.Name = "txtAddLName";
            this.txtAddLName.Size = new System.Drawing.Size(235, 26);
            this.txtAddLName.TabIndex = 2;
            // 
            // cboAddsex
            // 
            this.cboAddsex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAddsex.FormattingEnabled = true;
            this.cboAddsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboAddsex.Location = new System.Drawing.Point(148, 157);
            this.cboAddsex.MaxLength = 10;
            this.cboAddsex.Name = "cboAddsex";
            this.cboAddsex.Size = new System.Drawing.Size(235, 28);
            this.cboAddsex.TabIndex = 3;
            // 
            // lblAddSex
            // 
            this.lblAddSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddSex.AutoSize = true;
            this.lblAddSex.Location = new System.Drawing.Point(20, 160);
            this.lblAddSex.Name = "lblAddSex";
            this.lblAddSex.Size = new System.Drawing.Size(44, 20);
            this.lblAddSex.TabIndex = 4;
            this.lblAddSex.Text = "Sex :";
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Location = new System.Drawing.Point(445, 67);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(94, 20);
            this.lblAddLastName.TabIndex = 5;
            this.lblAddLastName.Text = "Last Name :";
            // 
            // frmAddPersonAndEncounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(880, 446);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPersonAndEncounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Person and Encounter Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtAddFName;
        private System.Windows.Forms.Label lblAddVoterId;
        public System.Windows.Forms.TextBox txtAddVoterID;
        public System.Windows.Forms.TextBox txtAddBDate;
        private System.Windows.Forms.Label lblAddBirthDate;
        public System.Windows.Forms.DateTimePicker dtpAddBD;
        private System.Windows.Forms.Label lblAddFirstName;
        public System.Windows.Forms.TextBox txtAddLName;
        public System.Windows.Forms.ComboBox cboAddsex;
        private System.Windows.Forms.Label lblAddSex;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.Label lblNoFieldEmpty_PersonEncounterForm;
        public System.Windows.Forms.TextBox txtAddPhysicianName;
        private System.Windows.Forms.Label lblAddPhysician;
        public System.Windows.Forms.TextBox txtAddMedicationNames;
        private System.Windows.Forms.Label lblAddMedication;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}