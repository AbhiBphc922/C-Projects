namespace Voice_PM_Search
{
    partial class frmEnterName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterName));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblInvalidInput = new System.Windows.Forms.Label();
            this.mnuNewName = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNewName = new System.Windows.Forms.Panel();
            this.mnuNewName.SuspendLayout();
            this.pnlNewName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.HideSelection = false;
            this.txtName.Location = new System.Drawing.Point(110, 99);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtName.Size = new System.Drawing.Size(268, 33);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "";
            this.txtName.TextChanged += new System.EventHandler(this.NameTextBoxChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(289, 157);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(89, 38);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSave, " Save(Ctrl+S)");
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.CmdSaveClick);
            // 
            // cmdClear
            // 
            this.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClear.Image = ((System.Drawing.Image)(resources.GetObject("cmdClear.Image")));
            this.cmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClear.Location = new System.Drawing.Point(110, 157);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(82, 38);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdClear, " Clear(Ctrl+C)");
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.CmdClearClick);
            // 
            // lblInvalidInput
            // 
            this.lblInvalidInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidInput.AutoSize = true;
            this.lblInvalidInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidInput.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidInput.Location = new System.Drawing.Point(107, 70);
            this.lblInvalidInput.Name = "lblInvalidInput";
            this.lblInvalidInput.Size = new System.Drawing.Size(123, 17);
            this.lblInvalidInput.TabIndex = 4;
            this.lblInvalidInput.Text = " * Enter valid input";
            this.lblInvalidInput.Visible = false;
            // 
            // mnuNewName
            // 
            this.mnuNewName.BackColor = System.Drawing.Color.White;
            this.mnuNewName.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuNewName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuNewName.Location = new System.Drawing.Point(0, 0);
            this.mnuNewName.Name = "mnuNewName";
            this.mnuNewName.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuNewName.ShowItemToolTips = true;
            this.mnuNewName.Size = new System.Drawing.Size(478, 33);
            this.mnuNewName.TabIndex = 5;
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.ToolTipText = "Back(Esc)";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItemClick);
            // 
            // pnlNewName
            // 
            this.pnlNewName.AutoScroll = true;
            this.pnlNewName.AutoSize = true;
            this.pnlNewName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlNewName.Controls.Add(this.lblName);
            this.pnlNewName.Controls.Add(this.cmdSave);
            this.pnlNewName.Controls.Add(this.cmdClear);
            this.pnlNewName.Controls.Add(this.lblInvalidInput);
            this.pnlNewName.Controls.Add(this.txtName);
            this.pnlNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewName.Location = new System.Drawing.Point(0, 33);
            this.pnlNewName.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNewName.Name = "pnlNewName";
            this.pnlNewName.Size = new System.Drawing.Size(478, 239);
            this.pnlNewName.TabIndex = 6;
            // 
            // frmEnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 272);
            this.Controls.Add(this.pnlNewName);
            this.Controls.Add(this.mnuNewName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuNewName;
            this.Name = "frmEnterName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Enter Name";
            this.Load += new System.EventHandler(this.frmEnterNameLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEnterNameKeyDown);
            this.mnuNewName.ResumeLayout(false);
            this.mnuNewName.PerformLayout();
            this.pnlNewName.ResumeLayout(false);
            this.pnlNewName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label lblInvalidInput;
        private System.Windows.Forms.MenuStrip mnuNewName;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlNewName;
    }
}