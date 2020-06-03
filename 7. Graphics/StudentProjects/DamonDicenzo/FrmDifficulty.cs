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
    public partial class FrmDifficulty : Form
    {
        public FrmDifficulty()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }

        //*************************************************//
        //            VARIABLE DICTIONARY                  //
        //                                                 //
        // background - form background image              //
        // title - form title image                        //
        // titlex - x coordinate for title image           //
        // titley - y coordinate for title image           //
        // g - shortform variable for graphics             //
        // f - shortform variable for the certain form     //
        //                                                 //
        //*************************************************//

        // load in background image
        Image background = Image.FromFile(Application.StartupPath + @"\choosedifficulty.jpg");
        // load in title image
        Image title = Image.FromFile(Application.StartupPath + @"\difficultytitle.gif");

        // x and y coordinates for title
        int titlex, titley;

        SoundPlayer muted = new SoundPlayer(); // creates soundplayer for hover sound

        private void Draw(Graphics g)
        {
            g.DrawImage(background, 0, 0, 807, 576); // draw background image on form
            g.DrawImage(title, titlex, titley); // draw title image on form
        }

        private void FrmDifficulty_Paint(object sender, PaintEventArgs e)
        {
            // draw graphics from method
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void FrmDifficulty_Load(object sender, EventArgs e)
        {
            titlex = -500; // position title's x coordinate
            titley = 30; // position title's y coordinate

            // loads in button hover sound
            muted.SoundLocation = Application.StartupPath + @"\muted.wav";

            // sync's sound
            muted.LoadAsync();

            this.Focus(); // gives the form focus
        }

        private void TimTitle_Tick(object sender, EventArgs e)
        {
            titlex += 30; // adds 30 to the title's x coordinate

            // when the title reaches a certain spot, timer stops
            if (titlex >= 10)
                TimTitle.Enabled = false;

            Invalidate(); // re-draws form
        }

        private void PicEasy_MouseHover(object sender, EventArgs e)
        {
            PicEasy2.Visible = true; // shows PicEasy2
            muted.Play(); // plays hover sound
        }

        private void PicMedium1_MouseHover(object sender, EventArgs e)
        {
            PicMedium2.Visible = true; // shows PicMedium2
            muted.Play(); // plays hover sound
        }

        private void PicExpert1_MouseHover(object sender, EventArgs e)
        {
            PicExpert2.Visible = true; // shows PicExpert2
            muted.Play(); // plays hover sound
        }

        private void PicHard1_MouseHover(object sender, EventArgs e)
        {
            PicHard2.Visible = true; // shows PicHard2
            muted.Play(); // plays hover sound
        }

        private void PicExpert2_MouseLeave(object sender, EventArgs e)
        {
            PicExpert2.Visible = false; // hides PicExpert2
        }

        private void PicHard2_MouseLeave(object sender, EventArgs e)
        {
            PicHard2.Visible = false; // Hides PicHard2
        }

        private void PicMedium2_MouseLeave(object sender, EventArgs e)
        {
            PicMedium2.Visible = false; // Hides PicMedium2
        }

        private void PicEasy2_MouseLeave(object sender, EventArgs e)
        {
            PicEasy2.Visible = false; // Hides PicEasy2
        }

        private void PicEasy2_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmEasy
            Form f = new FrmEasy();
            f.Show();
            this.Hide();
        }

        private void PicEasy_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmEasy
            Form f = new FrmEasy();
            f.Show();
            this.Hide();
        }

        private void PicMedium1_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmMedium
            Form f = new FrmMedium();

            f.Show();
            this.Hide();
        }

        private void PicMedium2_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmMedium
            Form f = new FrmMedium();

            f.Show();
            this.Hide();
        }

        private void PicHard2_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmHard
            Form f = new FrmHard();

            f.Show();
            this.Hide();
        }

        private void PicHard1_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmHard
            Form f = new FrmHard();

            f.Show();
            this.Hide();
        }

        private void PicExpert2_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmExpert
            Form f = new FrmExpert();

            f.Show();
            this.Hide();
        }

        private void PicExpert1_Click(object sender, EventArgs e)
        {
            // hides this form
            // shows FrmExpert
            Form f = new FrmExpert();

            f.Show();
            this.Hide();
        }
    }
}