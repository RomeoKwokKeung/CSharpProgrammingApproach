using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FMACatCatcher
{
    public partial class frmwin : Form
    {
        public frmwin()
        {
            InitializeComponent();
        }

      

        private void btntryagain_Click(object sender, EventArgs e)
        {
            //opens game form and hides this form
            frmgame r = new frmgame();
            this.Hide();
            r.ShowDialog();         
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            //closes game
            this.Close();
        }
    }
}