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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //Loads in the background image.
        Image background = Image.FromFile(Application.StartupPath + @"\main.jpg");

        private void button1_Click(object sender, EventArgs e)
        {
            //If you click "Begin", it creates the game form then opens it. 
            FrmGame x = new FrmGame();
            x.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            //Allows drawing.
            Graphics g = e.Graphics;

            //Goes to the "DrawStuff" method. 
            DrawStuff(g);
        }
        private void DrawStuff(Graphics g)
        {
            //Draw the background image at point 0,0. 
            g.DrawImage(background, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //If you click "Instructions" it creates the instruction form then opens it. 
            FrmInstruct x = new FrmInstruct();
            x.Show();
        }
    }
}
