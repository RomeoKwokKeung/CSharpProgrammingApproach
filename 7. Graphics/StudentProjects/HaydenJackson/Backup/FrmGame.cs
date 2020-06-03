using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;         //needed for SoundPlayer Class
using System.Drawing.Drawing2D; //Added for double buffering

namespace FrmIntro
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        // background: image for background of game
        // fishleft: fish image swimming left
        // fishright: fish image swimming right
        // sub: submarine image
        // torpedo: torpedo image
        // deadleft: dead fish facing left
        // deadright: dead fish racing right
        // fishleftX: x position for fish swimming left
        // fishleftY: y position for fish swimming left
        // fishrightX: x position for fish swimming right
        // fishrightY: y position for fish swimming right
        // deadleftX: x position for dead fish swimming left
        // deadleftY: y position for dead fish swimming left
        // deadrightX: x position for dead fish swimming right
        // deadrightY: y position for dead fish swimming right
        // subX: x position for submarine
        // torpX: x position for torpedo
        // torpY: y position for torpedo
        // points: keeps score of the game
        // counter: used to count seconds

        //get images from file
        Image background = Image.FromFile(Application.StartupPath + @"\water.jpg");
        Image fishleft = Image.FromFile(Application.StartupPath + @"\fish1.gif");
        Image fishright = Image.FromFile(Application.StartupPath + @"\fish2.gif");
        Image sub = Image.FromFile(Application.StartupPath + @"\sub.gif");
        Image torpedo = Image.FromFile(Application.StartupPath + @"\torpedo.gif");
        Image deadleft = Image.FromFile(Application.StartupPath + @"\dead.gif");
        Image deadright = Image.FromFile(Application.StartupPath + @"\dead2.gif");

        //create integer variables
        int fishleftX;
        int fishleftY;
        int fishrightX;
        int fishrightY;
        int deadleftX;
        int deadleftY;
        int deadrightX;
        int deadrightY;
        int subX;
        int torpX;
        int torpY;
        int points;
        int counter = 0;

        SoundPlayer water = new SoundPlayer(); //water sound
        SoundPlayer torpedosound = new SoundPlayer(); //torpedo sound

        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            //draw graphics
            Graphics g = e.Graphics;

            DrawStuff(g);   
        }

        private void DrawStuff(Graphics g)
        {
            //draw background, fish, submarine and torpedo
            g.DrawImage(background, 0, 0, 520, 347);

            g.DrawImage(fishleft, fishleftX, fishleftY, 75, 75);
            g.DrawImage(fishright, fishrightX, fishrightY, 75, 75);
            g.DrawImage(deadleft, deadleftX, deadleftY, 75, 75);
            g.DrawImage(deadright, deadrightX, deadrightY, 75, 75);

            g.DrawImage(torpedo, torpX, torpY);
            g.DrawImage(sub, subX, 5);
        }

        private void TimFishOne_Tick(object sender, EventArgs e)
        {
            //move fish towards left
            fishleftX -= 10;

            //reset when reached the end of form
            if ((fishleftX + 75) < 0)
            {
                fishleftX = 565;
            }

            Invalidate(); //refreshes screen for graphics
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            //set alive fish positions
            fishleftX = 565;
            fishleftY = 120;
            fishrightX = -75;
            fishrightY = 200;

            //set dead fish positions
            deadleftX = -100;
            deadleftY = 120;
            deadrightX = -100;
            deadrightY = 200;

            //set submarine and torpedo positions
            subX = 250;
            torpY = 0;
            torpX = 640;

            //reset points
            points = 0;

            //gets sounds from files
            water.SoundLocation = Application.StartupPath + @"\water.wav";
            torpedosound.SoundLocation = Application.StartupPath + @"\torpedo.wav";

            //syncs sounds
            water.LoadAsync();
            torpedosound.LoadAsync();
        }

        private void TimFishTwo_Tick(object sender, EventArgs e)
        {
            //move fish towards left
            fishrightX += 10;

            //reset when reached the end of form
            if (fishrightX > 520)
            {
                fishrightX = -75;
            }

            Invalidate(); //refreshes screen for graphics
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            //starts game when enter is hit
            if (e.KeyCode == Keys.Enter)
            {
                TimFishOne.Enabled = true;
                TimFishTwo.Enabled = true;
                TimTime.Enabled = true;
                LblHow.Visible = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                if (subX > 0)
                {
                    //moves sub to left when left key hit
                    subX -= 8;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if ((subX + sub.Width) < background.Width)
                {
                    //moves sub to right when right key hit
                    subX += 8;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                //launches torpedo and minuses 1 point when spacebar hit
                if (points >= 1)
                {
                    points--;
                    LblPoints.Text = points.ToString();
                }

                torpedosound.Play(); //plays torpedo sound
                torpY = 45;
                TimTorpedo.Enabled = false;
                torpX = subX + 75;
                TimTorpedo.Enabled = true;
            }
        }

        private void TimTorpedo_Tick(object sender, EventArgs e)
        {
            //moves torpedo
            torpY += 10;

            if ((torpY + torpedo.Height - 15) > fishleftY && (torpX + torpedo.Width) - 15 > fishleftX && (torpX + torpedo.Width + 15) < (fishleftX + fishleft.Width) && torpY < (fishleftY + fishleft.Height))
            {
                //collision detection when torpedo meets fish swimming left
                //adds points
                points += 2;
                LblPoints.Text = points.ToString();
                TimFishOne.Enabled = false;
                //starts dead fish animation
                deadleftX = fishleftX;
                TimDeadLeft.Enabled = true;
                fishleftX = -200;
                //plays hit sound
                water.Play();
            }
            else if ((torpY + torpedo.Height - 15) > fishrightY && (torpX + torpedo.Width) - 15 > fishrightX && (torpX + torpedo.Width + 15) < (fishrightX + fishright.Width) && torpY < (fishrightY + fishright.Height))
            {
                //collision detection when torpedo meets fish swimming right
                //adds points
                points += 2;
                LblPoints.Text = points.ToString();
                TimFishTwo.Enabled = false;
                //starts dead fish animation
                deadrightX = fishrightX;
                TimDeadRight.Enabled = true;
                fishrightX = -200;
                //plays hit sound
                water.Play();
            }

            if ((torpY + torpedo.Height) > background.Height)
            {
                //resets torpedo when it reaches bottom of the screen
                torpY = 0;
                torpX = 640;
                TimTorpedo.Enabled = false;
            }
        }

        private void TimDeadLeft_Tick(object sender, EventArgs e)
        {
            //moves dead fish facing left
            deadleftY += 5;

            //resets dead fish when it reaches bottom of the screen
            if ((deadleftY + deadleft.Height) > background.Height)
            {
                deadleftX = -100;
                deadleftY = 120;
                TimFishOne.Enabled = true;
                fishleftX = -75;
                fishleftY = 120;
                TimDeadLeft.Enabled = false;
            }

            Invalidate(); //refreshes screen for graphics
        }

        private void TimDeadRight_Tick(object sender, EventArgs e)
        {
            //moves dead fish facing right
            deadrightY += 5;

            //resets dead fish when it reaches bottom of the screen
            if ((deadrightY + deadright.Height) > background.Height)
            {
                deadrightX = -100;
                deadrightY = 200;
                TimFishTwo.Enabled = true;
                fishrightX = 565;
                fishrightY = 200;
                TimDeadRight.Enabled = false;
            }

            Invalidate(); //refreshes screen for graphics
        }

        private void TimTime_Tick(object sender, EventArgs e)
        {
            //counts seconds
            counter++;

            //displays seconds
            LblTime.Text = counter.ToString() + " seconds";

            //stops game when points reach 25
            if (points > 24)
            {
                TimTime.Enabled = false;
                TimFishOne.Enabled = false;
                TimFishTwo.Enabled = false;
                TimTorpedo.Enabled = false;
                TimDeadLeft.Enabled = false;
                TimDeadRight.Enabled = false;

                // sends points and time to the results form
                FrmResults n = new FrmResults();
                n.Points = LblPoints.Text;
                n.Time = LblTime.Text;

                // hides game and shows results form
                this.Hide();
                n.ShowDialog();
            }
        }
    }
}