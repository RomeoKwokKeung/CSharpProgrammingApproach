using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SortingIntroduction
{
    public partial class FrmSortingIntro : Form
    {
        public FrmSortingIntro()
        {
            InitializeComponent();
        }

        private void DataFile(int[] n, ref int c)
        {

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\numbers.txt";

            StreamReader r = new StreamReader(f);

            string line1;
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();
                
                if (line1 == null )
                {
                    finished = true;
                }
                else
                {
                    c++;
                    n[c] = Convert.ToInt32(line1);
                }

            }

            r.Close();

        }

        private void Display(string title,int[] n, int u)
        {
            
            LstInfo.Items.Add(title);
            for (int i = 1; i <= u; i++)
            {
                LstInfo.Items.Add(n[i].ToString());
            }
        }

        private void BtnBubble_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[100];
            int counter = 0;

            DataFile(numbers, ref counter);

            LstInfo.Items.Clear();
            Display("Original List",numbers, counter);

            BubbleSort(numbers, counter);
            Display("Sorted List", numbers, counter);

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            int number1, number2;

            number1=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Input","",200,200));
            number2=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Input","",200,200));

            if (number1 >= number2)
            {
                MessageBox.Show(number1.ToString() + "\n" + number2.ToString());
            }
            else
            {
                MessageBox.Show(number2.ToString() + "\n" + number1.ToString());
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            
            int number1, number2,number3;

            number1=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Input","",200,200));
            number2=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Input","",200,200));
            number3=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Input","",200,200));

            if (number1 > number2)
            {
                if (number1 < number3)
                {
                    MessageBox.Show(number3.ToString() + "\n" + number1.ToString() + "\n" + number2.ToString());
                }
                else
                {
                    if (number2 > number3)
                    {
                        MessageBox.Show(number1.ToString() + "\n" + number2.ToString() + "\n" + number3.ToString());
                    }
                    else
                    {
                        MessageBox.Show(number1.ToString() + "\n" + number3.ToString() + "\n" + number2.ToString());
                    }
                }
            }
            else
            {
                if (number3 > number2)
                {
                    MessageBox.Show(number3.ToString() + "\n" + number2.ToString() + "\n" + number1.ToString());
                }
                else
                {
                    if (number1 > number3)
                    {
                        MessageBox.Show(number2.ToString() + "\n" + number1.ToString() + "\n" + number3.ToString());
                    }
                    else
                    {
                        MessageBox.Show(number2.ToString() + "\n" + number3.ToString() + "\n" + number1.ToString());
                    }
                }
            }
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[100];
            int counter = 0;

            DataFile(numbers, ref counter);

            LstInfo.Items.Clear();
            Display("Original List",numbers, counter);
            
            //ReplacementSort method will return a sorted array
            Display("Sorted List",ReplacementSort(numbers, counter) , counter);

        }

        // note this method RETURNS an array
        private int [] ReplacementSort(int[] n, int u)
        {
            int[] sorted = new int[u + 1];
            int pos=0;

            for (int i=1;i<=u;i++)
            {
                int big = -1000;

                for (int j=1;j<=u;j++)
                {
                    if (n[j]>big)
                    {
                        big=n[j];
                        pos=j;
                    }
                }

                sorted[i]=big;
                n[pos]=-1000;
            }

            return sorted;
        }

        private void BubbleSort(int[] n, int u)
        {
            string flag;
            int temp;
            do
            {
                flag="yes";
                for (int k=1;k<=u-1;k++)
                {
                    if (n[k]>n[k+1])
                    {
                        temp=n[k];
                        n[k]=n[k+1];
                        n[k+1]=temp;
                        flag = "no";
                    }
                }
            }
            while(flag!="yes");  
        }
    }
}