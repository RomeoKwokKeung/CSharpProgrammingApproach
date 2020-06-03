using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FMACatCatcher
{
    public partial class frmhelp : Form
    {
        public frmhelp()
        {
            InitializeComponent();
        }

        private void btnopengame_Click(object sender, EventArgs e)
        {
            //opens game form and hides this form
            frmgame d = new frmgame();
            this.Hide();
            d.ShowDialog();

           
            
        }

        private void btnopenmenu_Click(object sender, EventArgs e)
        {
            //opens menu form and hides this form
            frmintro j = new frmintro();
            this.Hide();
            j.ShowDialog();

            
        }
                      
    }
}