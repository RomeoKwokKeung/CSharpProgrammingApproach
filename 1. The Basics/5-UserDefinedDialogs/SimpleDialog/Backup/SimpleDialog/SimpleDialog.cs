using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDialog
{
    public partial class SimpleDialog : Form
    {
        public SimpleDialog()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you understand C#", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("You said Yes");
            }
            else if (r == DialogResult.No)
            {
                MessageBox.Show("You said No");
            }
        }

        
    }
}