using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = x turn // false = O turn
        int numTurn = 0;
        int xWins = 0;
        int oWins = 0;
        int timeDraws = 0;

        /* -------Functions---------- */
        private void checkForWin()
        {
            bool isWinner = false;

            // Horizontal checking section
            if ((topLeft.Text == topCenter.Text)&&(topCenter.Text == topRight.Text)&&(!topLeft.Enabled))
            {
                isWinner = true;
            }
            else if ((centerLeft.Text == center.Text) && (center.Text == centerRight.Text) && (!centerLeft.Enabled))
            {
                isWinner = true;
            }
            else if ((bottomLeft.Text == bottomCenter.Text) && (bottomCenter.Text == bottomRight.Text) && (!bottomLeft.Enabled))
            {
                isWinner = true;
            }

            // Vertical checking section
            else if ((topLeft.Text == centerLeft.Text) && (centerLeft.Text == bottomLeft.Text) && (!topLeft.Enabled))
            {
                isWinner = true;
            }
            else if ((topCenter.Text == center.Text) && (center.Text == bottomCenter.Text) && (!topCenter.Enabled))
            {
                isWinner = true;
            }
            else if ((topRight.Text == centerRight.Text) && (centerRight.Text == bottomRight.Text) && (!topRight.Enabled))
            {
                isWinner = true;
            }

            // Diagonal checking section
            else if ((topLeft.Text == center.Text) && (center.Text == bottomRight.Text) && (!topLeft.Enabled))
            {
                isWinner = true;
            }
            else if ((topRight.Text == center.Text) && (center.Text == bottomLeft.Text) && (!topRight.Enabled))
            {
                isWinner = true;
            }


            if (isWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = "O";
                    oWins++;
                }
                else
                {
                    winner = "X";
                    xWins++;
                }
                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else
            {
                if (numTurn == 9)
                {
                    MessageBox.Show("Tis a draw", "Whaaat?");
                    timeDraws++;
                }
            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }

            }
            catch { }
        }
        /* -------End functions--------- */
        public Form1()
        {
            InitializeComponent();
        }
        /* ---------Menu controls---------- */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Roshan", "Tic Tac Toe About");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true; // reset the turn so that X can go first again
            numTurn = 0; // reset the turns to restart

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }

            }
            catch { }
        }
        private void currentTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                MessageBox.Show("The current turn is X's","Current Turn");
            }
            else
            {
                MessageBox.Show("The current turn is O's", "Current Turn");
            }
        }
        private void oWinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O has won " + oWins + " Times", "O Victories");
        }
        private void xWinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X has won " + xWins + " Times", "X Victories");
        }
        private void drawsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There have been draws " + timeDraws + " Times", "Draws");
        }
        /* -------End Menu Controls-------- */

        /* Button Controls */
        private void button_click(object sender, EventArgs e) // this event handles all the clicks for all the buttons. To do this, go to events(ligthning bolt) after clicking on a button and set a function name for the click event, then copy&paste the same function name into all the buttons' click events
        {
            Button b = (Button)sender; // the name of the button pressed is passed through sender, so we know what button specifically has been pressed

            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn; // not converts to opposite, therefore changing the turn 
            b.Enabled = false; // disable the button to avoid cheating
            numTurn++;
            checkForWin(); // call function that we made to check for a win
        }
        /* -------End Button Event handler--------- */
    }
}
