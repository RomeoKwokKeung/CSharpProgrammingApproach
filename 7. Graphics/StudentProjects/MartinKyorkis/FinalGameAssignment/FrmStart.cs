//line1 - The variable used to load in the names from the data file

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FinalGameAssignment
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        FrmGame Game = new FrmGame();
        string line1;

        int highscorecounter;
        string winner;
        string[] winners = new string[100];

        private void FrmStart_Load(object sender, EventArgs e)
        {
            Wmp1.URL = Application.StartupPath + @"\rainy_day.mid"; //Starts up the BGM
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Wmp1.URL = Application.StartupPath + @"\rainy_day.mid";
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            if (!TxtHelp.Visible) //If the text box is not visible, it will make it visible and display this text.
            {

                TxtHelp.Visible = true;
                TxtHelp.Text += "Use WASD to move up, down, left, and right." + Environment.NewLine;
                TxtHelp.Text += "Click your mouse to shoot a fire ball." + Environment.NewLine ;
                TxtHelp.Text += "Defeat the boss monster before he defeats you!" + Environment.NewLine ;
                TxtHelp.Text += "Avoid his attacks, and watch your health bar." + Environment.NewLine ;
                TxtHelp.Text += "Press your CTRL key to shoot a normal attack. Press your space bar to shoot a powerful electric attack." + Environment.NewLine ;
                TxtHelp.Text += "Hitting the boss with your normal attack will increase your health and power a little bit." + Environment.NewLine ;
                TxtHelp.Text += "Press the H key to begin a healing process. Your power will drop, but your hitpoints will increase. You will be unable to perform an electric attack while healing.";
                TxtHelp.Text += "To hide this help box, please click the How to Play button again." + Environment.NewLine;
                
                TxtHelp.Text += "Good luck!";

            }
            else //if it is visible, it will clear and hide it.
            {
                TxtHelp.Visible = false;
                TxtHelp.Text = "";

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the game
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Wmp1.Ctlcontrols.stop();//Hides the starting form and starts up the game.
            this.Hide();
            Game.Show();
            TmrMusic.Enabled = false;
        }

        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Completely closes the whole program and any hidden forms.
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            
            string f = Application.StartupPath + @"\Winners.txt";
        
            StreamReader r = new StreamReader(f); //Opens up the highscores file

            if (TxtHelp.Visible == false) //Shows the Help text box and displays all highscore winners.
            {
                TxtHelp.Visible = true;
                TxtHelp.Text = "";

                do
                {
                    line1 = r.ReadLine();
                    TxtHelp.Text += line1 + Environment.NewLine;

                } while (line1 != null); //Keeps looping in all the names until the line in the datafile is a null.

            }
            else
            {
                TxtHelp.Visible = false; //Clears the textbox.
                TxtHelp.Text = "";
            }
            r.Close();
        }



    }
}
