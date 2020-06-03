using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserControlledRepetition
{
    public partial class UserInput : Form
    {
        public UserInput()
        {
            InitializeComponent();
        }

        public string StudentMark
        {
            get { return TxtMark.Text; }
        }

        private void TxtMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            // checking for delete key ascii value 8
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}