using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FMACatCatcher
{
    public partial class frmcredits : Form
    {
        public frmcredits()
        {
            InitializeComponent();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            //opens game form and hides this form
            frmgame f = new frmgame();
            this.Hide();
            f.ShowDialog();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            //opens game form and hides this form
            frmintro h = new frmintro();
            this.Hide();
            h.ShowDialog();
        }

     

       
    }
}