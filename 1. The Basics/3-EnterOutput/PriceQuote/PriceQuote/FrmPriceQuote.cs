using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PriceQuote
{
    public partial class FrmPriceQuote : Form
    {
        public FrmPriceQuote()
        {
            InitializeComponent();
        }

        double BaseStar, BaseComet, BaseOrbit, PkgStandard, PkgDeluxe;
        double baseprice, packageprice, tradein,subtotal, salestax, totalprice;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPriceQuote_Load(object sender, EventArgs e)
        {
            BaseStar = 10500;
            BaseComet = 15500;
            BaseOrbit = 21000;
            PkgStandard = 2000;
            PkgDeluxe = 3000;

            baseprice = 0;
            packageprice = 0;
            TxtTradeIn.Text = "0";
                        
        }

        private void RdoStar_CheckedChanged(object sender, EventArgs e)
        {
            //you can't perform calculations on numbers that are formatted
            //that is why we use the second line to store the actual value
            LblBase.Text = BaseStar.ToString("c");
            baseprice = BaseStar;
        }

        private void RdoComet_CheckedChanged(object sender, EventArgs e)
        {
            LblBase.Text = BaseComet.ToString("c");
            baseprice = BaseComet;
        }

        private void RdoOrbit_CheckedChanged(object sender, EventArgs e)
        {
            LblBase.Text = BaseOrbit.ToString("c");
            baseprice = BaseOrbit;
        }

        private void RdoStandard_CheckedChanged(object sender, EventArgs e)
        {
            LblPackage.Text = PkgStandard.ToString("c");
            packageprice = PkgStandard;
        }

        private void RdoDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            LblPackage.Text = PkgDeluxe.ToString("c");
            packageprice = PkgDeluxe;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //need to clear radio buttons before
            //text boxes and labels
            //otherwise Base and Package prices
            //will remain on screen since radio buttons
            //still checked
            
            RdoComet.Checked=false;
            RdoOrbit.Checked=false;
            RdoStar.Checked=false;
            RdoStandard.Checked=false;
            RdoDeluxe.Checked=false;

            TxtName.Text = "";
            LblBase.Text = "";
            LblPackage.Text = "";
            TxtTradeIn.Text = "0";
            LblSubTotal.Text = "";
            LblSalesTax.Text= "";
            LblTotalPrice.Text = "";

            baseprice = 0;
            packageprice = 0;
                    
        }

        private void PicCompute_Click(object sender, EventArgs e)
        {
            //Note: during Parse calculations there cannot be a null value in a label/text box
            //that is why we initialized trade-in to zero

            tradein = double.Parse(TxtTradeIn.Text);
            
            subtotal=baseprice + packageprice - tradein;
            salestax= subtotal * 0.14;
            totalprice = subtotal + salestax;
                        
            TxtTradeIn.Text = tradein.ToString("c");
            LblSubTotal.Text = subtotal.ToString("c");
            LblSalesTax.Text = salestax.ToString("c");
            LblTotalPrice.Text = totalprice.ToString("c");           

        }

             

        
    }
}