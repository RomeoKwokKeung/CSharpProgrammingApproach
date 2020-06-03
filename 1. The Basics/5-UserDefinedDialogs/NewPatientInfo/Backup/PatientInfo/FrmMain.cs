using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInfo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGetPatientInfo_Click(object sender, EventArgs e)
        {
            FrmPatientInfo p = new FrmPatientInfo();
            if (p.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(p.PatientName + "\n" + p.Address + "\n" + p.City + "\n" + p.PostalCode + "\n" + p.PhoneNumber);
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            FrmPatientInfo p = new FrmPatientInfo();

            p.PatientName = "Tom";
            p.Address = "50 Main St.";
            p.City = "Hamilton";
            p.PostalCode = "L9X 2S2";
            p.PhoneNumber = "388-8958";

            if (p.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Back from Patient Form you pressed OK");
            }
            else
            {
                MessageBox.Show("Back from Patient Form you pressed Cancel");
            }
        }
    }
}