using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animation1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }

        private void BtnDeveloper_Click(object sender, EventArgs e)
        {
            //display info about developer
            MessageBox.Show("Developer" + Environment.NewLine + Environment.NewLine + "This game was developed by Kyle Rooney for Mr. Chiarelli's Grade 11 Programming Class" + Environment.NewLine + Environment.NewLine + "Date Created: January 17th, 2007");
        }

        private void BtnHighScores_Click(object sender, EventArgs e)
        {
            //shows highscores form
            Form a = new FrmHighScores();

            this.Hide();
            a.Show();
        }

        private void BtnRace_Click(object sender, EventArgs e)
        {
            //shows animation form
            Form b = new FrmAnimation();

            this.Hide();
            b.Show();
        }

        private void BtnHowto_Click(object sender, EventArgs e)
        {
            //shows you how to play
            MessageBox.Show("How to Play: The object of the game is to dodge the oncoming traffic as well as detroy it by shooting at them. You will get points for how long you do not hit anything but you will also get points for destroying the vechiles coming at you. You will have 3 lives and have 60 seconds to see if you can get the high score! " + Environment.NewLine + Environment.NewLine + "Move Up: W key" + Environment.NewLine + "Move Down: S key" + Environment.NewLine + "To Shoot: Shiftkey" + Environment.NewLine + Environment.NewLine + "Scoring" + Environment.NewLine + Environment.NewLine + "Shooting an enemy: 100 points" + Environment.NewLine + "Dodging traffic: 2 points" + Environment.NewLine + "Hitting Wall: -1 point" + Environment.NewLine + "Getting Hit: -50 points");
        }
    }
}