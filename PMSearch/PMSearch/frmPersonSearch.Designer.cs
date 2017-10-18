namespace PM_Search_UI
{
    partial class frmPersonSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonSearch));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNoPersonFound = new System.Windows.Forms.Label();
            this.grdPerson = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNoEncounterFound = new System.Windows.Forms.Label();
            this.grdEncounter = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEncounterID = new System.Windows.Forms.TextBox();
            this.txtVoterID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEncounterID = new System.Windows.Forms.Label();
            this.lblVoterID = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.mnuMainForm = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddEncounter = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.patientDetailsDataSet = new PM_Search_UI.PatientDetailsDataSet();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new PM_Search_UI.PatientDetailsDataSetTableAdapters.PersonTableAdapter();
            this.encounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encounterTableAdapter = new PM_Search_UI.PatientDetailsDataSetTableAdapters.EncounterTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncounter)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encounterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(326, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 525);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblNoPersonFound);
            this.panel3.Controls.Add(this.grdPerson);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 255);
            this.panel3.TabIndex = 0;
            // 
            // lblNoPersonFound
            // 
            this.lblNoPersonFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoPersonFound.AutoSize = true;
            this.lblNoPersonFound.BackColor = System.Drawing.Color.White;
            this.lblNoPersonFound.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPersonFound.Location = new System.Drawing.Point(3, 12);
            this.lblNoPersonFound.Name = "lblNoPersonFound";
            this.lblNoPersonFound.Size = new System.Drawing.Size(145, 22);
            this.lblNoPersonFound.TabIndex = 22;
            this.lblNoPersonFound.Text = "No persons found.";
            // 
            // grdPerson
            // 
            this.grdPerson.AllowUserToAddRows = false;
            this.grdPerson.AllowUserToOrderColumns = true;
            this.grdPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdPerson.BackgroundColor = System.Drawing.Color.White;
            this.grdPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPerson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerson.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdPerson.Location = new System.Drawing.Point(0, 0);
            this.grdPerson.Name = "grdPerson";
            this.grdPerson.ReadOnly = true;
            this.grdPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPerson.RowHeadersVisible = false;
            this.grdPerson.RowTemplate.Height = 28;
            this.grdPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPerson.ShowEditingIcon = false;
            this.grdPerson.Size = new System.Drawing.Size(686, 251);
            this.grdPerson.TabIndex = 14;
            this.grdPerson.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grdPerson_RowStateChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblNoEncounterFound);
            this.panel4.Controls.Add(this.grdEncounter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(690, 255);
            this.panel4.TabIndex = 1;
            // 
            // lblNoEncounterFound
            // 
            this.lblNoEncounterFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoEncounterFound.AutoSize = true;
            this.lblNoEncounterFound.BackColor = System.Drawing.Color.White;
            this.lblNoEncounterFound.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEncounterFound.Location = new System.Drawing.Point(3, 10);
            this.lblNoEncounterFound.Name = "lblNoEncounterFound";
            this.lblNoEncounterFound.Size = new System.Drawing.Size(170, 22);
            this.lblNoEncounterFound.TabIndex = 29;
            this.lblNoEncounterFound.Text = "No encounters found.";
            // 
            // grdEncounter
            // 
            this.grdEncounter.AllowUserToAddRows = false;
            this.grdEncounter.AllowUserToOrderColumns = true;
            this.grdEncounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdEncounter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEncounter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdEncounter.BackgroundColor = System.Drawing.Color.White;
            this.grdEncounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdEncounter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdEncounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEncounter.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdEncounter.Location = new System.Drawing.Point(0, 0);
            this.grdEncounter.Name = "grdEncounter";
            this.grdEncounter.ReadOnly = true;
            this.grdEncounter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdEncounter.RowHeadersVisible = false;
            this.grdEncounter.RowTemplate.Height = 28;
            this.grdEncounter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEncounter.ShowEditingIcon = false;
            this.grdEncounter.Size = new System.Drawing.Size(686, 251);
            this.grdEncounter.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 525);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.cboSex);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.txtEncounterID);
            this.panel2.Controls.Add(this.txtVoterID);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.lblEncounterID);
            this.panel2.Controls.Add(this.lblVoterID);
            this.panel2.Controls.Add(this.lblDOB);
            this.panel2.Controls.Add(this.lblSex);
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 517);
            this.panel2.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.Location = new System.Drawing.Point(21, 253);
            this.txtDate.MaxLength = 10;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(226, 26);
            this.txtDate.TabIndex = 4;
            // 
            // cboSex
            // 
            this.cboSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboSex.Location = new System.Drawing.Point(21, 179);
            this.cboSex.MaxLength = 10;
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(260, 28);
            this.cboSex.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(187, 451);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 37);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(21, 451);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 37);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDOB.CustomFormat = "";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(253, 253);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(28, 26);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // txtEncounterID
            // 
            this.txtEncounterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEncounterID.Location = new System.Drawing.Point(21, 384);
            this.txtEncounterID.MaxLength = 9;
            this.txtEncounterID.Name = "txtEncounterID";
            this.txtEncounterID.Size = new System.Drawing.Size(260, 26);
            this.txtEncounterID.TabIndex = 6;
            // 
            // txtVoterID
            // 
            this.txtVoterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterID.Location = new System.Drawing.Point(21, 316);
            this.txtVoterID.MaxLength = 6;
            this.txtVoterID.Name = "txtVoterID";
            this.txtVoterID.Size = new System.Drawing.Size(260, 26);
            this.txtVoterID.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(21, 106);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(260, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(21, 35);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(260, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblEncounterID
            // 
            this.lblEncounterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEncounterID.AutoSize = true;
            this.lblEncounterID.Location = new System.Drawing.Point(17, 361);
            this.lblEncounterID.Name = "lblEncounterID";
            this.lblEncounterID.Size = new System.Drawing.Size(112, 20);
            this.lblEncounterID.TabIndex = 10;
            this.lblEncounterID.Text = "Encounter ID :";
            // 
            // lblVoterID
            // 
            this.lblVoterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoterID.AutoSize = true;
            this.lblVoterID.Location = new System.Drawing.Point(17, 293);
            this.lblVoterID.Name = "lblVoterID";
            this.lblVoterID.Size = new System.Drawing.Size(77, 20);
            this.lblVoterID.TabIndex = 9;
            this.lblVoterID.Text = "Voter ID :";
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(17, 221);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(81, 20);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "Birth Date";
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(17, 156);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(44, 20);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex :";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 83);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name :";
            // 
            // mnuMainForm
            // 
            this.mnuMainForm.BackColor = System.Drawing.Color.PaleGreen;
            this.mnuMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMainForm.Location = new System.Drawing.Point(0, 0);
            this.mnuMainForm.Name = "mnuMainForm";
            this.mnuMainForm.Size = new System.Drawing.Size(1036, 24);
            this.mnuMainForm.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAddEncounter);
            this.panel1.Controls.Add(this.btnAddPerson);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(12, 571);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 63);
            this.panel1.TabIndex = 4;
            // 
            // btnAddEncounter
            // 
            this.btnAddEncounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEncounter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEncounter.Enabled = false;
            this.btnAddEncounter.Location = new System.Drawing.Point(869, 13);
            this.btnAddEncounter.Name = "btnAddEncounter";
            this.btnAddEncounter.Size = new System.Drawing.Size(131, 37);
            this.btnAddEncounter.TabIndex = 13;
            this.btnAddEncounter.Text = "Add Encounter";
            this.btnAddEncounter.UseVisualStyleBackColor = false;
            this.btnAddEncounter.Click += new System.EventHandler(this.btnAddEncounter_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPerson.Enabled = false;
            this.btnAddPerson.Location = new System.Drawing.Point(707, 13);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(135, 37);
            this.btnAddPerson.TabIndex = 12;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(578, 13);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 37);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(450, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(317, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 37);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // patientDetailsDataSet
            // 
            this.patientDetailsDataSet.DataSetName = "PatientDetailsDataSet";
            this.patientDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.patientDetailsDataSet;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // encounterBindingSource
            // 
            this.encounterBindingSource.DataMember = "Encounter";
            this.encounterBindingSource.DataSource = this.patientDetailsDataSet;
            // 
            // encounterTableAdapter
            // 
            this.encounterTableAdapter.ClearBeforeFill = true;
            // 
            // frmPersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1036, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mnuMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainForm;
            this.Name = "frmPersonSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonSearch_FormClosing);
            this.Load += new System.EventHandler(this.PersonSearchFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncounter)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encounterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip mnuMainForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblVoterID;
        private System.Windows.Forms.Label lblEncounterID;
        private System.Windows.Forms.TextBox txtEncounterID;
        private System.Windows.Forms.TextBox txtVoterID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cboSex;
        private PM_Search_UI.PatientDetailsDataSet patientDetailsDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private PM_Search_UI.PatientDetailsDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource encounterBindingSource;
        private PM_Search_UI.PatientDetailsDataSetTableAdapters.EncounterTableAdapter encounterTableAdapter;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAddEncounter;
        private System.Windows.Forms.DataGridView grdPerson;
        public System.Windows.Forms.DataGridView grdEncounter;
        private System.Windows.Forms.Label lblNoPersonFound;
        private System.Windows.Forms.Label lblNoEncounterFound;
    }
}