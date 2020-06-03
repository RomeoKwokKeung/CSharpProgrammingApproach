using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseProblem
{
    public partial class FrmMouseProblem : Form
    {
        public FrmMouseProblem()
        {
            InitializeComponent();
        }

        private void FrmMouseProblem_MouseMove(object sender, MouseEventArgs e)
        {
            PicOneA.Visible = true;
            PicOneB.Visible = false;
            PicTwoA.Visible = true;
            PicTwoB.Visible = false;
            PicThreeA.Visible = true;
            PicThreeB.Visible = false;
          
        }

        private void PicOneA_MouseMove(object sender, MouseEventArgs e)
        {
            PicOneB.Visible = true;
            PicOneA.Visible = false;
        }

        private void PicTwoA_MouseMove(object sender, MouseEventArgs e)
        {
            PicTwoB.Visible = true;
            PicTwoA.Visible = false;
        }

        private void PicThreeA_MouseMove(object sender, MouseEventArgs e)
        {
            PicThreeB.Visible = true;
            PicThreeA.Visible = false;
        }      

        private void PicOneB_MouseDown(object sender, MouseEventArgs e)
        {
            FrmOne one = new FrmOne();
            one.ShowDialog();
        }

        private void PicTwoB_MouseDown(object sender, MouseEventArgs e)
        {
            FrmTwo two = new FrmTwo();
            two.ShowDialog();
        }

        private void PicThreeB_MouseDown(object sender, MouseEventArgs e)
        {
            FrmThree three = new FrmThree();
            three.ShowDialog();
        }
    }
}