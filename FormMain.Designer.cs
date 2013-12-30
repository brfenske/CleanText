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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblRemoveAllLinesWithoutText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblSortTrimWhiteSpace = new System.Windows.Forms.Label();
            this.lblRemoveDupesAndSort = new System.Windows.Forms.Label();
            this.lblRemoveDupesAndSortAndTrimWhiteSpace = new System.Windows.Forms.Label();
            this.lblDupeColumn = new System.Windows.Forms.Label();
            this.lblRemoveAllLinesContainingText = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIntro.Location = new System.Drawing.Point(21, 27);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(226, 145);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "CleanText is running. Click here to dismiss.";
            this.lblIntro.Click += new System.EventHandler(this.lblIntro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOptions);
            this.panel1.Controls.Add(this.lblRemoveAllLinesWithoutText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblAbout);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblSortTrimWhiteSpace);
            this.panel1.Controls.Add(this.lblRemoveDupesAndSort);
            this.panel1.Controls.Add(this.lblRemoveDupesAndSortAndTrimWhiteSpace);
            this.panel1.Controls.Add(this.lblDupeColumn);
            this.panel1.Controls.Add(this.lblRemoveAllLinesContainingText);
            this.panel1.Controls.Add(this.lblSort);
            this.panel1.Location = new System.Drawing.Point(25, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 329);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOptions.Location = new System.Drawing.Point(-4, 232);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(80, 21);
            this.lblOptions.TabIndex = 11;
            this.lblOptions.Text = "Options...";
            this.lblOptions.Click += new System.EventHandler(this.lblOptions_Click);
            // 
            // lblRemoveAllLinesWithoutText
            // 
            this.lblRemoveAllLinesWithoutText.AutoSize = true;
            this.lblRemoveAllLinesWithoutText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAllLinesWithoutText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoveAllLinesWithoutText.Location = new System.Drawing.Point(-4, 174);
            this.lblRemoveAllLinesWithoutText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveAllLinesWithoutText.Name = "lblRemoveAllLinesWithoutText";
            this.lblRemoveAllLinesWithoutText.Size = new System.Drawing.Size(245, 21);
            this.lblRemoveAllLinesWithoutText.TabIndex = 10;
            this.lblRemoveAllLinesWithoutText.Text = "Remove All Lines Without Text...";
            this.lblRemoveAllLinesWithoutText.Click += new System.EventHandler(this.Action_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-4, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbout.Location = new System.Drawing.Point(-4, 261);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(132, 21);
            this.lblAbout.TabIndex = 8;
            this.lblAbout.Text = "About CleanText";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.Location = new System.Drawing.Point(-4, 290);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 21);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblSortTrimWhiteSpace
            // 
            this.lblSortTrimWhiteSpace.AutoSize = true;
            this.lblSortTrimWhiteSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTrimWhiteSpace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSortTrimWhiteSpace.Location = new System.Drawing.Point(-4, 29);
            this.lblSortTrimWhiteSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSortTrimWhiteSpace.Name = "lblSortTrimWhiteSpace";
            this.lblSortTrimWhiteSpace.Size = new System.Drawing.Size(175, 21);
            this.lblSortTrimWhiteSpace.TabIndex = 6;
            this.lblSortTrimWhiteSpace.Text = "Sort (trim white space)";
            this.lblSortTrimWhiteSpace.Click += new System.EventHandler(this.Action_Click);
            // 
            // lblRemoveDupesAndSort
            // 
            this.lblRemoveDupesAndSort.AutoSize = true;
            this.lblRemoveDupesAndSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveDupesAndSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoveDupesAndSort.Location = new System.Drawing.Point(-4, 58);
            this.lblRemoveDupesAndSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveDupesAndSort.Name = "lblRemoveDupesAndSort";
            this.lblRemoveDupesAndSort.Size = new System.Drawing.Size(186, 21);
            this.lblRemoveDupesAndSort.TabIndex = 5;
            this.lblRemoveDupesAndSort.Text = "Remove Dupes and Sort";
            this.lblRemoveDupesAndSort.Click += new System.EventHandler(this.Action_Click);
            // 
            // lblRemoveDupesAndSortAndTrimWhiteSpace
            // 
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.AutoSize = true;
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Location = new System.Drawing.Point(-4, 87);
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Name = "lblRemoveDupesAndSortAndTrimWhiteSpace";
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Size = new System.Drawing.Size(320, 21);
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.TabIndex = 4;
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Text = "Remove Dupes and Sort (trim white space)";
            this.lblRemoveDupesAndSortAndTrimWhiteSpace.Click += new System.EventHandler(this.Action_Click);
            // 
            // lblDupeColumn
            // 
            this.lblDupeColumn.AutoSize = true;
            this.lblDupeColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDupeColumn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDupeColumn.Location = new System.Drawing.Point(-4, 116);
            this.lblDupeColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDupeColumn.Name = "lblDupeColumn";
            this.lblDupeColumn.Size = new System.Drawing.Size(109, 21);
            this.lblDupeColumn.TabIndex = 3;
            this.lblDupeColumn.Text = "Dupe Column";
            this.lblDupeColumn.Click += new System.EventHandler(this.Action_Click);
            // 
            // lblRemoveAllLinesContainingText
            // 
            this.lblRemoveAllLinesContainingText.AutoSize = true;
            this.lblRemoveAllLinesContainingText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAllLinesContainingText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoveAllLinesContainingText.Location = new System.Drawing.Point(-4, 145);
            this.lblRemoveAllLinesContainingText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveAllLinesContainingText.Name = "lblRemoveAllLinesContainingText";
            this.lblRemoveAllLinesContainingText.Size = new System.Drawing.Size(265, 21);
            this.lblRemoveAllLinesContainingText.TabIndex = 2;
            this.lblRemoveAllLinesContainingText.Text = "Remove All Lines Containing Text...";
            this.lblRemoveAllLinesContainingText.Click += new System.EventHandler(this.Action_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSort.Location = new System.Drawing.Point(-4, 0);
            this.lblSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(41, 21);
            this.lblSort.TabIndex = 1;
            this.lblSort.Text = "&Sort";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(391, 368);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIntro);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblSortTrimWhiteSpace;
        private System.Windows.Forms.Label lblRemoveDupesAndSort;
        private System.Windows.Forms.Label lblRemoveDupesAndSortAndTrimWhiteSpace;
        private System.Windows.Forms.Label lblDupeColumn;
        private System.Windows.Forms.Label lblRemoveAllLinesContainingText;
        private System.Windows.Forms.Label lblRemoveAllLinesWithoutText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblOptions;
    }
}