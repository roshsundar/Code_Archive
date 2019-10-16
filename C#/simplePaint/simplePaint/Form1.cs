using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplePaint
{
    public partial class mainForm : Form
    {
        Graphics g;
        bool canPaint = false;

        int? prevX = null; // since int is non nullable, the ? allows it to be
        int? prevY = null;
         
        public mainForm()
        {
            InitializeComponent();
            g = drawingPanel.CreateGraphics();
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;

            prevX = null; // reset the prevX to allow it to repeat the process in the drawing command
            prevY = null; // reset the prevY to allow it to repeat the process in the drawing command
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint == true)
            {
                Pen drawPen = new Pen(color_btn.ForeColor, float.Parse(penSize_Entry.Text));
                g.DrawLine(drawPen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y)); // take the difference between the previous X/Y pos to the pos of mouse.
                                             // the ?? says that the previous position of the cursors X/Y will be prevX/Y unless its null then it will be the current
                prevX = e.X; // Set the current X as the previous X. This will happen for the duration of the draw, drawing many smnall line to make the larger one
                prevY = e.Y; // Set the current Y as the previous Y. This will happen for the duration of the draw, drawing many smnall line to make the larger one
            }
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK) // if the user selected a color
            {
                color_btn.ForeColor = cd.Color; // change the text color to the color selected to store that color val to be used in the drawing
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            g.Clear(drawingPanel.BackColor); // change the panel color back to the default given color
        }
    }
}
