using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInfo
{
    public partial class FrmPatientInfo : Form
    {
        public FrmPatientInfo()
        {
            InitializeComponent();
        }

        public string PatientName
        {
            get { return TxtName.Text; }
            set { TxtName.Text = value; }
        }

        public string Address
        {
            get { return TxtAddress.Text; }
            set { TxtAddress.Text = value; }
        }

        public string City
        {
            get { return TxtCity.Text; }
            set { TxtCity.Text = value; }
        }

        public string PostalCode
        {
            get { return TxtPostalCode.Text; }
            set { TxtPostalCode.Text = value; }
        }

        public string PhoneNumber
        {
            get { return TxtPhoneNumber.Text; }
            set { TxtPhoneNumber.Text = value; }
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
       
        }

        
        

    }
}