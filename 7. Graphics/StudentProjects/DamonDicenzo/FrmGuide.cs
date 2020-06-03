using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //Added for double buffering

namespace GuitarHeroClone
{
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }

        //*************************************************//
        //               VARIABLE DICTIONARY               //
        //                                                 //
        // background - form background image              //
        // g - variable for graphics                       //
        // f - variable for FrmSong                        //
        //                                                 //
        //*************************************************//

        // loads in background image
        Image background = Image.FromFile(Application.StartupPath + @"\howto.jpg");

        private void Draw(Graphics g)
        {
            // draws background image on form
            g.DrawImage(background, 0, 0, 807, 576);
        }

        private void FrmGuide_Paint(object sender, PaintEventArgs e)
        {
            // draws graphics 
            Graphics g = e.Graphics;

            Draw(g);
        }

        private void PicContinue_Click(object sender, EventArgs e)
        {
            // hides this form and shows FrmSong
            Form f = new FrmSong();
            this.Hide();
            f.Show();
        }
    }
}