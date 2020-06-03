using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxDemo
{
    public partial class FrmComboBoxDemo : Form
    {
        public FrmComboBoxDemo()
        {
            InitializeComponent();
        }

        private void VsbHours_Scroll(object sender, ScrollEventArgs e)
        {
            TxtHours.Text = Convert.ToString(VsbHours.Value);
        }

        private void FrmComboBoxDemo_Load(object sender, EventArgs e)
        {
            for (double i = 5.5; i <= 10; i += .5)
            {
                CboRate.Items.Add(i);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtHours.Text = "";
            TxtGrossPay.Text = "";
            VsbHours.Value = 0;
            CboRate.SelectedIndex = 0;
            CboEmployeeNames.SelectedIndex = 0;
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
           double gp  = Convert.ToDouble(CboRate.Text) * Convert.ToDouble(TxtHours.Text);
           TxtGrossPay.Text = gp.ToString("c");
        }


    }
}