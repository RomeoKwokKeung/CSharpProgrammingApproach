using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmIntro
{
    public partial class FrmResults : Form
    {
        public FrmResults()
        {
            InitializeComponent();
        }

        // h: short for frmhow
        // g: short for frmgame
        // i: short for frmintro

        public string Points
        {
            //get and set points from game
            get { return LblPoints.Text; }
            set { LblPoints.Text = value; }
        }

        public string Time
        {
            //get and set time from game
            get { return LblTime.Text; }
            set { LblTime.Text = value; }
        }

        private void PicPlayDark_MouseHover(object sender, EventArgs e)
        {
            //show light play image
            PicPlayLight.Visible = true;
        }

        private void PicPlayLight_MouseLeave(object sender, EventArgs e)
        {
            //hide light play image
            PicPlayLight.Visible = false;
        }

        private void PicExitDark_MouseHover(object sender, EventArgs e)
        {
            //show light exit image
            PicExitLight.Visible = true;
        }

        private void PicExitLight_MouseLeave(object sender, EventArgs e)
        {
            //hide light exit image
            PicExitLight.Visible = false;
        }

        private void PicExitLight_Click(object sender, EventArgs e)
        {
            //close all forms
            FrmGame g = new FrmGame();
            FrmHow h = new FrmHow();
            FrmIntro i = new FrmIntro();

            g.Close();
            h.Close();
            i.Close();
            this.Close();
        }

        private void PicExitDark_Click(object sender, EventArgs e)
        {
            //close all forms
            FrmGame g = new FrmGame();
            FrmHow h = new FrmHow();
            FrmIntro i = new FrmIntro();

            g.Close();
            h.Close();
            i.Close();
            this.Close();
        }

        private void PicPlayDark_Click(object sender, EventArgs e)
        {
            //close all forms but shows game form
            FrmGame g = new FrmGame();
            FrmHow h = new FrmHow();
            FrmIntro i = new FrmIntro();

            g.Show();
            h.Close();
            i.Close();
            this.Close();
        }

        private void PicPlayLight_Click(object sender, EventArgs e)
        {
            //close all forms but shows game form
            FrmGame g = new FrmGame();
            FrmHow h = new FrmHow();
            FrmIntro i = new FrmIntro();

            g.Show();
            h.Close();
            i.Close();
            this.Close();
        }
    }
}