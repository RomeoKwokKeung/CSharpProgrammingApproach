using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseHoverIntro
{
    public partial class FrmMouseHover : Form
    {
        public FrmMouseHover()
        {
            InitializeComponent();
        }

        private void LblHover_MouseHover(object sender, EventArgs e)
        {
            LblHover.ForeColor = Color.Red;            
        }        

        private void LblHover_MouseLeave(object sender, EventArgs e)
        {
            LblHover.ForeColor = Color.Black;
            //FrmMouseHover_MouseMove could have been used here
            //but it was a little slow compared to using
            //MouseLeave
        }

        private void PicClosed_MouseMove(object sender, MouseEventArgs e)
        {
            PicOpen.Visible = true;
            PicClosed.Visible = false;            
        }

        private void FrmMouseHover_MouseMove(object sender, MouseEventArgs e)
        {
            PicOpen.Visible = false;
            PicClosed.Visible = true;
            LblMouseCoordinates.Text = Convert.ToString(e.X) + " " + Convert.ToString(e.Y);
        }

        private void LblHover_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show("You clicked me with the left button" + "\n" + "at postion " + e.X.ToString() + "," + e.Y.ToString());
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("You clicked me with the right button" + "\n" + "at postion " + e.X.ToString() + "," + e.Y.ToString());
                    break;
            }

            //note: the coordinates given when you click are 
            //RELATIVE to the control your in
            //ie. If you click near the top left corner of
            //this label the coordinates returned will be 
            //(1,1) for instance.
        }
        
    }
}