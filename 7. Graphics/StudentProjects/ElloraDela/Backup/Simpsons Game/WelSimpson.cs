using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Simpsons_Game
{
    public partial class WelSimpson : Form
    {
        public WelSimpson()
        {
            InitializeComponent();
        }

        SoundPlayer opening = new SoundPlayer();
        
        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            Game x = new Game();
            x.Show();                       
        }

        private void WelSimpson_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\opening.wav";
        }

         
    }
}