using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CardShark
{
    public partial class FrmCardShark : Form
    {
        public FrmCardShark()
        {
            InitializeComponent();
        }

        string[] lines;
        string [] results ;

        private void BtnShark_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\cards.txt";
            StreamReader read = new StreamReader(f);

            TxtDisplay.Clear();

           
            string WholeLine;

            int numCards=7;        
            int numLines;

            //counters for cards 1 to 5
            //not worried about anything else
            int flag1 = 0;
            int flag2 = 0;
            int flag3 = 0;
            int flag4 = 0;
            int flag5 = 0;

            int number;
               

            numLines = int.Parse(read.ReadLine());
            results = new string[numLines];   //array to store decisions either Bet or Fold 
                                              //displayed all the the same time after the loops
                        
            for (int x = 0; x < numLines; x++)
            {  
                   WholeLine = read.ReadLine();

                   lines = WholeLine.Split(' ');

                for (int y = 0; y < numCards; y++)
                {
                    number = int.Parse(lines[y]);

                    //remember we are after the best (worse) hand so the lower the 
                    //better ie this would be ideal 1 2 3 4 5
                    switch (number)
                    {
                        case 1:
                            flag1++;
                            break;
                        case 2:
                            flag2++;
                            break;
                        case 3:
                            flag3++;
                            break;
                        case 4:
                            flag4++;
                            break;
                        case 5:
                            flag5++;
                            break;
                    }

                }

                //looking for 1 2 3 4 5
                //anything else fold
                if ((flag1 >= 1) && (flag2 >= 1) && (flag3 >= 1) && (flag4 >= 1) && (flag5 >= 1))
                {
                    results[x] = "Bet";
                }
                else
                {
                    results[x] = "Fold";
                }

                //re-initialize counters for next game
                flag1 = 0;
                flag2 = 0;
                flag3 = 0;
                flag4 = 0;
                flag5 = 0;

            }

            for (int i=0;i<numLines;i++)
            {
               TxtDisplay.Text += results[i] + Environment.NewLine;
            }

            read.Close();   
           
        }
    }
}
