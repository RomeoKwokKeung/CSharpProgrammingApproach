using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Avoid_Armageddon
{
    public partial class FrmStartup : Form
    {
        public FrmStartup()
        {
            InitializeComponent();
        }

        int LocalMusic = 0;
        int LocalDifficulty = 1;

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDifficulty = 1;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDifficulty = 2;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocalDifficulty = 3;
        }

        private void insaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDifficulty = 4;
        }
    
        private void muteFXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocalMusic == 2)
                LocalMusic = 3;
            else LocalMusic = 1;
        }

        private void muteMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocalMusic == 1)
                LocalMusic = 3;
            else
                LocalMusic = 2;
        }

        private void unmuteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalMusic = 0;
        }

        private void difficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            GlobalVar.GblDifficulty = LocalDifficulty;
            GlobalVar.GblMusic = LocalMusic;
            Form x = new FrmArmageddon();
            x.Show();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help
            MessageBox.Show("In order to play, press start to start the weapons falling"
                + " and now attempt to dodge them!  You gain points every second you stay alive, and for every hitpoint of damage you"
                + " are able to dodge.  Damage is based on speeds, the faster it moves, the less damage you take!  You lose when you"
                + " take 25 points of damage, visible on the right of the screen on the circular symbol.  Try surviving as long as you"
                + " can! If you are still having trouble, try changing the difficulty."
                + " Good luck, and have fun!");
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A and D to move left and right.  W to shoot straight up.");
        }
    }
}
