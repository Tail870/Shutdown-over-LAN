using System;
using System.Windows.Forms;

namespace SoL_server
{
    public partial class FormShutdown : Form
    {
        public FormShutdown()
        {
            InitializeComponent();
        }

        internal bool Force()
        {
            return checkBoxForce.Checked;
        }
        internal decimal Timer()
        {
            return numericUpDownTimer.Value;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
