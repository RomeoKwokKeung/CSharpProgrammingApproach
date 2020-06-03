using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class FrmVBinput : Form
    {
        public FrmVBinput()
        {
            InitializeComponent();
        }

        int mark1;
        int mark2;
        int mark3;
        double average;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            mark1 = Convert.ToInt32( Microsoft.VisualBasic.Interaction.InputBox("enter mark 1", "Averages", "", 200, 200));
            mark2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("enter mark 2", "Averages", "", 200, 200));
            mark3 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("enter mark 3", "Averages", "", 200, 200));

            average = (double) (mark1 + mark2 + mark3) / 3;

            MessageBox.Show("The average mark is \n" + average.ToString());
        }

        
    }
}