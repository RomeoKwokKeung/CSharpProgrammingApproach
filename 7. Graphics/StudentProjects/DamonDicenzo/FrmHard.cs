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
    public partial class FrmHard : Form
    {
        public FrmHard()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }

        //*************************************************//
        //               VARIABLE DICTIONARY               //
        //                                                 //
        // background - form background image              //
        // greenkey - green key pad image                  //
        // redkey - red key pad image                      //
        // yellowkey - yellow key pad image                //
        // orangekey - orange key pad image                //
        // blue key - blue key pad image                   //
        // greennote - green note image                    //
        // rednote - red note image                        //
        // yellownote - yellow note image                  //
        // bluenote - blue note image                      //
        // orangenote - orange note image                  //
        // count - counter for countdown before game       //
        // songcount - countdown for song timer loop       //
        // score - holds player's score                    //
        // hits - holds amount of hit notes                //
        // counter[5] - countdown image array              //
        // countdown - image used for each countdown image //
        // missed - sound for missed note                  //
        // r - variable for random number generator        //
        // p - variable shortform for FrmScore             //
        //                                                 //
        //*************************************************//


        // loads in form background and key pad images
        Image background = Image.FromFile(Application.StartupPath + @"\gamebg.jpg");
        Image greenkey = Image.FromFile(Application.StartupPath + @"\greenkey.gif");
        Image redkey = Image.FromFile(Application.StartupPath + @"\redkey.gif");
        Image yellowkey = Image.FromFile(Application.StartupPath + @"\yellowkey.gif");
        Image orangekey = Image.FromFile(Application.StartupPath + @"\orangekey.gif");
        Image bluekey = Image.FromFile(Application.StartupPath + @"\bluekey.gif");
        
        // loads in note images
        Image greennote = Image.FromFile(Application.StartupPath + @"\note1.gif");
        Image rednote = Image.FromFile(Application.StartupPath + @"\note2.gif");
        Image yellownote = Image.FromFile(Application.StartupPath + @"\note3.gif");
        Image bluenote = Image.FromFile(Application.StartupPath + @"\note4.gif");
        Image orangenote = Image.FromFile(Application.StartupPath + @"\note5.gif");

        int count; // countdown counter
        int songcount; // countdown for song timer loop
        int score; // holds player's score
        int hits; // holds amount of hit notes

        Image[] counter = new Image[5]; // image array for countdown

        Image countdown; // image variable used for each countdown image

        SoundPlayer missed = new SoundPlayer(); // creates soundplayer for missed note sound

        Random r = new Random(); // variable for random generator

        private void Draw(Graphics g)
        {
            // draws background on form
            g.DrawImage(background, 0, 0, 807, 576);

            // draws key pads on form
            g.DrawImage(greenkey, Global.gkeyX, Global.keyY);
            g.DrawImage(redkey, Global.rkeyX, Global.keyY);
            g.DrawImage(yellowkey, Global.ykeyX, Global.keyY);
            g.DrawImage(bluekey, Global.bkeyX, Global.keyY);
            g.DrawImage(orangekey, Global.okeyX, Global.keyY);

            // draws notes on form
            g.DrawImage(greennote, Global.gnotex, Global.gnotey, Global.gnotew, Global.gnoteh);
            g.DrawImage(rednote, Global.rnotex, Global.rnotey, Global.rnotew, Global.rnoteh);
            g.DrawImage(yellownote, Global.ynotex, Global.ynotey, Global.ynotew, Global.ynoteh);
            g.DrawImage(bluenote, Global.bnotex, Global.bnotey, Global.bnotew, Global.bnoteh);
            g.DrawImage(orangenote, Global.onotex, Global.onotey, Global.onotew, Global.onoteh);

            // draws countdown images on form
            g.DrawImage(countdown, Global.countX, Global.countY);
        }

        private void FrmHard_Paint(object sender, PaintEventArgs e)
        {
            // Draws graphics from method
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void FrmHard_Load(object sender, EventArgs e)
        {
            count = 1; // resets counter
            songcount = 1; // resets song loop counter

            score = 0; // resets score
            hits = 0; // resets hits

            // loads in countdown images to array
            for (int i = 1; i <= 3; i++)
            {
                counter[i] = Image.FromFile(Application.StartupPath + @"\count" + i.ToString() + ".gif");
            }

            countdown = counter[1]; // sets first countdown image

            LblScore.Text = score.ToString(); // sets score label
            LblHits.Text = hits.ToString(); // sets hit label

            // loads in missed note sound
            missed.SoundLocation = Application.StartupPath + @"\missed.wav";

            // sync's missed note
            missed.LoadAsync();

            // gives the form focus
            this.Focus();
        }

        private void TimCountdown_Tick(object sender, EventArgs e)
        {
            count++; // counts each loop from timer

            // starts game and hides counter when countdown finishes
            if (count > 3)
            {
                TimCountdown.Enabled = false;
                StartGame();
                Global.countX = -200;
                Global.countY = -200;
                count = 1;
            }

            // sets countdown image
            countdown = counter[count];

            Invalidate();   //refreshes screen otherwise image wont change
        }

        private void FrmHard_KeyDown(object sender, KeyEventArgs e)
        {

            // When each key is pressed, checks for collision with appropriate note,
            // if collision is detected then adds 50 points to your score and
            // resets note's position.
            // If you miss the note, you lose 25 points and the missed sound plays.

            if (e.KeyCode == Keys.F1)
            {
                if ((Global.gnotey + Global.gnoteh) > Global.keyY && Global.gnotey < (Global.keyY + Global.gnoteh))
                {
                    Global.gnotey += 300;
                    score += 50;
                    hits += 1;
                    LblHits.Text = hits.ToString();
                    LblScore.Text = score.ToString();
                    TimGNote.Enabled = false;
                }
                else
                {
                    score -= 25;
                    LblScore.Text = score.ToString();
                    missed.Play();
                }
            }

            if (e.KeyCode == Keys.F2)
            {
                if ((Global.rnotey + Global.rnoteh) > Global.keyY && Global.rnotey < (Global.keyY + Global.rnoteh))
                {
                    Global.rnotey += 300;
                    score += 50;
                    hits += 1;
                    LblHits.Text = hits.ToString();
                    LblScore.Text = score.ToString();
                    TimRNote.Enabled = false;
                }
                else
                {
                    score -= 25;
                    LblScore.Text = score.ToString();
                    missed.Play();
                }
            }

            if (e.KeyCode == Keys.F3)
            {
                if ((Global.ynotey + Global.ynoteh) > Global.keyY && Global.ynotey < (Global.keyY + Global.ynoteh))
                {
                    Global.ynotey += 300;
                    score += 50;
                    hits += 1;
                    LblHits.Text = hits.ToString();
                    LblScore.Text = score.ToString();
                    TimYNote.Enabled = false;
                }
                else
                {
                    score -= 25;
                    LblScore.Text = score.ToString();
                    missed.Play();
                }
            }

            if (e.KeyCode == Keys.F4)
            {
                if ((Global.bnotey + Global.bnoteh) > Global.keyY && Global.bnotey < (Global.keyY + Global.bnoteh))
                {
                    Global.bnotey += 300;
                    score += 50;
                    hits += 1;
                    LblHits.Text = hits.ToString();
                    LblScore.Text = score.ToString();
                    TimBNote.Enabled = false;
                }
                else
                {
                    score -= 25;
                    LblScore.Text = score.ToString();
                    missed.Play();
                }
            }

            if (e.KeyCode == Keys.F5)
            {
                if ((Global.onotey + Global.onoteh) > Global.keyY && Global.onotey < (Global.keyY + Global.onoteh))
                {
                    Global.onotey += 300;
                    score += 50;
                    hits += 1;
                    LblHits.Text = hits.ToString();
                    LblScore.Text = score.ToString();
                    TimONote.Enabled = false;
                }
                else
                {
                    score -= 25;
                    LblScore.Text = score.ToString();
                    missed.Play();
                }
            }

            // when escape key is pressed, game is paused,
            // calls PauseGame method
            if (e.KeyCode == Keys.Escape)
                PauseGame();

            Invalidate(); //refreshes screen otherwise image wont change
        }

        public void StartGame()
        {
            // resets score when game is started
            score = 0;
            LblScore.Text = score.ToString();

            // resets hits when game is started
            hits = 0;
            LblHits.Text = hits.ToString();

            // plays song when game is started
            WmpSong.URL = Application.StartupPath + @"\song.mp3";

            // starts song and invalidater timers
            TimSong.Enabled = true;
            TimInvalidate.Enabled = true;
        }

        public void EndGame()
        {
            ResetVariables();

            // stops song and timers
            TimSong.Enabled = false;
            TimGNote.Enabled = false;
            TimRNote.Enabled = false;
            TimYNote.Enabled = false;
            TimBNote.Enabled = false;
            TimONote.Enabled = false;
            WmpSong.Ctlcontrols.stop();

            // sends score and difficulty level to the score display form
            FrmScore p = new FrmScore();
            p.ShowScore = score.ToString();
            p.Mode = "hard";

            // hides this form and shows score display form
            this.Hide();
            p.ShowDialog();
        }

        public void PauseGame()
        {
            // stops all timers
            TimSong.Stop();
            TimGNote.Stop();
            TimRNote.Stop();
            TimYNote.Stop();
            TimBNote.Stop();
            TimONote.Stop();

            // shows appropriate labels shown only when paused
            PnlPaused.Visible = true;
            LblPaused.Visible = true;
            LblQuit.Visible = true;
            LblResume.Visible = true;
            LblChangeDifficulty.Visible = true;
            WmpSong.Ctlcontrols.pause(); // pauses song
        }

        public void ResumeGame()
        {
            if (songcount > 32)
            {
                // starts timers
                TimSong.Start();
                TimGNote.Start();
                TimRNote.Start();
                TimYNote.Start();
                TimBNote.Start();
                TimONote.Start();
            }

            // hides paused only labels
            PnlPaused.Visible = false;
            LblPaused.Visible = false;
            LblQuit.Visible = false;
            LblResume.Visible = false;
            LblChangeDifficulty.Visible = false;
            WmpSong.Ctlcontrols.play(); // plays song
        }

        public void ChangeDifficulty()
        {
            Form f = new FrmDifficulty();

            ResetVariables();

            // resets score and hits
            score = 0;
            hits = 0;

            // hides this form and shows Choose Difficulty form
            this.Hide();
            f.Show();
        }

        public void ResetVariables()
        {
            // resets all x & y coordinates for each note
            Global.gnotex = 347;
            Global.rnotex = 367;
            Global.ynotex = 395;
            Global.bnotex = 415;
            Global.onotex = 443;
            Global.gnotey = 145;
            Global.rnotey = 145;
            Global.ynotey = 145;
            Global.bnotey = 145;
            Global.onotey = 145;

            // resets each height and width of each note
            Global.gnotew = 20;
            Global.gnoteh = 15;
            Global.rnotew = 20;
            Global.rnoteh = 15;
            Global.ynotew = 20;
            Global.ynoteh = 15;
            Global.bnotew = 20;
            Global.bnoteh = 15;
            Global.onotew = 20;
            Global.onoteh = 15;
        }

        private void TimGNote_Tick(object sender, EventArgs e)
        {
            // play Green Note animation
            Global.gnotex -= 5;
            Global.gnotey += 13;

            Global.gnotew += 1;
            Global.gnoteh += 1;
        }

        private void TimRNote_Tick(object sender, EventArgs e)
        {
            // play Red Note animation
            Global.rnotex -= 3;
            Global.rnotey += 13;

            Global.rnotew += 1;
            Global.rnoteh += 1;
        }

        private void TimYNote_Tick(object sender, EventArgs e)
        {
            // play Yellow Note animation
            Global.ynotex -= 1;
            Global.ynotey += 13;

            Global.ynotew += 1;
            Global.ynoteh += 1;
        }

        private void TimBNote_Tick(object sender, EventArgs e)
        {
            // play Blue Note animation
            Global.bnotex += 2;
            Global.bnotey += 13;

            Global.bnotew += 1;
            Global.bnoteh += 1;
        }

        private void TimONote_Tick(object sender, EventArgs e)
        {
            // play Orange Note animation
            Global.onotex += 4;
            Global.onotey += 13;

            Global.onotew += 1;
            Global.onoteh += 1;
        }

        private void TimSong_Tick(object sender, EventArgs e)
        {
            songcount++; // counts for song timer loop

            // ends game when the song is done
            if (songcount > 640)
                EndGame();

            // starts the animations at appropriate point in song
            // resets each note to start position when reaching bottom of form
            if (songcount > 32)
            {
                if (Global.gnotey > 600)
                {
                    TimGNote.Enabled = false;
                    Global.gnotex = 347;
                    Global.gnotey = 145;
                    Global.gnotew = 20;
                    Global.gnoteh = 15;
                }

                if (Global.rnotey > 600)
                {
                    TimRNote.Enabled = false;
                    Global.rnotex = 367;
                    Global.rnotey = 145;
                    Global.rnotew = 20;
                    Global.rnoteh = 15;
                }

                if (Global.ynotey > 600)
                {
                    TimYNote.Enabled = false;
                    Global.ynotex = 395;
                    Global.ynotey = 145;
                    Global.ynotew = 20;
                    Global.ynoteh = 15;
                }

                if (Global.bnotey > 600)
                {
                    TimBNote.Enabled = false;
                    Global.bnotex = 415;
                    Global.bnotey = 145;
                    Global.bnotew = 20;
                    Global.bnoteh = 15;
                }

                if (Global.onotey > 600)
                {
                    TimONote.Enabled = false;
                    Global.onotex = 443;
                    Global.onotey = 145;
                    Global.onotew = 20;
                    Global.onoteh = 15;
                }

                int randomstart = r.Next(1, 6); // generates random number from 1-5

                // starts each note timer randomly
                if (randomstart == 1)
                {
                    if (TimGNote.Enabled == true)
                    {
                        randomstart += 1;
                    }
                    else
                    {
                        TimGNote.Enabled = true;
                    }
                }
                else if (randomstart == 2)
                {
                    if (TimRNote.Enabled == true)
                    {
                        randomstart += 1;
                    }
                    else
                    {
                        TimRNote.Enabled = true;
                    }
                }
                else if (randomstart == 3)
                {
                    if (TimYNote.Enabled == true)
                    {
                        randomstart += 1;
                    }
                    else
                    {
                        TimYNote.Enabled = true;
                    }
                }
                else if (randomstart == 4)
                {
                    if (TimBNote.Enabled == true)
                    {
                        randomstart += 1;
                    }
                    else
                    {
                        TimBNote.Enabled = true;
                    }
                }
                else if (randomstart == 5)
                {
                    if (TimONote.Enabled == true)
                    {
                        randomstart -= 1;
                    }
                    else
                    {
                        TimONote.Enabled = true;
                    }
                }
            }
        }

        private void TimInvalidate_Tick(object sender, EventArgs e)
        {
            Invalidate(); // refreshes drawings on form 
        }

        private void LblResume_Click(object sender, EventArgs e)
        {
            ResumeGame(); // calls ResumeGame method
        }

        private void LblChangeDifficulty_Click(object sender, EventArgs e)
        {
            ChangeDifficulty(); // calls ChangeDifficulty method
        }

        private void LblQuit_Click(object sender, EventArgs e)
        {
            EndGame(); // calls EndGame method
        }
    }
}