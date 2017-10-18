using System.ComponentModel;

namespace Voice_PM_Search
{
    partial class frmVoiceSearch
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
            System.Windows.Forms.MenuStrip mnuVoiceSearch;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoiceSearch));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblVoiceSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dgdDisplayResult = new System.Windows.Forms.DataGridView();
            this.pnlVoiceSearch = new System.Windows.Forms.Panel();
            this.lblNoResult = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_DetailsDataSet = new Voice_PM_Search.Patient_DetailsDataSet();
            this.patientTableAdapter = new Voice_PM_Search.Patient_DetailsDataSetTableAdapters.PatientTableAdapter();
            mnuVoiceSearch = new System.Windows.Forms.MenuStrip();
            mnuVoiceSearch.SuspendLayout();
            this.tblVoiceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDisplayResult)).BeginInit();
            this.pnlVoiceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_DetailsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuVoiceSearch
            // 
            mnuVoiceSearch.BackColor = System.Drawing.Color.Transparent;
            mnuVoiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            mnuVoiceSearch.ImageScalingSize = new System.Drawing.Size(24, 24);
            mnuVoiceSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            mnuVoiceSearch.Location = new System.Drawing.Point(2, 2);
            mnuVoiceSearch.Name = "mnuVoiceSearch";
            mnuVoiceSearch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            mnuVoiceSearch.Size = new System.Drawing.Size(712, 33);
            mnuVoiceSearch.TabIndex = 13;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.ToolTipText = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // tblVoiceSearch
            // 
            this.tblVoiceSearch.AutoSize = true;
            this.tblVoiceSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tblVoiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblVoiceSearch.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblVoiceSearch.ColumnCount = 1;
            this.tblVoiceSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblVoiceSearch.Controls.Add(this.dgdDisplayResult, 0, 2);
            this.tblVoiceSearch.Controls.Add(mnuVoiceSearch, 0, 0);
            this.tblVoiceSearch.Controls.Add(this.pnlVoiceSearch, 0, 1);
            this.tblVoiceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblVoiceSearch.Location = new System.Drawing.Point(0, 0);
            this.tblVoiceSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tblVoiceSearch.Name = "tblVoiceSearch";
            this.tblVoiceSearch.RowCount = 3;
            this.tblVoiceSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblVoiceSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblVoiceSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblVoiceSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblVoiceSearch.Size = new System.Drawing.Size(716, 592);
            this.tblVoiceSearch.TabIndex = 0;
            // 
            // dgdDisplayResult
            // 
            this.dgdDisplayResult.AllowUserToAddRows = false;
            this.dgdDisplayResult.AllowUserToOrderColumns = true;
            this.dgdDisplayResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdDisplayResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdDisplayResult.BackgroundColor = System.Drawing.Color.White;
            this.dgdDisplayResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgdDisplayResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgdDisplayResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDisplayResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdDisplayResult.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgdDisplayResult.Location = new System.Drawing.Point(5, 345);
            this.dgdDisplayResult.Name = "dgdDisplayResult";
            this.dgdDisplayResult.ReadOnly = true;
            this.dgdDisplayResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdDisplayResult.RowHeadersVisible = false;
            this.dgdDisplayResult.RowTemplate.Height = 28;
            this.dgdDisplayResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgdDisplayResult.ShowEditingIcon = false;
            this.dgdDisplayResult.Size = new System.Drawing.Size(706, 242);
            this.dgdDisplayResult.TabIndex = 27;
            this.toolTip1.SetToolTip(this.dgdDisplayResult, "Search Result");
            // 
            // pnlVoiceSearch
            // 
            this.pnlVoiceSearch.AutoScroll = true;
            this.pnlVoiceSearch.BackColor = System.Drawing.Color.White;
            this.pnlVoiceSearch.BackgroundImage = Voice_PM_Search.VoiceSearchResources.chemical_pharmaceutical_industry_call_center_services;
            this.pnlVoiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVoiceSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVoiceSearch.Controls.Add(this.lblNoResult);
            this.pnlVoiceSearch.Controls.Add(this.cmdStart);
            this.pnlVoiceSearch.Controls.Add(this.lblName);
            this.pnlVoiceSearch.Controls.Add(this.cmdStop);
            this.pnlVoiceSearch.Controls.Add(this.txtNameSearch);
            this.pnlVoiceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVoiceSearch.Location = new System.Drawing.Point(2, 39);
            this.pnlVoiceSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVoiceSearch.Name = "pnlVoiceSearch";
            this.pnlVoiceSearch.Size = new System.Drawing.Size(712, 301);
            this.pnlVoiceSearch.TabIndex = 26;
            // 
            // lblNoResult
            // 
            this.lblNoResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNoResult.AutoSize = true;
            this.lblNoResult.BackColor = System.Drawing.Color.Transparent;
            this.lblNoResult.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResult.Location = new System.Drawing.Point(262, 253);
            this.lblNoResult.Name = "lblNoResult";
            this.lblNoResult.Size = new System.Drawing.Size(163, 21);
            this.lblNoResult.TabIndex = 15;
            this.lblNoResult.Text = "No Result Found";
            // 
            // cmdStart
            // 
            this.cmdStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStart.Location = new System.Drawing.Point(226, 177);
            this.cmdStart.MaximumSize = new System.Drawing.Size(104, 41);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(67, 41);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "&Start";
            this.cmdStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdStart, "Start Recording");
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Click += new System.EventHandler(this.CmdStartClick);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(133, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 21);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "NAME :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdStop
            // 
            this.cmdStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStop.Location = new System.Drawing.Point(429, 177);
            this.cmdStop.MaximumSize = new System.Drawing.Size(104, 41);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(67, 41);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "S&top";
            this.cmdStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdStop, "Stop Recording");
            this.cmdStop.UseVisualStyleBackColor = false;
            this.cmdStop.Click += new System.EventHandler(this.CmdStopClick);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameSearch.HideSelection = false;
            this.txtNameSearch.Location = new System.Drawing.Point(226, 127);
            this.txtNameSearch.MaxLength = 20;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(270, 26);
            this.txtNameSearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNameSearch, "Search Box");
            this.txtNameSearch.TextChanged += new System.EventHandler(this.NameSearchTextChange);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.patient_DetailsDataSet;
            // 
            // patient_DetailsDataSet
            // 
            this.patient_DetailsDataSet.DataSetName = "Patient_DetailsDataSet";
            this.patient_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // frmVoiceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 592);
            this.Controls.Add(this.tblVoiceSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = mnuVoiceSearch;
            this.Name = "frmVoiceSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice PM Search";
            this.Load += new System.EventHandler(this.frmVoiceSearchLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VoiceSearchKeyDown);
            mnuVoiceSearch.ResumeLayout(false);
            mnuVoiceSearch.PerformLayout();
            this.tblVoiceSearch.ResumeLayout(false);
            this.tblVoiceSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDisplayResult)).EndInit();
            this.pnlVoiceSearch.ResumeLayout(false);
            this.pnlVoiceSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_DetailsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblVoiceSearch;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlVoiceSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.DataGridView dgdDisplayResult;
        private Patient_DetailsDataSet patient_DetailsDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Patient_DetailsDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblNoResult;
    }
}