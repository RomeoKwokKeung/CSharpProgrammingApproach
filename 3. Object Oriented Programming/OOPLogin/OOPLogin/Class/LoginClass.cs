using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLogin
{
    public class LoginClass
    {
        public void validateLogin(string username1, string password1)
        {
            //validate login
           

            //vailidate empty textbox
            if (username1=="")
            {
                MessageBox.Show("Empty username field detected.\nPlease fillout all the fields.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else if (password1=="")
            {
                MessageBox.Show("Empty password field detected.\nPlease fillout all the fields.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                //end validate tetboxex
            else if (username1 == "Udemy" && password1 == "5432")
            {
                MessageBox.Show("Login Succeed", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {
                MessageBox.Show("Login failed", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
