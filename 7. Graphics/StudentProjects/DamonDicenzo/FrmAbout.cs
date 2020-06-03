using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //Added for double buffering

namespace GuitarHeroClone
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }


        //*************************************************//
        //            VARIABLE DICTIONARY                  //
        //                                                 //
        // background - form background image              //
        // g - shortform variable for graphics             //
        // font - holds font properties                    //
        // grayColour - used to change font colour to gray //
        // f - shortform variable for the main form        //
        //                                                 //
        //*************************************************//



        // load in form background image
        Image background = Image.FromFile(Application.StartupPath + @"\about.jpg");

        private void FrmAbout_Paint(object sender, PaintEventArgs e)
        {
            // draw graphics from method
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void Draw(Graphics g)
        {
            // set font and colour
            Font font = new Font("Arial Black", 11, FontStyle.Regular);
            SolidBrush grayColour = new SolidBrush(Color.FromArgb(222,222,222));

            // draw background
            g.DrawImage(background, 0, 0);

            // draw text on form
            g.DrawString("Hero of Guitar, created by Damon Dicenzo, is a guitar simulation game", font, grayColour, 100, 204);
            g.DrawString("that lets you play along to a song of your choice. The idea for this game", font, grayColour, 100, 224);
            g.DrawString("came from the popular game on the market, Guitar Hero®.", font, grayColour, 100, 244);

            g.DrawString("In this current version of the game, you may only play along to Carry", font, grayColour, 100, 284);
            g.DrawString("On My Wayward Son by Kansas. There are four difficulty levels: Expert,", font, grayColour, 100, 304);
            g.DrawString("Hard, Medium and Easy.", font, grayColour, 100, 324);

            g.DrawString("When completing the song you are asked to input your name where you", font, grayColour, 100, 364);
            g.DrawString("will be ranked amongst other users who played that song on the same", font, grayColour, 100, 384);
            g.DrawString("difficulty level as you. So have some fun and challenge your friends to", font, grayColour, 100, 404);
            g.DrawString("earn the highest points!", font, grayColour, 100, 424);

            g.DrawString("Enjoy!", font, grayColour, 100, 464);
        }

        private void PicReturnFromAbout_Click(object sender, EventArgs e)
        {
            // hide this form and open main form
            Form f = new FrmMain();

            this.Hide();
            f.Show();
        }
    }
}