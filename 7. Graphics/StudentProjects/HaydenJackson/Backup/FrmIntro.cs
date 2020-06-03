using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmIntro
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        // h: short for frmhow
        // g: short for frmgame

        private void PicHowDark_Click(object sender, EventArgs e)
        {
            //hides form and shows frmhow
            Form h = new FrmHow();
            h.Show();
            this.Hide();
        }

        private void PicPlayDark_Click(object sender, EventArgs e)
        {
            //hides form and shows frmgame
            Form g = new FrmGame();
            g.Show();
            this.Hide();
        }

        private void PicPlayLight_Click(object sender, EventArgs e)
        {
            //hides form and shows frmgame
            Form g = new FrmGame();
            g.Show();
            this.Hide();
        }

        private void PicHowDark_MouseHover(object sender, EventArgs e)
        {
            //shows light how image
            PicHowLight.Visible = true;
        }

        private void PicPlayDark_MouseHover(object sender, EventArgs e)
        {
            //shows light play image
            PicPlayLight.Visible = true;
        }

        private void PicHowLight_Click(object sender, EventArgs e)
        {
            //hides form and shows frmhow
            Form h = new FrmHow();
            h.Show();
            this.Hide();
        }

        private void PicHowLight_MouseLeave(object sender, EventArgs e)
        {
            //hides light how image
            PicHowLight.Visible = false;
        }

        private void PicPlayLight_MouseLeave(object sender, EventArgs e)
        {
            //hides light play image
            PicPlayLight.Visible = false;
        }
    }
}