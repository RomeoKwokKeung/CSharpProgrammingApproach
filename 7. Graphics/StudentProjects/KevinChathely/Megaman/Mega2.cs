using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Megaman
{
    public partial class Mega2 : Form
    {
        public Mega2()
        {
            InitializeComponent();
        }
        Image[] xman = new Image[3];
        Image Backg = Image.FromFile(Application.StartupPath + @"\20.jpg");
        Image Backg2 = Image.FromFile(Application.StartupPath + @"\09.jpg");
        int pix = 20;
        private void Mega2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                xman[i] = Image.FromFile(Application.StartupPath + @"\xman" + i.ToString() + ".gif");
            }
            
        }

        private void Mega2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawStuff(g);
        }
        private void DrawStuff(Graphics g)
        {
            g.DrawImage(Backg2, 0, 0, ClientSize.Width , ClientSize.Height);
            g.DrawImage(Backg, ClientSize.Width / 4, ClientSize.Height / 7, ClientSize.Width / 2, ClientSize.Height / 2);
            pix = 20;
            Font font = new Font("Arial", 9, FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Font GameOverfont = new Font("AbcCursive", 40, FontStyle.Bold);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            g.DrawString("Turn Num Lock On Then move left and right with the A and D keys", font, yellowBrush, 200, 250);
            g.DrawString("Shoot with the L key", font, yellowBrush, 200, 270);
            g.DrawString("Jump with W key", font, yellowBrush, 200, 290);
            g.DrawString("Dr.Cain : Megaman there is big trouble!!", font, yellowBrush, 150, 310);
            g.DrawString("                :Crystal Bear & Tunnel Rhino have started causing trouble in sector A & C !!", font, yellowBrush, 150, 330);
            g.DrawString("                :Take Care of them for me, and beware of their ring leader", font, yellowBrush, 150, 350);
            g.DrawString("*Note* - Press Start before trying to change levels on the menu screen", font, yellowBrush, 150, 370);

            for (int i = 1; i <= 2; i++)
            {
                g.DrawImage(xman[i], pix, 80);                
                pix += 550;
            }
             
            g.DrawString("MEGAMAN X", GameOverfont, blueBrush, 150, 0);
            //g.DrawString("Press the Restart Button to Play Again", font, yellowBrush, ClientSize.Width / 2 - 100, ClientSize.Height / 2 + 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mega x = new Mega();
            x.ShowDialog();
        }
    }
}
