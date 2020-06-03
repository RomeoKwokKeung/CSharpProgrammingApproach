using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FMACatCatcher
{
    public partial class frmintro : Form
    {
        public frmintro()
        {
            InitializeComponent();
        }

        private void frmintro_Load(object sender, EventArgs e)
        {
           
        }
        
        private void btnplay_Click(object sender, EventArgs e)
        {
            //opens game form and hides this form
            frmgame a=new frmgame();
            this.Hide();
            a.ShowDialog();
            
            
        }
              
        private void btninstructions_Click_1(object sender, EventArgs e)
        {
            //opens help form and hide this form
            frmhelp b = new frmhelp();
            this.Hide();
            b.ShowDialog();

           
        }

        private void btncredits_Click_1(object sender, EventArgs e)
        {
            //opens credits form and hides this form
            frmcredits c = new frmcredits();
            this.Hide();
            c.ShowDialog();

            
        }

        
    }
}