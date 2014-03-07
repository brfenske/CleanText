namespace CleanText
{
    partial class FormMain
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
            if (disposing && (trayComponents != null))
            {
                trayComponents.Dispose();
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblKeyCombo = new System.Windows.Forms.Label();
            this.lblIntro2 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnRemoveAllLinesWithoutText = new System.Windows.Forms.Button();
            this.btnRemoveAllLinesContainingText = new System.Windows.Forms.Button();
            this.btnDupeColumn = new System.Windows.Forms.Button();
            this.btnRemoveDupesAndSortAndTrimWhiteSpace = new System.Windows.Forms.Button();
            this.btnRemoveDupesAndSort = new System.Windows.Forms.Button();
            this.btnSortTrimWhiteSpace = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIntro.Location = new System.Drawing.Point(21, 27);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(241, 25);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "CleanText is running. Press";
            this.lblIntro.Click += new System.EventHandler(this.lblIntro_Click);
            // 
            // lblKeyCombo
            // 
            this.lblKeyCombo.AutoSize = true;
            this.lblKeyCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKeyCombo.Location = new System.Drawing.Point(21, 52);
            this.lblKeyCombo.Name = "lblKeyCombo";
            this.lblKeyCombo.Size = new System.Drawing.Size(118, 25);
            this.lblKeyCombo.TabIndex = 3;
            this.lblKeyCombo.Text = "(key combo)";
            this.lblKeyCombo.Click += new System.EventHandler(this.lblIntro_Click);
            // 
            // lblIntro2
            // 
            this.lblIntro2.AutoSize = true;
            this.lblIntro2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIntro2.Location = new System.Drawing.Point(21, 77);
            this.lblIntro2.Name = "lblIntro2";
            this.lblIntro2.Size = new System.Drawing.Size(275, 25);
            this.lblIntro2.TabIndex = 4;
            this.lblIntro2.Text = "to access.  Press Esc to dismiss.";
            this.lblIntro2.Click += new System.EventHandler(this.lblIntro_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(228, 463);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(96, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "CleanText © 2013";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.label1);
            this.pnlButtons.Controls.Add(this.lblCopyright);
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnAbout);
            this.pnlButtons.Controls.Add(this.btnOptions);
            this.pnlButtons.Controls.Add(this.btnRemoveAllLinesWithoutText);
            this.pnlButtons.Controls.Add(this.btnRemoveAllLinesContainingText);
            this.pnlButtons.Controls.Add(this.btnDupeColumn);
            this.pnlButtons.Controls.Add(this.btnRemoveDupesAndSortAndTrimWhiteSpace);
            this.pnlButtons.Controls.Add(this.btnRemoveDupesAndSort);
            this.pnlButtons.Controls.Add(this.btnSortTrimWhiteSpace);
            this.pnlButtons.Controls.Add(this.btnSort);
            this.pnlButtons.Controls.Add(this.btnReplace);
            this.pnlButtons.Location = new System.Drawing.Point(12, 14);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(327, 486);
            this.pnlButtons.TabIndex = 6;
            this.pnlButtons.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(320, 32);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(3, 388);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(320, 32);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "A&bout CleanText";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(3, 348);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(320, 32);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "&Options...";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnRemoveAllLinesWithoutText
            // 
            this.btnRemoveAllLinesWithoutText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemoveAllLinesWithoutText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAllLinesWithoutText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllLinesWithoutText.Location = new System.Drawing.Point(3, 283);
            this.btnRemoveAllLinesWithoutText.Name = "btnRemoveAllLinesWithoutText";
            this.btnRemoveAllLinesWithoutText.Size = new System.Drawing.Size(320, 32);
            this.btnRemoveAllLinesWithoutText.TabIndex = 7;
            this.btnRemoveAllLinesWithoutText.Text = "Remove All &Lines Without Text...";
            this.btnRemoveAllLinesWithoutText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoveAllLinesWithoutText.UseVisualStyleBackColor = false;
            this.btnRemoveAllLinesWithoutText.Click += new System.EventHandler(this.Action_Click);
            this.btnRemoveAllLinesWithoutText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnRemoveAllLinesContainingText
            // 
            this.btnRemoveAllLinesContainingText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemoveAllLinesContainingText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAllLinesContainingText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllLinesContainingText.Location = new System.Drawing.Point(3, 243);
            this.btnRemoveAllLinesContainingText.Name = "btnRemoveAllLinesContainingText";
            this.btnRemoveAllLinesContainingText.Size = new System.Drawing.Size(320, 32);
            this.btnRemoveAllLinesContainingText.TabIndex = 6;
            this.btnRemoveAllLinesContainingText.Text = "Remove &All Lines Containing Text...";
            this.btnRemoveAllLinesContainingText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoveAllLinesContainingText.UseVisualStyleBackColor = false;
            this.btnRemoveAllLinesContainingText.Click += new System.EventHandler(this.Action_Click);
            this.btnRemoveAllLinesContainingText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnDupeColumn
            // 
            this.btnDupeColumn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDupeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDupeColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDupeColumn.Location = new System.Drawing.Point(3, 203);
            this.btnDupeColumn.Name = "btnDupeColumn";
            this.btnDupeColumn.Size = new System.Drawing.Size(320, 32);
            this.btnDupeColumn.TabIndex = 5;
            this.btnDupeColumn.Text = "Dupe &Column";
            this.btnDupeColumn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDupeColumn.UseVisualStyleBackColor = false;
            this.btnDupeColumn.Click += new System.EventHandler(this.Action_Click);
            this.btnDupeColumn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnRemoveDupesAndSortAndTrimWhiteSpace
            // 
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.Location = new System.Drawing.Point(3, 163);
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.Name = "btnRemoveDupesAndSortAndTrimWhiteSpace";
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.Size = new System.Drawing.Size(320, 32);
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.TabIndex = 4;
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.Text = "Remove Dupes and Sort (trim &white space)";
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.UseVisualStyleBackColor = false;
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.Click += new System.EventHandler(this.Action_Click);
            this.btnRemoveDupesAndSortAndTrimWhiteSpace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnRemoveDupesAndSort
            // 
            this.btnRemoveDupesAndSort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemoveDupesAndSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDupesAndSort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDupesAndSort.Location = new System.Drawing.Point(3, 123);
            this.btnRemoveDupesAndSort.Name = "btnRemoveDupesAndSort";
            this.btnRemoveDupesAndSort.Size = new System.Drawing.Size(320, 32);
            this.btnRemoveDupesAndSort.TabIndex = 3;
            this.btnRemoveDupesAndSort.Text = "Remove &Dupes and Sort";
            this.btnRemoveDupesAndSort.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoveDupesAndSort.UseVisualStyleBackColor = false;
            this.btnRemoveDupesAndSort.Click += new System.EventHandler(this.Action_Click);
            this.btnRemoveDupesAndSort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnSortTrimWhiteSpace
            // 
            this.btnSortTrimWhiteSpace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSortTrimWhiteSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortTrimWhiteSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortTrimWhiteSpace.Location = new System.Drawing.Point(3, 83);
            this.btnSortTrimWhiteSpace.Name = "btnSortTrimWhiteSpace";
            this.btnSortTrimWhiteSpace.Size = new System.Drawing.Size(320, 32);
            this.btnSortTrimWhiteSpace.TabIndex = 2;
            this.btnSortTrimWhiteSpace.Text = "Sort (&trim white space)";
            this.btnSortTrimWhiteSpace.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSortTrimWhiteSpace.UseVisualStyleBackColor = false;
            this.btnSortTrimWhiteSpace.Click += new System.EventHandler(this.Action_Click);
            this.btnSortTrimWhiteSpace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(3, 43);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(320, 32);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "&Sort";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.Action_Click);
            this.btnSort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(3, 3);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(320, 32);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "&Replace...";
            this.btnReplace.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.Action_Click);
            this.btnReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(352, 504);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblKeyCombo);
            this.Controls.Add(this.lblIntro2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblKeyCombo;
        private System.Windows.Forms.Label lblIntro2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnRemoveAllLinesWithoutText;
        private System.Windows.Forms.Button btnRemoveAllLinesContainingText;
        private System.Windows.Forms.Button btnDupeColumn;
        private System.Windows.Forms.Button btnRemoveDupesAndSortAndTrimWhiteSpace;
        private System.Windows.Forms.Button btnRemoveDupesAndSort;
        private System.Windows.Forms.Button btnSortTrimWhiteSpace;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReplace;
    }
}