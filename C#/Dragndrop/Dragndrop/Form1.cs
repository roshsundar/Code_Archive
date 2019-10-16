using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragndrop
{
    public partial class Form1 : Form
    {
        private Point MouseDownLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                button1.Left = e.X + button1.Left - MouseDownLocation.X;
                button1.Top = e.Y + button1.Top - MouseDownLocation.Y;
            }


            if (button1.Bounds.IntersectsWith(Dropzone.Bounds))
            {
                button1.BringToFront();
                button1.Location = Dropzone.Location;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Dropzone_MouseUp(object sender, MouseEventArgs e)
        {
        }
    }
}
