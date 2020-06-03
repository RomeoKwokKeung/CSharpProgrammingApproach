using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class FrmTwo : Form
    {
        public FrmTwo()
        {
            InitializeComponent();
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}