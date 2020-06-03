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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
            Okbtn.Enabled = false;//disable Ok button
            usernametxt.Focus();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            LoginClass lclass=new LoginClass();

            string username1 = usernametxt.Text;
            string password1 = passwordtxt.Text;

            lclass.validateLogin(username1,password1);
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            Okbtn.Enabled = true;//enable Ok button
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            Okbtn.Enabled = true;//enable Ok button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }
    }
}
