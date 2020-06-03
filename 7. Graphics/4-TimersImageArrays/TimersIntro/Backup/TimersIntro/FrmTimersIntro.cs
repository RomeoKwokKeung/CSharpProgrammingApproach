using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimersIntro
{
    public partial class FrmTimersIntro : Form
    {
        public FrmTimersIntro()
        {
            InitializeComponent();
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                BtnTimer.Text = "Begin";
                timer1.Enabled = false;
                timer2.Enabled=false;
            }
            else
            {
                BtnTimer.Text = "Stop";
                timer1.Enabled = true;
                timer2.Enabled = true;
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Console.Beep();
        }
    }
}