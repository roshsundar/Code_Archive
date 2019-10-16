using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorFlash
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Yellow) // 'this' is the same as mainform, using 'mainForm' instead of 'this' wont work
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
