using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstOOPdemo
{
    public partial class FrmTester : Form
    {
        public FrmTester()
        {
            InitializeComponent();
        }

        private void BtnClassTest_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Make = "Toyota";
            c.Year = 2007;
            c.Display();

            Car r = new Car("Honda", 2006);
            r.Display();

            //calling a static method in the class
            Car.OtherDisplay();

            //This demo's inheritance
            //But you need to change private fields to protected 

            //MiniVan v = new MiniVan();
            //v.Make = "Chrylser";
            //v.Year = 1999;
            //v.Passengers = 7;

            //v.Display();

                                    
        }
    }
}