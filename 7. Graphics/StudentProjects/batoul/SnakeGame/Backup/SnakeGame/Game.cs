using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;    //needed for data files

namespace SnakeGame
{
    //Variable Dictionary:
    //randFood: for food to appear at random locations
    //snake: to draw snake
    //food: to draw food
    //left,right,up,down: to check if these keys are pressed
    //dirleft,dirright,dirup,dirleft: keeps track of the snakes direction
    //score: keep track of score
    //level: keep track of level
    //result: check if player wants to exit game
    //hit: plays sound when snake eats food

    public partial class Game : Form
    {
        Random randFood = new Random();
        Graphics g;
        Snake snake = new Snake();
        Food food;

        SoundPlayer hit = new SoundPlayer();

        //to keep track which way the snake is moving
        bool left = false;
        bool right = false;
        bool down = false;
        bool up = false;

        //keeps track of direction of snake
        bool dirleft = false;
        bool dirright = false;
        bool dirdown = false;
        bool dirup = false;

        int score = 0;
        int level = 1;

        public Game()
        {
            InitializeComponent();
            food = new Food(randFood);
            hit.SoundLocation = Application.StartupPath + @"\chime.wav";
            wmd.settings.setMode("loop", true);
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            food.drawFood(g);
            snake.drawSnake(g);
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //if you press escape, a msg box appears for confirmation
            //the game is paused
            if (e.KeyData == Keys.Escape)
            {
                Paused();
                DialogResult result = MessageBox.Show("Do you wish to quit?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    ShowMenu();
                }
                else
                {
                    Paused();
                }
            }
            //when you press space, the game begins, snake starts to move
            //music plays
            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                wmd.URL = Application.StartupPath + @"\music.mp3";
                spaceBarLabel.Text = "";
                down = false;
                up = false;
                right = true;
                left = false;

                dirdown = false;
                dirup = false;
                dirright = true;
                dirleft = false;
            }
            //snake will move down
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;

                dirdown = true;
                dirup = false;
                dirright = false;
                dirleft = false;
            }
            //snake will move up
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;

                dirdown = false;
                dirup = true;
                dirright = false;
                dirleft = false;
            }
            //snake will move to the right
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;

                dirdown = false;
                dirup = false;
                dirright = true;
                dirleft = false;
            }
            //snake will move to the left
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;

                dirdown = false;
                dirup = false;
                dirright = false;
                dirleft = true;
                
            }
            //the game will be pause, music will stop
            //snake stops moving
            if (e.KeyData == Keys.P)
            {
                Paused();
            }
            //game is resumed, snake starts moving again
            if (e.KeyData == Keys.R)
            {
                Resume();
            }
        }

        private void Paused()
        {
            timer1.Enabled = false;
            spaceBarLabel.Text = "Paused";
            spaceBarLabel.Left = this.Width / 2 - 30;
            wmd.Ctlcontrols.stop();
            down = false;
            up = false;
            right = false;
            left = false;
        }

        private void Resume()
        {
            timer1.Enabled = true;
            wmd.URL = Application.StartupPath + @"\music.mp3";
            spaceBarLabel.Text = "";
            //to check which direction the snake was moving and let it
            //resume from where it left off without changing directions
            if (dirdown == true)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }
            else if (dirup == true)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            else if (dirright == true)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }
            else if (dirleft == true)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //converts score and level to strings
            snakeScoreLabel.Text = Convert.ToString(score);
            snakeLevelLabel.Text = Convert.ToString(level);

            //snake will move depending which key is pressed
            if(down)
            { 
                snake.moveDown();
            }
            else if (up) 
            { 
                snake.moveUp(); 
            }
            else if (right) 
            { 
                snake.moveRight(); 
            }
            else if (left) 
            { 
                snake.moveLeft(); 
            }
            
            //if snake head hits food
            if (snake.SnakeRec[0].IntersectsWith(food.foodRec))
            {
                score += 10;
                //sound plays
                hit.Play();
                //progress bar will go up by 10's (range is 0-100)
                progressBar.Step = 10;
                progressBar.PerformStep();
                //for every 100 points
                if (score % 100 == 0)
                {
                    //level increases
                    level++;
                    //progress bar is reset
                    progressBar.Value = 0;
                }
                //snake gets longer
                snake.growSnake();
                //random location
                food.foodLocation(randFood);
            }

            collision();

            this.Invalidate();
        }

        public void collision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                //if snake head hits itself
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    restart();
                    UpdateScores();
                    ShowMenu();
                }
            }

            //if snake head hits wall (width)
            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 310)
            {
                restart();
                UpdateScores();
                ShowMenu();
            }

            //if snake head hits wall (height)
            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 260)
            {
                restart();
                UpdateScores();
                ShowMenu();
            }
        }

        public void restart()
        {
            //game stops because the player lost
            timer1.Enabled = false;
            wmd.Ctlcontrols.stop();
            MessageBox.Show("Snake is dead. You scored " + score + " in level " + level);
        }

        public void ShowMenu()
        {
            //this form closes, you go back to the menu
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        public void UpdateScores()
        {
            //where to locate the file
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Snake.txt");
            //what to write in the line
            string FinalScore = " " + score.ToString().PadLeft(2, '0') + "\t" + level.ToString() + "\t" + Player.Name;
            if(File.Exists(path))
            {
                StreamWriter sw;
                sw = File.AppendText(path);
                sw.WriteLine(FinalScore);
                sw.Close();
            }
            else
            {
                StreamWriter sw;
                //creates a new path
                sw = File.CreateText(path);
                sw.Close();
                sw = File.AppendText(path);
                //adds a line to the file with the name, level, and score of player
                sw.WriteLine(FinalScore);
                sw.Close();
            }
        }
    }
}
