using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;         //needed for SoundPlayer Class
using System.Drawing.Drawing2D; //Added for double buffering

namespace GuitarHeroClone
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        //*************************************************//
        //            VARIABLE DICTIONARY                  //
        //                                                 //
        // background - form background image              //
        // title - form title image                        //
        // titlex - x coordinate for title image           //
        // titley - y coordinate for title image           //
        // muted - sound when hovering image button        //
        //                                                 //
        //*************************************************//

        // loads in background and title images
        Image background = Image.FromFile(Application.StartupPath + @"\frontpage.jpg");
        Image title = Image.FromFile(Application.StartupPath + @"\hogtitle.gif");

        SoundPlayer muted = new SoundPlayer(); // creates soundplayer for hover sound
        
        // x and y coordinates for title
        int titlex, titley;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            titlex = 820;
            titley = 50;

            // loads in button hover sound
            muted.SoundLocation = Application.StartupPath + @"\muted.wav";

            // sync's sound
            muted.LoadAsync();

            this.Focus();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            // drawgs graphics
            Graphics g = e.Graphics;

            Draw(g);
        }

        private void TimTitle_Tick(object sender, EventArgs e)
        {
            // animates title
            titlex -= 30;

            if (titlex <= 310)
                TimTitle.Enabled = false;

            Invalidate();
        }

        private void Draw(Graphics g)
        {
            // draws background and title images on form
            g.DrawImage(background, 0, 0);
            g.DrawImage(title, titlex, titley);
        }

        private void PicAbout_MouseHover(object sender, EventArgs e)
        {
            // shows white-text about image
            PicAbout2.Visible = true;
            muted.Play(); // plays hover sound
        }

        private void PicPlay1_MouseHover(object sender, EventArgs e)
        {
            // shows white-text play game image
            PicPlay2.Visible = true;
            muted.Play(); // plays hover sound
        }

        private void PicPlay2_MouseLeave(object sender, EventArgs e)
        {
            // restore original play game image
            PicPlay2.Visible = false;
        }

        private void PicAbout2_MouseLeave(object sender, EventArgs e)
        {
            // restore original about image
            PicAbout2.Visible = false;
        }

        private void PicScores1_MouseHover(object sender, EventArgs e)
        {
            // shows white-text high scores image
            PicScores2.Visible = true;
            muted.Play(); // plays hover sound
        }

        private void PicScores2_MouseLeave(object sender, EventArgs e)
        {
            // restore original high scores image
            PicScores2.Visible = false;
        }

        private void PicQuit_MouseHover(object sender, EventArgs e)
        {
            // shows white-text quit image
            PicQuit2.Visible = true;
            muted.Play(); // plays hover sound
        }

        private void PicQuit2_MouseLeave(object sender, EventArgs e)
        {
            // restore original quit image
            PicQuit2.Visible = false;
        }

        private void PicPlay2_Click(object sender, EventArgs e)
        {
            // hides form
            // shows FrmGuide
            Form f = new FrmGuide();
            this.Hide();
            f.Show();
        }

        private void PicPlay1_Click(object sender, EventArgs e)
        {
            // hides form
            // shows FrmGuide
            Form f = new FrmGuide();
            this.Hide();
            f.Show();
        }

        private void PicQuit2_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }

        private void PicQuit_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }

        private void PicAbout2_Click(object sender, EventArgs e)
        {
            // hides form
            // shows FrmAbout
            Form f = new FrmAbout();

            this.Hide();
            f.Show();
        }

        private void PicAbout_Click(object sender, EventArgs e)
        {
            // hides form
            // shows FrmAbout
            Form f = new FrmAbout();

            this.Hide();
            f.Show();
        }

        private void PicScores2_Click(object sender, EventArgs e)
        {
            // hides form
            // shows FrmHighScores
            Form f = new FrmHighScores();

            this.Hide();
            f.Show();
        }

        private void PicScores1_Click(object sender, EventArgs e)
        {
            // hides form
            // shows FrmHighScores
            Form f = new FrmHighScores();

            this.Hide();
            f.Show();
        }
    }
}