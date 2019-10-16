using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressBar_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            progressBar1.Value = 0;

            while (i <= 100)
            {
                progressBar1.Value = i;
                i++;
            }
        }
    }
}
