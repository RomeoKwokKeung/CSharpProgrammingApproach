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

namespace Craps
{
    public partial class FrmCraps : Form
    {
        public FrmCraps()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnCraps_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\craps.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;

            bool finished = false;
            int game = 1;

            while (!finished)
            {
                //read entire game 
                WholeLine = read.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    //pull apart each roll...first number is number of rolls to follow
                    lines = WholeLine.Split(' ');

                    int u = lines.Length;
                    int [] rolls = new int[u];

                    for (int y = 0; y < u; y++)
                    {
                        rolls[y] = int.Parse(lines[y]);                        
                    }

                    int th = rolls[0]; //number of rolls

                    //initialize game states
                    bool win = false;
                    bool extraRoll = false;
                    bool gameOver = false;

                    string output = "";

                    int index = 2; //point to the next roll after the first ... may not exist ... we will check later below (2nd while loop)
                    int point = rolls[1];

                    if (point==7 || point==11)
                    {
                        win = true;             //only win if you get 7 or 11 on FIRST roll
                        extraRoll = (th > 1);   //this will be false for the first data set ... it only had 1 roll
                        gameOver = true;        //but if you win right away and th is more than one you KEPT ROLLING! and you shouldn't have
                    }
                    else if (point==2|| point==3||point==12)
                    {
                        extraRoll = (th > 1);   
                        gameOver = true;        //lose right away if you get 2,3 or 12 on FIRST roll
                    }
                    else
                    {
                        while(!gameOver && index<=th) //if game isn't over from above and there are more rolls to check
                        {
                            if (rolls[index]==7)
                            {
                                gameOver = true;     //this time 7 isn't lucky game is over and you lost                           
                            }
                            else if (rolls[index]==point)
                            {
                                gameOver = true;    //here you matched the number of the magical POINT (the first roll) ... so you win
                                win = true;
                            }
                            index++;
                        }
                        if (index < th)         //while loop was exited either because gameOver is now true or index > th or both
                            extraRoll = true;   //Now if we exited because gameOver is true and there are still more rolls (index <th)
                    }                           //then player has rolled extra times and shouldn't have.

                    output = "#" + game + ": ";

                    if (!gameOver)
                    {
                        output += "Keep rolling";
                    }                        
                    else
                    {
                        if (win)
                            output += "Won";
                        else
                            output += "Lost";

                        if (extraRoll)
                            output += ", stop rolling!";
                        else
                            output += "!";
                    }

                    TxtDisplay.Text += output + Environment.NewLine;

                    game++;
                }
            }
        }
    }
}
