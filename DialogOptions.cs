using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CleanText
{
    public partial class DialogOptions : Form
    {
        string[] modifierItems = new string[] { string.Empty, "SHIFT", "CTRL", "ALT" };

        public string KeyCombo = string.Empty;

        public DialogOptions()
        {
            InitializeComponent();
            SetModifiers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetModifiers();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            KeyCombo = cboModifier1.Text + "|" + cboModifier2.Text + "|" + cboKey.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboModifier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModifier2.SelectedIndexChanged -= cboModifier2_SelectedIndexChanged;
            string selected = cboModifier2.Text;

            cboModifier2.Items.Clear();
            cboModifier2.Items.AddRange(modifierItems);
            cboModifier2.Items.Remove(cboModifier1.Text);

            cboModifier2.SelectedItem = selected;
            cboModifier2.SelectedIndexChanged += cboModifier2_SelectedIndexChanged;
        }

        private void cboModifier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModifier1.SelectedIndexChanged -= cboModifier1_SelectedIndexChanged;
            string selected = cboModifier1.Text;

            cboModifier1.Items.Clear();
            cboModifier1.Items.AddRange(modifierItems);
            cboModifier1.Items.Remove(cboModifier2.Text);

            cboModifier1.SelectedItem = selected;
            cboModifier1.SelectedIndexChanged += cboModifier1_SelectedIndexChanged;
        }

        private void SetModifiers()
        {
            cboModifier1.Items.Clear();
            cboModifier1.Items.AddRange(modifierItems);

            cboModifier2.Items.Clear();
            cboModifier2.Items.AddRange(modifierItems);

            cboKey.SelectedIndex = 0;
        }
    }
}
