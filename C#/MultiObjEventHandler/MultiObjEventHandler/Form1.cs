using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiObjEventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += ButtonClicked;
            button2.Click += ButtonClicked;
            button3.Click += ButtonClicked;
        }
        public void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.Text = "I be Click";
        }
    }
}
