using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media; //moosic
namespace WindowsFormsApplication1
{
    public partial class FrmHowto : Form
    {
        public FrmHowto()
        {
            InitializeComponent();
        }
        Image back;
        Image HT;
        SoundPlayer done = new SoundPlayer();






        private void FrmHowto_Load(object sender, EventArgs e)
        {
            back = Image.FromFile(Application.StartupPath + @"\howto.jpg");
            HT = Image.FromFile(Application.StartupPath + @"\Play.gif");
            done.SoundLocation = Application.StartupPath + @"\close.wav";
            done.Load();

            this.Focus();

        }




        private void FrmHowto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                done.Play();
                this.Close();
            }
        }

        private void FrmHowto_Paint(object sender, PaintEventArgs e)
        {
            {
                Graphics g = e.Graphics;

                DrawStuff(g);

            }
        }
              private void DrawStuff(Graphics g)
        {
                  g.DrawImage(back, 0 , 0);
                  g.DrawImage(HT, 0, 0);
              







        }
    }
}
