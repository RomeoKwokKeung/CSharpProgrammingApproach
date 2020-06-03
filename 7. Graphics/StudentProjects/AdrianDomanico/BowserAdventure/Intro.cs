using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BowserAdventure
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        SoundPlayer intro = new SoundPlayer();
        Main main = null;

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //makes the instruction box visible and not visible
            TxtInstructions.Text = "Intructions" + Environment.NewLine + "1. Press Spacebar to shoot flames from Bowser's mouth to burn the marios" + Environment.NewLine + "2. Burn as many marios until the time runs out" + Environment.NewLine + "3. Use the arrowkeys to move";
            TxtInstructions.Visible = !TxtInstructions.Visible;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Intro_Load(object sender, EventArgs e)
        {
            //plays the intro music
            intro.SoundLocation = Application.StartupPath + @"\intro.wav";
            intro.Load();

            intro.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
           //opens up the game form
            main = new Main();
            main.Show();
            
        }
    }
}