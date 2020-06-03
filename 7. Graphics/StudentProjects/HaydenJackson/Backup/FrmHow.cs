using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmIntro
{
    public partial class FrmHow : Form
    {
        public FrmHow()
        {
            InitializeComponent();
        }

        // g: short for frmgame

        private void PicPlayDark_Click(object sender, EventArgs e)
        {
            //hides form shows game
            Form g = new FrmGame();
            g.Show();
            this.Hide();
        }

        private void PicPlayDark_MouseHover(object sender, EventArgs e)
        {
            //shows light play image
            PicPlayLight.Visible = true;
        }

        private void PicPlayLight_MouseLeave(object sender, EventArgs e)
        {
            //hides light play image
            PicPlayLight.Visible = false;
        }

        private void PicPlayLight_Click(object sender, EventArgs e)
        {
            //hides form shows game
            Form g = new FrmGame();
            g.Show();
            this.Hide();
        }
    }
}