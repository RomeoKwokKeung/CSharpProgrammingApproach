using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseProblem
{
    public partial class FrmTwo : Form
    {
        public FrmTwo()
        {
            InitializeComponent();
        }

        private void PicReturnA_MouseDown(object sender, MouseEventArgs e)
        {
            PicReturnA.Visible = false;
            PicReturnB.Visible = true;
        }

        private void PicReturnA_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}