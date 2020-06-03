using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ccpizza
{
    public partial class FrmPizza : Form
    {
        public FrmPizza()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double small, medium, large;
        double smallsurcharge, mediumsurcharge, largesurcharge;
        double delivery,coupon;

        int items;
        
        double totalprice;

        private void FrmPizza_Load(object sender, EventArgs e)
        {
            RdoOne.Checked = true;
            RdoSmall.Checked = true;
            
            small = 5.65;
            medium = 7.25;
            large = 8.95;
            smallsurcharge = .85;
            mediumsurcharge = 1.05;
            largesurcharge = 2.00;

            delivery=2.00;
            coupon=1.00;

            items = 1;
            
            totalprice = 0;
        }

        private void RdoOne_CheckedChanged(object sender, EventArgs e)
        {
            items = 1;
        }

        private void RdoTwo_CheckedChanged(object sender, EventArgs e)
        {
            items = 2;
        }

        private void RdoThree_CheckedChanged(object sender, EventArgs e)
        {
            items = 3;
        }

        private void RdoFour_CheckedChanged(object sender, EventArgs e)
        {
            items = 4;
        }

        private void RdoDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            items = 6;
        }

        private void BtnCalculateNew_Click(object sender, EventArgs e)
        {
            items = 1;
            
            RdoSmall.Checked = true;
            RdoMedium.Checked = false;
            RdoLarge.Checked = false;
            
            RdoOne.Checked = true;
            RdoTwo.Checked = false;
            RdoThree.Checked = false;
            RdoFour.Checked = false;
            RdoDeluxe.Checked = false;

            ChkDelivery.Checked = false;
            ChkCoupon.Checked = false;

            totalprice = 0;

            LblAmountDue.Text = "";           

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (RdoSmall.Checked==true)
            {
                totalprice=small+items*smallsurcharge;
            }
            else if (RdoMedium.Checked==true)
            {
                totalprice=medium+items*mediumsurcharge;
            }
            else if (RdoLarge.Checked==true)
            {
                totalprice=large+items*largesurcharge;
            }
                
            if (ChkDelivery.Checked==true)
            {
                totalprice+=delivery;
            }
            if (ChkCoupon.Checked == true)
            {
                totalprice -= coupon;
            }

            LblAmountDue.Text = totalprice.ToString("c");
    

        }
    }
}