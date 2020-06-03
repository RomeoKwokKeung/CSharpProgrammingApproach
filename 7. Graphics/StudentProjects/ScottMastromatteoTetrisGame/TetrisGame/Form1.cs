using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TetrisGame
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Image[] square = new Image[9];
        Image[] smallsquares = new Image[9];
        Image background;
        Image nextblock;
        Image gameoverbackground;
        Image formbackground;
        Image pausebackground;

        SoundPlayer spin = new SoundPlayer();
        SoundPlayer stick = new SoundPlayer();
        SoundPlayer clear = new SoundPlayer();
        SoundPlayer gmover = new SoundPlayer();

        int[,] filled = new int[11, 16];
        //0 = empty
        //1 = filled
        //2 = active block
        int[,] colour = new int[11, 16];
        int[] X = new int[5];
        int[] Y = new int[5];

        int nexttype;
        int type;
        int activecolour;
        int numberofblocks;
        int score;
        int seconds;
        int minutes;
        int lines;
        int level = 1;

        bool paused = false;
        bool over = true;
        bool activated = false;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            background = Image.FromFile(Application.StartupPath + @"\resources\tetrisbackground.png");
            gameoverbackground = Image.FromFile(Application.StartupPath + @"\resources\gameover.png");
            formbackground = Image.FromFile(Application.StartupPath + @"\resources\framebackground.png");
            pausebackground = Image.FromFile(Application.StartupPath + @"\resources\pausebackground.png");
            
            for (int x = 0; x <= 8; x++)
            {
                square[x] = Image.FromFile(Application.StartupPath + @"\resources\block" + x.ToString() + ".png");
                smallsquares[x] = Image.FromFile(Application.StartupPath + @"\resources\smallblock" + x.ToString() + ".png");
            }
            //block1 = grey
            //block1 = orange
            //block2 = blue
            //block3 = lightblue
            //block4 = purple
            //block5 = green
            //block6 = red
            //block7 = yellow
            //block8 = pink

            spin.SoundLocation = Application.StartupPath + @"\resources\spin.wav";
            stick.SoundLocation = Application.StartupPath + @"\resources\stick.wav";
            clear.SoundLocation = Application.StartupPath + @"\resources\clear.wav";
            gmover.SoundLocation = Application.StartupPath + @"\resources\gmover.wav";

            spin.LoadAsync();
            stick.LoadAsync();
            clear.LoadAsync();
            gmover.LoadAsync();

        }

        private void PauseGame()
        {
            if (paused == true)
            {
                TimFrame.Enabled = false;
                TimTime.Enabled = false;
            }
            else if (paused == false && over == false)
            {
                TimFrame.Enabled = true;
                TimTime.Enabled = false;
            }

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void Draw(Graphics g)
        {
            g.DrawImage(background, 0, 0, 500, 750);
            for (int y = 0; y <= 15; y++)
            {
                for (int x = 0; x <= 10; x++)
                {
                    if (filled[x, y] == 1 || filled[x, y] == 2)
                        g.DrawImage(square[colour[x, y]], x * 50, y * 50, 50, 50);
                }
            }

            if (activated)
                g.DrawImage(smallsquares[nexttype], 0, 0, smallsquares[nexttype].Width, smallsquares[nexttype].Height);

            if (over)
                g.DrawImage(gameoverbackground, 0, 0, 500, 750);

            if (paused && !over)
                g.DrawImage(pausebackground, 0, 0, 500, 750);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
            DetermineBlock();
            pnlGame.Refresh();
            TimFrame.Enabled = true;
            TimTime.Enabled = true;
        }

        private void DetermineBlock()
        {
            Random r = new Random();

            nexttype = r.Next(0, 9);
            if (nexttype == 8)
                nexttype = r.Next(0, 9);

            type = nexttype;

            activated = true;
            SetBlock();
            UpdateGame();
            pnlGame.Refresh();

        }

        private void SetBlock()
        {
            if (type == 0)
            {
                activecolour = 0;
                numberofblocks = 3;
                X[1] = 3;
                X[2] = 3;
                X[3] = 4;
                X[4] = 3;
                Y[1] = 0;
                Y[2] = 1;
                Y[3] = 0;
                Y[4] = 0;
            }
            else if (type == 1)
            {
                activecolour = 1;
                numberofblocks = 4;
                X[1] = 3;
                X[2] = 4;
                X[3] = 5;
                X[4] = 6;
                Y[1] = 0;
                Y[2] = 0;
                Y[3] = 0;
                Y[4] = 0;
            }
            else if (type == 2)
            {
                activecolour = 2;
                numberofblocks = 4;
                X[1] = 3;
                X[2] = 3;
                X[3] = 4;
                X[4] = 5;
                Y[1] = 1;
                Y[2] = 0;
                Y[3] = 0;
                Y[4] = 0;
            }
            else if (type == 3)
            {
                activecolour = 3;
                numberofblocks = 4;
                X[1] = 4;
                X[2] = 5;
                X[3] = 3;
                X[4] = 4;
                Y[1] = 0;
                Y[2] = 0;
                Y[3] = 1;
                Y[4] = 1;
            }
            else if (type == 4)
            {
                activecolour = 4;
                numberofblocks = 4;
                X[1] = 3;
                X[2] = 3;
                X[3] = 4;
                X[4] = 5;
                Y[1] = 0;
                Y[2] = 1;
                Y[3] = 1;
                Y[4] = 1;
            }
            else if (type == 5)
            {
                activecolour = 5;
                numberofblocks = 4;
                X[1] = 4;
                X[2] = 3;
                X[3] = 5;
                X[4] = 4;
                Y[1] = 0;
                Y[2] = 0;
                Y[3] = 1;
                Y[4] = 1;
            }
            else if (type == 6)
            {
                activecolour = 6;
                numberofblocks = 4;
                X[1] = 4;
                X[2] = 3;
                X[3] = 4;
                X[4] = 5;
                Y[1] = 0;
                Y[2] = 1;
                Y[3] = 1;
                Y[4] = 1;
            }
            else if (type == 7)
            {
                activecolour = 7;
                numberofblocks = 4;
                X[1] = 3;
                X[2] = 4;
                X[3] = 3;
                X[4] = 4;
                Y[1] = 0;
                Y[2] = 0;
                Y[3] = 1;
                Y[4] = 1;
            }
            else if (type == 8)
            {
                activecolour = 8;
                numberofblocks = 1;
                X[1] = 3;
                X[2] = 3;
                X[3] = 3;
                X[4] = 3;
                Y[1] = 0;
                Y[2] = 0;
                Y[3] = 0;
                Y[4] = 0;
            }
        }

        private void TimFrame_Tick(object sender, EventArgs e)
        {
            BlockFall();
            pnlGame.Refresh();
        }

        private void TimTime_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes <= 9 && seconds <= 9)
                TxtTime.Text = "0" + minutes.ToString() + ":0" + seconds.ToString();
            else if (minutes > 9 && seconds <= 9)
                TxtTime.Text = minutes.ToString() + ":0" + seconds.ToString();
            else if (minutes <= 9 && seconds > 9)
                TxtTime.Text = "0" + minutes.ToString() + ":" + seconds.ToString();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (activated)
            {
                if (!paused)
                {
                    if (e.KeyCode == Keys.A)
                    {
                        if (X[1] > 0 && X[2] > 0 && X[3] > 0 && X[4] > 0 && filled[X[1] - 1, Y[1]] != 1 && filled[X[2] - 1, Y[2]] != 1 && filled[X[3] - 1, Y[3]] != 1 && filled[X[4] - 1, Y[4]] != 1)
                        {
                            for (int t = 1; t <= numberofblocks; t++)
                            {
                                filled[X[t], Y[t]] = 0;
                                X[t]--;
                            }
                            UpdateGame();
                        }
                    }
                    if (e.KeyCode == Keys.D)
                    {
                        if (X[1] < 9 && X[2] < 9 && X[3] < 9 && X[4] < 9 && filled[X[1] + 1, Y[1]] != 1 && filled[X[2] + 1, Y[2]] != 1 && filled[X[3] + 1, Y[3]] != 1 && filled[X[4] + 1, Y[4]] != 1)
                        {
                            for (int t = 1; t <= numberofblocks; t++)
                            {
                                filled[X[t], Y[t]] = 0;
                                X[t]++;
                            }
                            UpdateGame();
                        }
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        if (type < 7)
                            TurnBlock();
                        else
                            spin.Play();
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        BlockFall();
                        score += 5;
                        UpdateScore();
                    }
                }
                if (e.KeyCode == Keys.P)
                {
                    paused = !paused;
                    PauseGame();
                    pnlGame.Refresh();
                }
            }
        }

        private void BlockFall()
        {
            if (filled[X[1], Y[1] + 1] != 1 && filled[X[2], Y[2] + 1] != 1 && filled[X[3], Y[3] + 1] != 1 && filled[X[4], Y[4] + 1] != 1 && Y[1] < 14 && Y[2] < 14 && Y[3] < 14 && Y[4] < 14)
            {
                for (int t = 1; t <= numberofblocks; t++)
                {
                    filled[X[t], Y[t]] = 0;
                    Y[t]++;
                }
                UpdateGame();
            }
            else
            {
                DeactivateBlock();
                LineCheck();
            }
        }

        private void TurnBlock()
        {
            Erase();

            int[] savedX = new int[5];
            int[] savedY = new int[5];

            for (int s = 1; s <= numberofblocks; s++)
            {
                savedX[s] = X[s];
                savedY[s] = Y[s];
            }

            for (int t = 1; t <= numberofblocks; t++)
            {
                int relativex = X[t] - X[1];
                int relativey = Y[t] - Y[1];

                Y[t] = Y[1] + relativex;
                X[t] = X[1] - relativey;

                if (X[t] > 9 || X[t] < 0 || Y[t] > 14 || Y[t] < 0 || filled[X[t], Y[t]] == 1)
                {
                    t = numberofblocks + 1;

                    for (int s = 1; s <= numberofblocks; s++)
                    {
                        X[s] = savedX[s];
                        Y[s] = savedY[s];
                    }
                }
            }

            spin.Play();
            UpdateGame();
            pnlGame.Refresh();
        }

        private void DeactivateBlock()
        {
            if (!over)
                stick.Play();
            activated = false;

            for (int t = 1; t <= numberofblocks; t++)
            {
                filled[X[t], Y[t]] = 1;
            }

            if (!over)
                DetermineBlock();
        }

        private void LineCheck()
        {
            int linescleared = 0;

            for (int y = 0; y <= 15; y++)
            {

                if (filled[0, y] == 1 && filled[1, y] == 1 && filled[2, y] == 1 && filled[3, y] == 1 && filled[4, y] == 1 && filled[5, y] == 1)
                {
                    if (filled[6, y] == 1 && filled[7, y] == 1 && filled[8, y] == 1 && filled[9, y] == 1)
                    {
                        for (int x = 0; x <= 10; x++)
                        {
                            filled[x, y] = 0;
                        }
                        MoveLinesDown(y);
                        linescleared++;
                        clear.Play();
                    }
                }
            }
            if (linescleared > 0)
            {
                score += Convert.ToInt32(Math.Pow(linescleared, 2) * 1000);
                UpdateScore();
                lines += linescleared;
                TxtLines.Text = lines.ToString();
                LevelUp();
            }
        }

        private void MoveLinesDown(int line)
        {
            for (int y = line - 1; y >= 0; y--)
            {
                for (int x = 0; x <= 10; x++)
                {
                    int previouscolour;

                    if (filled[x, y] == 1)
                    {
                        previouscolour = colour[x, y];
                        filled[x, y] = 0;
                        filled[x, y + 1] = 1;
                        colour[x, y + 1] = previouscolour;
                    }
                }
            }
        }

        private void UpdateScore()
        {
            TxtScore.Text = score.ToString();
        }

        private void LevelUp()
        {
            level = Convert.ToInt32(lines / 10 + 1);
            TxtLevel.Text = level.ToString();
            TimFrame.Interval = 1000 - (45 * (level - 1));
        }

        private void GameOverCheck()
        {
            for (int t = 1; t <= numberofblocks; t++)
            {
                if (filled[X[t], Y[t]] == 1)
                    GameOver();
            }
        }

        private void GameOver()
        {
            gmover.Play();
            over = true;
            pnlGame.Refresh();
            TimTime.Enabled = false;
            TimFrame.Enabled = false;

        }

        private void UpdateGame()
        {
            GameOverCheck();
            for (int t = 1; t <= numberofblocks; t++)
            {
                filled[X[t], Y[t]] = 2;
                colour[X[t], Y[t]] = activecolour;
            }
            pnlGame.Refresh();
        }

        private void Erase()
        {
            for (int t = 1; t <= numberofblocks; t++)
            {
                filled[X[t], Y[t]] = 0;
            }
        }

        private void Reset()
        {
            Random r = new Random();

            nexttype = r.Next(0, 9);
            if (nexttype == 8)
                nexttype = r.Next(0, 9);
            
            seconds = 0;
            minutes = 0;
            score = 0;
            level = 1;
            lines = 0;
            over = false;

            for (int y = 0; y <= 15; y++)
            {
                for (int x = 0; x <= 10; x++)
                {
                    filled[x, y] = 0;
                    colour[x, y] = 0;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            g.DrawImage(formbackground, 0, 0, 1024, 768);
            g.Dispose();
        }
    }

    public class PnlGame : Panel
    {
        public PnlGame()
            : base()
        {
            this.DoubleBuffered = true;
        }
    }
}