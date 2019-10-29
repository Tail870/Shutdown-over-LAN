using System;
using System.Windows.Forms;

namespace SoL_server
{
    public partial class FormCmd : Form
    {
        public FormCmd()
        {
            InitializeComponent();
        }

        internal String cmd()
        {
            return textBoxCmd.Text;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (textBoxCmd.Text.Length == 0)
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCmd_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
