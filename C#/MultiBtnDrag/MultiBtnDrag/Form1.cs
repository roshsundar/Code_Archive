using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBtnDrag
{
    public partial class Form1 : Form
    {
        private Point MouseDownLocation;

        public Form1()
        {
            InitializeComponent();

            button1.MouseMove += ButtonMouseMove;
            button2.MouseMove += ButtonMouseMove;
            button3.MouseMove += ButtonMouseMove;

            button1.MouseDown += ButtonMouseDown;
            button2.MouseDown += ButtonMouseDown;
            button3.MouseDown += ButtonMouseDown;
        }


        public void ButtonMouseMove(object sender, MouseEventArgs e)
        {
            Button draggedButt = sender as Button;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggedButt.Left = e.X + draggedButt.Left - MouseDownLocation.X;
                draggedButt.Top = e.Y + draggedButt.Top - MouseDownLocation.Y;
            }
        }

        public void ButtonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
    }
}
