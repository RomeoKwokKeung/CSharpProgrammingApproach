using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class FrmOne : Form
    {
        public FrmOne()
        {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            FrmTwo two = new FrmTwo();
            two.Show();
            
        }
    }
}