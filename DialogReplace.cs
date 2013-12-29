using System;
using System.Windows.Forms;

namespace CleanText
{
    public partial class DialogReplace : Form
    {
        public string UnwantedText { get; set; }

        public string ReplacementText { get; set; }

        public DialogReplace()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UnwantedText = txtOld.Text;
            ReplacementText = txtNew.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
