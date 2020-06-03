using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media; //needed to play audio files

namespace Mario_Game
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //shows game form
            FrmGame x = new FrmGame(); 
            x.Show();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            //plays background music 
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\SoundFX\super.mp3";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            //shows highscores form
            FrmScores x = new FrmScores();
            x.Show();
        }
    }
}