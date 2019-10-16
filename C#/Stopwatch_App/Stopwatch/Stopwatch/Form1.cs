using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int tenthSecond = 0;
        int second = 0;
        int minute = 0;
        int hour = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tenthSecond += 1;
            if(tenthSecond > 9)
            {
                tenthSecond = 0;
                second++;
            }
            if (second > 59)
            {
                second = 0;
                minute++;
            }
            if (minute > 59)
            {
                minute = 0;
                hour++;
            }
            label1.Text = hour + ":" + minute + ":" + second + ":" + tenthSecond;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tenthSecond = 0;
            second = 0;
            minute = 0;
            hour = 0;

            label1.Text = hour + ":" + minute + ":" + second + ":" + tenthSecond;

            timer1.Enabled = false;
        }
    }
}
