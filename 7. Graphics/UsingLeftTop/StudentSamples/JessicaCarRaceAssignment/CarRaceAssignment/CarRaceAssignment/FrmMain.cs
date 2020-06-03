using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRaceAssignment
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //to load in the black car animation images
        Image[] car = new Image[4];
        //counter for the car image to keep on loading in the pictures over and over again
        int carcount = 1;
        //to load in the bus animation images in an array for them to be remembered
        Image[] bus = new Image[11];
        //counter for the bus animation for all images to be loaded and so the computer will know when it reaches the end of the images
        int buscount = 1;
        //array for the traffic light image to appear
        Image[] light = new Image[4];
        //counter for the light
        int lightcount = 1;
        //random number generater
        Random r = new Random();





        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this loads in the car images from the data file
            for (int i = 1; i <= 3; i++)
            {
                car[i] = Image.FromFile(Application.StartupPath + @"\bcar" + i.ToString() + ".gif");                  
            }
            //this makes the first image to be the first car image
            picbcar.Image = car[1];
            //this will make the car image equal to the picture box size
            picbcar.Size=picbcar.Image.Size;

            //this loads in the bus image
            for (int i = 1; i <= 10; i++)
            {
                bus[i] = Image.FromFile(Application.StartupPath + @"\bus" + i.ToString() + ".gif");
            }
            //this makes the bus picture box start with the first bus image
            picbus.Image = bus[1];
            //this makes the bus fit inside the picture box frame without being cut off
            picbus.Size = picbus.Image.Size;

            //this will get the traffic light image
            for (int i = 1; i <= 3; i++)
            {
                light[i] = Image.FromFile(Application.StartupPath + @"\light" + i.ToString() + ".gif");
            }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this timer will load in the rest of the images for the car and the bus to make it look like the tires are moving
            //this will make the car imagae appear according to the count with the array number of the car represents the car image number
            picbcar.Image = car[carcount];
            carcount++;
            if (carcount > 3)
                carcount = 1;

            //this will make the bus images load in replacing the previous one
            picbus.Image = bus[buscount];
            buscount++;
            if (buscount > 10)
                buscount=1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            piclight.Visible = true;
            // this makes the red light appear when the button is clicked
            piclight.Image = light[1];
            piclight.Size = piclight.Image.Size;
            timer1.Enabled = true;          
            timer2.Enabled = true;
                                                                   
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this makes the yellow and green light appear
            lightcount++;
            if (lightcount < 4 && lightcount >= 2)
            {
                piclight.Image = light[lightcount];
                piclight.Size = piclight.Image.Size;

            }
            //if the count is not equal to 2 or 3, then the timer will be turned off and the stoplight will disappear
            else
            {
                lightcount = 1;
                timer2.Enabled = false;
                
                piclight.Visible = false;
                timer3.Enabled = true;                
            }           
       }

        private void timer3_Tick(object sender, EventArgs e)
        {                   
            int dir;                      
            //dir generates a random number for how fast the image will move
            dir = r.Next(8,15 );
            
            picbcar.Left += dir;
            //if the picture car box reaches the end, then the car will stop
            if (picbcar.Left + picbcar.Width >= this.Width)
            {
                timer3.Enabled = false;
                timer1.Enabled = false;                              
            }
          
            dir = r.Next(8, 15);
            picbus.Left += dir;
            //if the picture bus box reaches the end, then the bus will stop
            if (picbus.Left + picbus.Width >= this.Width)
            {
                timer3.Enabled = false;
                timer1.Enabled = false;
                
                
            }
            //the loc ints represent the value of pictures positions left and the width of the picture itself
            int piccloc = picbcar.Left + picbcar.Width;
            int picbloc = picbus.Left + picbus.Width;
            //if statements - if both the picbloc and piccloc are equal to the form width then it is a tie
            if (picbloc >= this.Width && piccloc >= this.Width)
            {
                MessageBox.Show("It's a tie!");
            }
            // if the car is equal to the form width then it wins
            else if (piccloc >= this.Width)
            {
                MessageBox.Show("The car wins!");
            }
            // if the bus is equal to the form width, then it wins   
            else if (picbloc >=this.Width)
            {
                 MessageBox.Show("The bus wins!");
            }                                                         
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //resets the picture boxes to the original position and turns on the timer 1 timer so they will be animated
            picbcar.Left =-2;
            picbcar.Top =55;

            picbus.Left =-2;
            picbus.Top = 165;

            timer1.Enabled = true; 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //this makes the cars stop moving when the stop button is pressed
            timer1.Enabled = false;
            timer3.Enabled = false;



        }


    }
}
