using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FINAL_GAME
{
    public partial class FrmInstruct : Form
    {
        public FrmInstruct()
        {
            InitializeComponent();
        }

        //Loads in the background image. 
        Image background = Image.FromFile(Application.StartupPath + @"\main.jpg");

        private void FormInstruct_Load(object sender, EventArgs e)
        {

        }

        private void FormInstruct_Paint(object sender, PaintEventArgs e)
        {
            //Allows drawing. 
            Graphics g = e.Graphics;

            //Goes to the "DrawStuff" method. 
            DrawStuff(g);
        }

        private void DrawStuff(Graphics g)
        {
            //Draws the background image at points 0,0. 
            g.DrawImage(background, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
