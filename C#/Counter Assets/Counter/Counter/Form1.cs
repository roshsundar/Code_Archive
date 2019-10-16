using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class mainForm : Form
    {
        int count = 0;
        public mainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            count += 1;
            displayBox.Text = count.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
