using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasProblem
{
    public partial class FrmGas : Form
    {
        public FrmGas()
        {
            InitializeComponent();
        }

        private void BtnGas_Click(object sender, EventArgs e)
        {
            double bill = 0;
            double gas = 0;

            gas = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter gas used","","",400,400));

            if (gas <= 8)
            {
                bill = gas * .50;
            }
            else if (gas > 8)
            {
                bill = 8 * .50 + (gas - 8) * .30;
            }

            MessageBox.Show("Gas used " + gas.ToString() + "ccf" + '\n' + "Final Bill = " + bill.ToString("c")); 
        }
    }
}
