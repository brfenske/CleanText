using System;
using System.Windows.Forms;

namespace CleanText
{
    public partial class DialogHelp : Form
    {
        public DialogHelp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("CleanText.rtf");
        }
    }
}
