using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLogin
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lbldescription.Text = Convert.ToString("If you need any help with any of the exercises, or anything related with C#. Please contact me");
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
}
