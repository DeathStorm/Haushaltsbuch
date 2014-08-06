namespace Haushaltsbuch
{
    partial class frmMain
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
            this.dgBudgetEntries = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbiMinusAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbiBudget = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbiPlusAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbiBudgetLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbiSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudgetEntries)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBudgetEntries
            // 
            this.dgBudgetEntries.AllowUserToDeleteRows = false;
            this.dgBudgetEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBudgetEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudgetEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCreatedOn,
            this.colCategory,
            this.colPaidOn,
            this.colValue,
            this.colComment});
            this.dgBudgetEntries.Location = new System.Drawing.Point(12, 56);
            this.dgBudgetEntries.MultiSelect = false;
            this.dgBudgetEntries.Name = "dgBudgetEntries";
            this.dgBudgetEntries.ReadOnly = true;
            this.dgBudgetEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBudgetEntries.Size = new System.Drawing.Size(600, 300);
            this.dgBudgetEntries.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbiMinusAmount,
            this.sbiPlusAmount,
            this.sbiSpacer,
            this.sbiBudgetLabel,
            this.sbiBudget});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(626, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileQuit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(46, 20);
            this.miFile.Text = "&Datei";
            this.miFile.Click += new System.EventHandler(this.dateiToolStripMenuItem_Click);
            // 
            // miFileQuit
            // 
            this.miFileQuit.Name = "miFileQuit";
            this.miFileQuit.Size = new System.Drawing.Size(100, 22);
            this.miFileQuit.Text = "&Ende";
            this.miFileQuit.Click += new System.EventHandler(this.miFileQuit_Click);
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "&Hilfe";
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(12, 27);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(100, 23);
            this.btnNewEntry.TabIndex = 3;
            this.btnNewEntry.Text = "Neuer Eintrag";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // colID
            // 
            this.colID.FillWeight = 35.44304F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 35;
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.HeaderText = "Erfasst am";
            this.colCreatedOn.Name = "colCreatedOn";
            this.colCreatedOn.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 122.3554F;
            this.colCategory.HeaderText = "Kategorie";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 125;
            // 
            // colPaidOn
            // 
            this.colPaidOn.HeaderText = "Bezahlt am";
            this.colPaidOn.Name = "colPaidOn";
            this.colPaidOn.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.FillWeight = 121.4419F;
            this.colValue.HeaderText = "Betrag €";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 70;
            // 
            // colComment
            // 
            this.colComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colComment.FillWeight = 120.7596F;
            this.colComment.HeaderText = "Kommentar";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // sbiMinusAmount
            // 
            this.sbiMinusAmount.BackColor = System.Drawing.Color.LightCoral;
            this.sbiMinusAmount.Name = "sbiMinusAmount";
            this.sbiMinusAmount.Size = new System.Drawing.Size(45, 17);
            this.sbiMinusAmount.Text = "- 0,00 €";
            // 
            // sbiBudget
            // 
            this.sbiBudget.BackColor = System.Drawing.SystemColors.Control;
            this.sbiBudget.Name = "sbiBudget";
            this.sbiBudget.Size = new System.Drawing.Size(37, 17);
            this.sbiBudget.Text = "0,00 €";
            // 
            // sbiPlusAmount
            // 
            this.sbiPlusAmount.BackColor = System.Drawing.Color.LightGreen;
            this.sbiPlusAmount.Name = "sbiPlusAmount";
            this.sbiPlusAmount.Size = new System.Drawing.Size(48, 17);
            this.sbiPlusAmount.Text = "+ 0,00 €";
            // 
            // sbiBudgetLabel
            // 
            this.sbiBudgetLabel.Name = "sbiBudgetLabel";
            this.sbiBudgetLabel.Size = new System.Drawing.Size(59, 17);
            this.sbiBudgetLabel.Text = "Budget = ";
            // 
            // sbiSpacer
            // 
            this.sbiSpacer.Name = "sbiSpacer";
            this.sbiSpacer.Size = new System.Drawing.Size(19, 17);
            this.sbiSpacer.Text = "    ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(118, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Neue Kategorie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dgBudgetEntries);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(642, 426);
            this.Name = "frmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgBudgetEntries)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBudgetEntries;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileQuit;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.ToolStripStatusLabel sbiMinusAmount;
        private System.Windows.Forms.ToolStripStatusLabel sbiPlusAmount;
        private System.Windows.Forms.ToolStripStatusLabel sbiBudget;
        private System.Windows.Forms.ToolStripStatusLabel sbiSpacer;
        private System.Windows.Forms.ToolStripStatusLabel sbiBudgetLabel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
    }
}