using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CleanText
{
    public partial class DialogOptions : Form
    {
        private string keyCode = string.Empty;

        public string KeyCombo = string.Empty;

        public DialogOptions()
        {
            InitializeComponent();
            Reset();
        }

        private void DialogOptions_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KeyCombo))
            {
                string[] keyParts = KeyCombo.Split('|');
                int modifiers = Convert.ToInt32(keyParts[0]);
                lblAlt.Visible = (modifiers | Constants.ALT) == modifiers;
                lblShift.Visible = (modifiers | Constants.SHIFT) == modifiers;
                lblControl.Visible = (modifiers | Constants.CTRL) == modifiers;
                this.keyCode = keyParts[1].ToString();
                lblKey.Text = GetKeyDisplayValue();
            }

            txtKeyCombo.Select(0, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int modifiers = 0;
            modifiers = lblAlt.Visible ? modifiers | Constants.ALT : modifiers;
            modifiers = lblShift.Visible ? modifiers | Constants.SHIFT : modifiers;
            modifiers = lblControl.Visible ? modifiers | Constants.CTRL : modifiers;
            KeyCombo = modifiers + "|" + this.keyCode;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            lblAlt.Visible = e.Alt;
            lblShift.Visible = e.Shift;
            lblControl.Visible = e.Control;
            lblKey.Visible = true;

            this.keyCode = e.KeyCode.ToString();
            lblKey.Text = GetKeyDisplayValue();
        }

        private string GetKeyDisplayValue()
        {
            string result = string.Empty;
            switch (this.keyCode)
            {
                case "Oem7": result = "Quote"; break;
                case "Cancel": result = "Pause"; break;
                case "Next": result = "PageDown"; break;
                case "Subtract": result = "NumpadSubtract"; break;
                case "OemMinus": result = "Minus/Underscore"; break;
                case "Oemplus": result = "="; break;
                case "Oemtilde": result = "~"; break;
                case "Oem6": result = "]"; break;
                case "Oem5": result = "\\"; break;
                case "OemOpenBrackets": result = "["; break;
                case "Oem1": result = ";"; break;
                case "OemQuestion": result = "/"; break;
                case "OemPeriod": result = "."; break;
                case "Oemcomma": result = ","; break;
                default: result = this.keyCode; break;
            }

            return result;
        }

        private void Reset()
        {
            lblAlt.Visible = false;
            lblShift.Visible = false;
            lblControl.Visible = false;
            lblKey.Text = string.Empty;
        }
    }
}
