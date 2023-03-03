using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyModeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        Random random= new Random();
        Boolean isFirstClick = true;

        double euro, dollar;
        int day;
        private void startStopBtn_Click(object sender, EventArgs e)
        {
            euro = (double)euroEd.Value;
            dollar = (double)dollarEd.Value;          

            if (isFirstClick){
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(0, euro);
                chart1.Series[1].Points.AddXY(0, dollar);
                day = 1;
                isFirstClick = false;
                timer1.Start();
            }
            else
            {   
                isFirstClick = true;
                timer1.Stop();
            }                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            euro = euro * (1 + k * (random.NextDouble() - 0.5));
            dollar = dollar * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(day, euro);
            chart1.Series[1].Points.AddXY(day, dollar);
            day++;
                      
        }
    }
}
