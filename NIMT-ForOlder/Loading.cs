using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMT_ForOlder
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timerProgressbar.Start();
        }

        private void timerProgressbar_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(21);
            if (this.Opacity >= 0.025)
            { 
                this.Opacity -= 0.025;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                timerProgressbar.Stop();
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
        private void PB_background_Click(object sender, EventArgs e)
        {

        }
    }
}
