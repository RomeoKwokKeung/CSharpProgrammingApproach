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
    public partial class FrmSong : Form
    {
        public FrmSong()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }

        //****************************************************//
        //               VARIABLE DICTIONARY                  //
        //                                                    //
        // background - form background image                 //
        // title - title image                                //
        // titlex - title image's x coordinate                //
        // titley - title image's y coordinate                //
        // g - variable for graphics                          //
        // f - variable for FrmDifficulty                     //
        //                                                    //
        //****************************************************//

        // loads in background and title images
        Image background = Image.FromFile(Application.StartupPath + @"\choosesong.jpg");
        Image title = Image.FromFile(Application.StartupPath + @"\choosesongtitle.gif");

        // x and y coordinates for title
        int titlex, titley;

        SoundPlayer muted = new SoundPlayer(); // creates soundplayer for hover sound

        private void Draw(Graphics g)
        {
            // draws background and title images on form
            g.DrawImage(background, 0, 0, 807, 576);
            g.DrawImage(title, titlex, titley);
        }

        private void FrmSong_Paint(object sender, PaintEventArgs e)
        {
            // draws graphics from Draw method
            Graphics g = e.Graphics;

            Draw(g);
        }

        private void FrmSong_Load(object sender, EventArgs e)
        {
            // positions title image
            titlex = 820;
            titley = 30;

            // loads in button hover sound
            muted.SoundLocation = Application.StartupPath + @"\muted.wav";

            // sync's sound
            muted.LoadAsync();

            // gives form focus
            this.Focus();
        }

        private void TimTitle_Tick(object sender, EventArgs e)
        {
            // animates title image
            titlex -= 30;

            // stops title animation at specific time 
            if (titlex <= 310)
                TimTitle.Enabled = false;

            Invalidate(); // refreshes form to show updated graphics
        }

        private void PicSong1_MouseHover(object sender, EventArgs e)
        {
            PicSong2.Visible = true; // shows hover image of song picture
            muted.Play(); // plays hover sound
        }

        private void PicSong2_MouseLeave(object sender, EventArgs e)
        {
            PicSong2.Visible = false; // hides hover image of song picture
        }

        private void PicSong2_Click(object sender, EventArgs e)
        {
            // hides form adn shows FrmDifficulty
            Form f = new FrmDifficulty();

            f.Show();
            this.Hide();
        }

        private void PicSong1_Click(object sender, EventArgs e)
        {
            // hides form adn shows FrmDifficulty
            Form f = new FrmDifficulty();

            f.Show();
            this.Hide();
        }
    }
}