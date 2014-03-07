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
                lblNotice.Text = "Change CleanText hot key";
                string[] keyParts = KeyCombo.Split('|');
                int modifiers = Convert.ToInt32(keyParts[0]);
                lblAlt.Visible = Program.UseAltModifier(modifiers);
                lblShift.Visible = Program.UseShiftModifier(modifiers);
                lblControl.Visible = Program.UseControlModifier(modifiers);
                this.keyCode = keyParts[1].ToString();
                lblKey.Text = Program.GetKeyDisplayValue(this.keyCode);
            }
            else
            {
                lblAlt.Visible = false;
                lblShift.Visible = false;
                lblControl.Visible = false;
                this.keyCode = string.Empty;
                lblKey.Text = string.Empty;
            }

            txtKeyCombo.Focus();
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
            lblKey.Text = Program.GetKeyDisplayValue(this.keyCode);
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
