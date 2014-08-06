namespace Haushaltsbuch
{
    partial class frmNewEntryDialoge
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtCreatedOn = new System.Windows.Forms.DateTimePicker();
            this.dtPaidOn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 41);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Betrag €";
            // 
            // nudValue
            // 
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Location = new System.Drawing.Point(104, 91);
            this.nudValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(187, 20);
            this.nudValue.TabIndex = 5;
            this.nudValue.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kommentar";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(15, 143);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(276, 100);
            this.tbComment.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID / Erfasst am";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(104, 12);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(50, 20);
            this.tbID.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(15, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 21);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(169, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 21);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Abbru&ch";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(104, 38);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(185, 21);
            this.cbCategory.TabIndex = 13;
            // 
            // dtCreatedOn
            // 
            this.dtCreatedOn.Enabled = false;
            this.dtCreatedOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedOn.Location = new System.Drawing.Point(169, 12);
            this.dtCreatedOn.Name = "dtCreatedOn";
            this.dtCreatedOn.Size = new System.Drawing.Size(122, 20);
            this.dtCreatedOn.TabIndex = 14;
            // 
            // dtPaidOn
            // 
            this.dtPaidOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaidOn.Location = new System.Drawing.Point(104, 65);
            this.dtPaidOn.Name = "dtPaidOn";
            this.dtPaidOn.Size = new System.Drawing.Size(187, 20);
            this.dtPaidOn.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bezahlt am";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(104, 117);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(187, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // frmNewEntryDialoge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 277);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPaidOn);
            this.Controls.Add(this.dtCreatedOn);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(318, 315);
            this.Name = "frmNewEntryDialoge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eintrag";
            this.Load += new System.EventHandler(this.frmNewEntryDialoge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox tbID;
        internal System.Windows.Forms.NumericUpDown nudValue;
        internal System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.DateTimePicker dtCreatedOn;
        internal System.Windows.Forms.DateTimePicker dtPaidOn;
    }
}

