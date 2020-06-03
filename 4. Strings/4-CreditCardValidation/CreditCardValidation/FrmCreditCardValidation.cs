using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreditCardValidation
{
    public partial class FrmCreditCardValidation : Form
    {
        public FrmCreditCardValidation()
        {
            InitializeComponent();
        }

        // Account Number -> 8213267894
        // Last 9 digits  -> 213267894
        //                   2*2 + 2*1 + ..... 2*4 =84
        // If the first digit of the sum of the last nine digits doubled
        // is the check digit the account number is valid.
        // 1111111111 is valid

        private void BtnCredit_Click(object sender, EventArgs e)
        {
            string CreditCard;
            int Total9Digits = 0;

            do
            {
                CreditCard = Microsoft.VisualBasic.Interaction.InputBox("enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (CreditCard.Length != 10);

            for (int i = 1; i < CreditCard.Length; i++)
            {
                Total9Digits += int.Parse(CreditCard.Substring(i, 1)) * 2;
            }

            string FirstDigitOf9DigitTotal = Total9Digits.ToString().Substring(0, 1);
            string FirstDigitOfCreditCard = CreditCard.Substring(0, 1);

            if (FirstDigitOf9DigitTotal == FirstDigitOfCreditCard)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            //4417 1234 5678 9113
            //double every other digit from the right starting at second last one
            //add those answers to the digits that weren\t doubled
            //check if that result is divisible by 10

            string credit;

            do
            {
                credit = Microsoft.VisualBasic.Interaction.InputBox("Enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (credit.Length != 16);

            int total = 0;
            int doubled = 0;

            for (int i = 0; i <= 14; i += 2)
            {
                doubled = int.Parse(credit.Substring(i, 1)) * 2;
                if (doubled < 10)
                {
                    total = total + doubled;
                }
                //more than 10 digits
                else
                {
                    string d = doubled.ToString();
                    for (int x = 0; x < d.Length; x++)
                    {
                        total = total + int.Parse(d.Substring(x, 1));
                    }
                }
            }

            for (int i = 1; i <= 15; i += 2)
            {
                total = total + int.Parse(credit.Substring(i, 1));
            }

            if (total % 10 == 0)
            {
                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnSchneider_Click(object sender, EventArgs e)
        {
            string productCode;
            int total4Digits = 0;

            do
            {
                productCode = Microsoft.VisualBasic.Interaction.InputBox("Enter product code", "Code Validation", "", 200, 200);
            }
            while (productCode.Length != 5);

            int multiplier = 5;

            for (int i = 0; i <= 3; i++)
            {
                total4Digits = total4Digits + int.Parse(productCode.Substring(i, 1)) * multiplier;
                multiplier = multiplier - 1;
            }

            int remainder = total4Digits % 11;
            int calculatedCheck = 11 - remainder;

            string check = productCode.Substring(4, 1);
            string stringCalculatedCheck = calculatedCheck.ToString();

            if (check == stringCalculatedCheck)
            {
                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}