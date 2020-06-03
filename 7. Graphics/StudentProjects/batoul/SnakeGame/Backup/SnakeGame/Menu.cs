using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SnakeGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //player cant start game unless they type in a name
            if (txtName.Text != "")
            {
                Player.Name = txtName.Text;
                Form Game = new Game();
                Game.Show();
                this.Hide();
            }
            else
            {
                //prompts user to enter a name
                MessageBox.Show("Please enter a name", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UpdateHighScores();
        }

        public void UpdateHighScores()
        {
            //opens file path
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Snake.txt");
            if (File.Exists(path))
            {
                string line;
                StreamReader file = null;
                file = new StreamReader(path);
                string[] HighScores = new string[1000];
                int i = 0;
                while ((line = file.ReadLine()) != null)
                {
                    HighScores[i] = line;
                    i++;
                }

                //sorts highscores according to score
                Array.Sort(HighScores);

                //a wide range of number of names is given
                for (int j = 0; j <= 999; j++)
                {
                    if (HighScores[j] != null)
                    {
                        //types under what is already written in text box
                        txtHighScores.Text += Environment.NewLine + HighScores[j];
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit application
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //everything the player will need to know
            MessageBox.Show("-Type in a name, only alphabets are allowed, no numbers." + Environment.NewLine + "-Don't run the snake into the wall, or into itself; you die." + Environment.NewLine + "-Use your cursor keys: up, left, right, and down to move." + Environment.NewLine + "-Eat the red food (apple) to earn points and grow the snake." + Environment.NewLine + "-Every time you earn 100 points, you go up a level." + Environment.NewLine + "-Press spacebar to start the game, P to pause, and R to resume." + Environment.NewLine +  "-You can quit the game by pressing escape." + Environment.NewLine+ "-Your score will be saved on the menu screen in the highscores list.", "Rules for Play"); 
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            //the cursor key is auomatically set at the text box,
            //if you press enter, the program will perform(click) the play button
            if (e.KeyData == Keys.Enter)
            {
                btnPlay.PerformClick();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only alphabet and back space are allowed
            //other characters will not be typed
            int n = Convert.ToInt32(e.KeyChar);

            if ((n >= 97 && n <= 122) || (n == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
