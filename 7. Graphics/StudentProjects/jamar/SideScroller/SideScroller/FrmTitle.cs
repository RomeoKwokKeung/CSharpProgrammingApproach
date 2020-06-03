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
    public partial class FrmTitle : Form
    {
        public FrmTitle()
        {
            InitializeComponent();








            this.DoubleBuffered = true; ;
        }
        Image background;
        Image Help;
        Image LOZ;//titlezeldathing
        Image PS;
        Image quit;
        int x = 0;
        int y = 0;
        SoundPlayer start = new SoundPlayer();
        SoundPlayer cursor = new SoundPlayer();


        SoundPlayer hey = new SoundPlayer();
        SoundPlayer look = new SoundPlayer();
        SoundPlayer listen = new SoundPlayer();

      

        private void FrmTitle_Load(object sender, EventArgs e)
        {
            start.SoundLocation = Application.StartupPath + @"\start.wav";
            start.Load();

            cursor.SoundLocation = Application.StartupPath + @"\cursor.wav";
            cursor.Load();

            hey.SoundLocation = Application.StartupPath + @"\hey.wav";
            hey.Load();

            look.SoundLocation = Application.StartupPath + @"\look.wav";
            look.Load();

            listen.SoundLocation = Application.StartupPath + @"\listen.wav";
            listen.Load();

            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\title.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);

           
            background = Image.FromFile(Application.StartupPath + @"\title.jpg");

            LOZ = Image.FromFile(Application.StartupPath + @"\LOZ.png");

            PS = Image.FromFile(Application.StartupPath + @"\press enter.png");

            Help = Image.FromFile(Application.StartupPath + @"\W.gif");

            quit = Image.FromFile(Application.StartupPath + @"\quit.gif");
            this.Focus();

        }

        private void FrmTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);

        }


        private void DrawStuff(Graphics g)
        {

            if (x > 524 || x < -524)
                x = 0;

            if (y > 427 || y < -427)
                y = 0;



            for (int i = -524; i < 1048; i += 524)
            {
                for (int j = -427; j < 427; j += 427)
                {
                    g.DrawImage(background, x + i, y + j);

                }
               


                g.DrawImage(LOZ, 110, 50);
                g.DrawImage(PS, 105, 270);
                g.DrawImage(Help, 0, 0);
                g.DrawImage(quit, 400, 0);
            }
        }

        private void FrmTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
             
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                start.Play();
                Form1 two = new Form1();
                two.ShowDialog();
                this.Close();
            }
            else if (e.KeyCode == Keys.A)
            {
                hey.Play();
            }
            else if (e.KeyCode == Keys.W)
            {
                
                cursor.Play();
                FrmHowto three = new FrmHowto();
                three.ShowDialog();
            }
            else if (e.KeyCode == Keys.S)
            {
                look.Play();
            }
            else if (e.KeyCode == Keys.D)
            {
                listen.Play();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x -= 1;
            Invalidate();
        }
    }
}
