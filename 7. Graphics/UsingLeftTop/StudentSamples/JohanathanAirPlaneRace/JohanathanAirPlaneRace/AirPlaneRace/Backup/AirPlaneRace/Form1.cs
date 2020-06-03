using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirPlaneRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create arrays for images

        Image[] RedBarons = new Image[9];
        Image[] BlueRockets = new Image[5];

        //Intialize two counters (one for each)
        int count = 1;
        int count2 = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load images into arrays
            for (int i = 1; i <= 8; i++)
            {
                RedBarons[i] = Image.FromFile(Application.StartupPath + @"\Red" + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 4; i++)
            {
                BlueRockets[i] = Image.FromFile(Application.StartupPath + @"\Blue" + i.ToString() + ".gif");
            }
            //Initialize the first image, and make each image the right size
            RedBaron.Image = RedBarons[1];
            RedBaron.Size = RedBaron.Image.Size;

            BlueRocket.Image = BlueRockets[1];
            BlueRocket.Size = BlueRocket.Image.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //When the timer ticks the images will be run
            RedBaron.Image = RedBarons[count];
            count++;
            if (count > 8)
                // resets image back to the first one
                count = 1;

            BlueRocket.Image = BlueRockets[count2];
            count2++;
            if (count2 > 4)
                count2 = 1;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //Enables the timer
            timer2.Enabled = !timer2.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Cloud3.Visible = true;
            Cloud3.Left -= 17;
            Cloud2.Visible = true;
            Cloud2.Left -= 20;
            Cloud.Visible = true;
            Cloud.Left -= 15;
            //Enables random numbers
            Random r = new Random();

            //Assigns a random number to each image, this represents how far they 
            //will move for each tick of  the timer
            RedBaron.Left += r.Next(10,28);
            BlueRocket.Left += r.Next(10, 28);

            //if they both reach the end at the same time, it's a tie.
            //RedBaron needs (-9) because it was not cropped accurately.
            if (RedBaron.Left + RedBaron.Width - 9 >= this.Width && BlueRocket.Left + BlueRocket.Width >= this.Width)
            {        timer2.Enabled = false;
            MessageBox.Show("TIE!");
            }
                // if RedBaron gets there first, he wins
            else if (RedBaron.Left + RedBaron.Width-9 >= this.Width)
            {
                timer2.Enabled = false;
                MessageBox.Show("RedBaron Wins!");
            }
                //if bluerocket gets there first, he wins.
            else if (BlueRocket.Left + BlueRocket.Width >= this.Width)
            {
                timer2.Enabled = false;
                MessageBox.Show("Blue Rocket Wins!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resets positions
            Cloud.Visible = false;
            Cloud.Left = 850;
            Cloud2.Visible = false;
            Cloud2.Left = 850;
            Cloud3.Visible = false;
            Cloud3.Left = 850;
            RedBaron.Left = 100;
            BlueRocket.Left = 100;
        }


    }
}
