using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoundsARound
{
    public partial class FrmSounds : Form
    {
        public FrmSounds()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //the individual prices
        double tape, record, cd;
        
        //the individual totals
        double tapetotal, recordtotal, cdtotal;
        double subtotal;
        
        //discountpercent (.10 or 0) discountamount is actual money value
        double discountpercent, discountamount;
        double total;
        
        private void FrmSounds_Load(object sender, EventArgs e)
        {
            tape = 9.99;
            record = 2.99;
            cd=15.99;

            //set totals initially to zero
            subtotal=0;
            discountamount=0;
            discountpercent=0;
            total=0;

            //sometimes C# gets mad if you don't have "SOMETHING"
            //in a text box when you perform a double.Parse()
            TxtTapeQuan.Text="0";
            TxtRecordQuan.Text="0";
            TxtCDQuantity.Text="0";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            discountpercent = .10;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            discountpercent = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //always do ALL your math FIRST
                      
            tapetotal = tape * double.Parse(TxtTapeQuan.Text);
            recordtotal = record * double.Parse(TxtRecordQuan.Text);
            cdtotal = cd * double.Parse(TxtCDQuantity.Text);

            subtotal = tapetotal + recordtotal + cdtotal;

            discountamount = subtotal * discountpercent;

            total = subtotal - discountamount;

            //then make it PRETTY

            LblTapeTot.Text = tapetotal.ToString("c");
            LblRecTot.Text = recordtotal.ToString("c");
            LblCdTot.Text = cdtotal.ToString("c");

            LblSub.Text=subtotal.ToString("c");
            LblDisc.Text=discountamount.ToString("c");
            LblTotal.Text = total.ToString("c");
        }
    }
}