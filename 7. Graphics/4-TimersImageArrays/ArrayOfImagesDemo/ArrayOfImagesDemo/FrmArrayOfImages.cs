using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArrayOfImagesDemo
{
    public partial class FrmArrayOfImages : Form
    {
        public FrmArrayOfImages()
        {
            InitializeComponent();
        }

        Image[] signs = new Image[4];
        int count = 0;

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
        }

        private void FrmArrayOfImages_Load(object sender, EventArgs e)
        {
            signs[0] = PicSign1.Image;
            signs[1] = PicSign2.Image;
            signs[2] = PicSign3.Image;
            signs[3] = PicSign4.Image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicSign.Image = signs[count];
            count++;
            if (count>3)
                count=0;

        }
    }
}