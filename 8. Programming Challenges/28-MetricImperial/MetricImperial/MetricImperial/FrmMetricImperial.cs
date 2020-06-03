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

namespace MetricImperial
{
    public partial class FrmMetricImperial : Form
    {
        public FrmMetricImperial()
        {
            InitializeComponent();
        }

        int miles, yards, feet, inches;

        int tinches;//used as the initial value when we convert cm
                    //and then as the running current value as we 
                    //do each conversion

        private void BtnMetricImperial_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\metric.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    int metric = int.Parse(line);
                    MetricToImperial(metric);                                            
                }
            }
        }

        private void MetricToImperial(int m)
        {
            //start off and convert the total cm to total inches
            //then use inches as the basis of the conversion

            tinches = (int)(m / 2.54);

            miles = (int)(tinches / 63360);
            tinches = tinches % 63360;

            yards = (int)(tinches / 36);
            tinches = tinches % 36;

            feet = (int)(tinches / 12);

            inches = tinches % 12;

            TxtDisplay.Text += m.ToString() + "  " +  miles +  " mile(s), " + yards + " yard(s), " + feet + " foo(ee)t, " + inches + " inch(es)"+ Environment.NewLine;
        }
    }
}
