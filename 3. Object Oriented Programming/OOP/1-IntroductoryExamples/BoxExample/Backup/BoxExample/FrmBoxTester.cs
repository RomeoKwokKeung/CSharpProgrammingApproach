using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoxExample
{
    public partial class FrmBoxTester : Form
    {
        public FrmBoxTester()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Box b1 = new Box(2.5, 3.0, 5.0);
            MessageBox.Show("Width is " + b1.Wid + " Height is " + b1.Heigh + " Length is " + b1.Length);
            MessageBox.Show("The area is " + b1.area() + "\n" + "The volume is " + b1.volume());
           
            Box b2 = new Box(3.0);
            MessageBox.Show("Width is " + b2.Wid + " Height is " + b2.Heigh + " Length is " + b2.Length);
            MessageBox.Show("The area is " + b2.area() + "\n" + "The volume is " + b2.volume());
        }
    }
}