using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TicTacToeStart
{
    public partial class UserControl1: UserControl
    {
        int intXscore = 0;
        int intOscore = 0;
        string strXsymbol = "X";
        string strOsymbol = "O";
        bool blnOsTurn = true;

        public UserControl1()
        {
            InitializeComponent();
            currentturn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkWin()
        {
            //Handles matching sets

            /* Winning sets are:
             * Horizontal matches
             * R1C1, R1C2, R1C3
             * R2C1, R2C2, R2C3
             * R3C1, R3C2, R3C3
             * 
             * Cross matches
             * R1C1, R2C2, R3C3
             * R1C3, R2C2, R3C1
             * 
             * Vertical matches
             * R1C1, R2C1, R3C1
             * R1C2, R2C2, R3C2
             * R1C3, R2C3, R3C3
             */

            if ( btnR1C1.Text == "O" && btnR1C2.Text == "O" && btnR1C3.Text == "O" )
            {
                intOscore += 1;

                btnR1C1.FlatStyle = FlatStyle.Flat;
                btnR1C1.FlatAppearance.BorderColor = Color.Red;
                btnR1C1.FlatAppearance.BorderSize = 3;

                btnR1C2.FlatStyle = FlatStyle.Flat;
                btnR1C2.FlatAppearance.BorderColor = Color.Red;
                btnR1C2.FlatAppearance.BorderSize = 3;

                btnR1C3.FlatStyle = FlatStyle.Flat;
                btnR1C3.FlatAppearance.BorderColor = Color.Red;
                btnR1C3.FlatAppearance.BorderSize = 3;

                outOscore.Text = intOscore.ToString();

                disableMoves();
            } 
            else if ( btnR2C1.Text == "O" && btnR2C2.Text == "O" && btnR2C3.Text == "O")
            {
                intOscore += 1;

                btnR2C1.FlatStyle = FlatStyle.Flat;
                btnR2C1.FlatAppearance.BorderColor = Color.Red;
                btnR2C1.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR2C3.FlatStyle = FlatStyle.Flat;
                btnR2C3.FlatAppearance.BorderColor = Color.Red;
                btnR2C3.FlatAppearance.BorderSize = 3;

                outOscore.Text = intOscore.ToString();

                disableMoves();
            } 
            else if (btnR3C1.Text == "O" && btnR3C2.Text == "O" && btnR3C3.Text == "O") 
            {
                btnR3C1.FlatStyle = FlatStyle.Flat;
                btnR3C1.FlatAppearance.BorderColor = Color.Red;
                btnR3C1.FlatAppearance.BorderSize = 3;

                btnR3C2.FlatStyle = FlatStyle.Flat;
                btnR3C2.FlatAppearance.BorderColor = Color.Red;
                btnR3C2.FlatAppearance.BorderSize = 3;

                btnR3C3.FlatStyle = FlatStyle.Flat;
                btnR3C3.FlatAppearance.BorderColor = Color.Red;
                btnR3C3.FlatAppearance.BorderSize = 3;

                intOscore += 1;
                outOscore.Text = intOscore.ToString();

                disableMoves();
            } 
            else if (btnR1C1.Text == "O" && btnR2C2.Text == "O" && btnR3C3.Text == "O")
            {
                btnR1C1.FlatStyle = FlatStyle.Flat;
                btnR1C1.FlatAppearance.BorderColor = Color.Red;
                btnR1C1.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR3C3.FlatStyle = FlatStyle.Flat;
                btnR3C3.FlatAppearance.BorderColor = Color.Red;
                btnR3C3.FlatAppearance.BorderSize = 3;

                intOscore += 1;
                outOscore.Text = intOscore.ToString();

                disableMoves();
            } 
            else if (btnR1C3.Text == "O" && btnR2C2.Text == "O" && btnR3C1.Text == "O")
            {
                btnR1C3.FlatStyle = FlatStyle.Flat;
                btnR1C3.FlatAppearance.BorderColor = Color.Red;
                btnR1C3.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR3C1.FlatStyle = FlatStyle.Flat;
                btnR3C1.FlatAppearance.BorderColor = Color.Red;
                btnR3C1.FlatAppearance.BorderSize = 3;

                intOscore += 1;
                outOscore.Text = intOscore.ToString();

                disableMoves();
            } 
            else if (btnR1C1.Text == "O" && btnR2C1.Text == "O" && btnR3C1.Text == "O") 
            {
                btnR1C1.FlatStyle = FlatStyle.Flat;
                btnR1C1.FlatAppearance.BorderColor = Color.Red;
                btnR1C1.FlatAppearance.BorderSize = 3;

                btnR2C1.FlatStyle = FlatStyle.Flat;
                btnR2C1.FlatAppearance.BorderColor = Color.Red;
                btnR2C1.FlatAppearance.BorderSize = 3;

                btnR3C1.FlatStyle = FlatStyle.Flat;
                btnR3C1.FlatAppearance.BorderColor = Color.Red;
                btnR3C1.FlatAppearance.BorderSize = 3;

                intOscore += 1;
                outOscore.Text = intOscore.ToString();

                disableMoves();

            } 
            else if (btnR1C2.Text == "O" && btnR2C2.Text == "O" && btnR3C2.Text == "O")
            {
                btnR1C2.FlatStyle = FlatStyle.Flat;
                btnR1C2.FlatAppearance.BorderColor = Color.Red;
                btnR1C2.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR3C2.FlatStyle = FlatStyle.Flat;
                btnR3C2.FlatAppearance.BorderColor = Color.Red;
                btnR3C2.FlatAppearance.BorderSize = 3;

                intOscore += 1;
                outOscore.Text = intOscore.ToString();

                disableMoves();
            } 
            else if (btnR1C3.Text == "O" && btnR2C3.Text == "O" && btnR3C3.Text == "O")
            {
                btnR1C3.FlatStyle = FlatStyle.Flat;
                btnR1C3.FlatAppearance.BorderColor = Color.Red;
                btnR1C3.FlatAppearance.BorderSize = 3;

                btnR2C3.FlatStyle = FlatStyle.Flat;
                btnR2C3.FlatAppearance.BorderColor = Color.Red;
                btnR2C3.FlatAppearance.BorderSize = 3;

                btnR3C3.FlatStyle = FlatStyle.Flat;
                btnR3C3.FlatAppearance.BorderColor = Color.Red;
                btnR3C3.FlatAppearance.BorderSize = 3;

                intOscore += 1;
                outOscore.Text = intOscore.ToString();

                disableMoves();
            } else if (btnR1C1.Text == "X" && btnR1C2.Text == "X" && btnR1C3.Text == "X")
            {
                intXscore += 1;

                btnR1C1.FlatStyle = FlatStyle.Flat;
                btnR1C1.FlatAppearance.BorderColor = Color.Red;
                btnR1C1.FlatAppearance.BorderSize = 3;

                btnR1C2.FlatStyle = FlatStyle.Flat;
                btnR1C2.FlatAppearance.BorderColor = Color.Red;
                btnR1C2.FlatAppearance.BorderSize = 3;

                btnR1C3.FlatStyle = FlatStyle.Flat;
                btnR1C3.FlatAppearance.BorderColor = Color.Red;
                btnR1C3.FlatAppearance.BorderSize = 3;

                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
            else if (btnR2C1.Text == "X" && btnR2C2.Text == "X" && btnR2C3.Text == "X")
            {
                intXscore += 1;

                btnR2C1.FlatStyle = FlatStyle.Flat;
                btnR2C1.FlatAppearance.BorderColor = Color.Red;
                btnR2C1.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR2C3.FlatStyle = FlatStyle.Flat;
                btnR2C3.FlatAppearance.BorderColor = Color.Red;
                btnR2C3.FlatAppearance.BorderSize = 3;

                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
            else if (btnR3C1.Text == "X" && btnR3C2.Text == "X" && btnR3C3.Text == "X")
            {
                btnR3C1.FlatStyle = FlatStyle.Flat;
                btnR3C1.FlatAppearance.BorderColor = Color.Red;
                btnR3C1.FlatAppearance.BorderSize = 3;

                btnR3C2.FlatStyle = FlatStyle.Flat;
                btnR3C2.FlatAppearance.BorderColor = Color.Red;
                btnR3C2.FlatAppearance.BorderSize = 3;

                btnR3C3.FlatStyle = FlatStyle.Flat;
                btnR3C3.FlatAppearance.BorderColor = Color.Red;
                btnR3C3.FlatAppearance.BorderSize = 3;

                intXscore += 1;
                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
            else if (btnR1C1.Text == "X" && btnR2C2.Text == "X" && btnR3C3.Text == "X")
            {
                btnR1C1.FlatStyle = FlatStyle.Flat;
                btnR1C1.FlatAppearance.BorderColor = Color.Red;
                btnR1C1.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR3C3.FlatStyle = FlatStyle.Flat;
                btnR3C3.FlatAppearance.BorderColor = Color.Red;
                btnR3C3.FlatAppearance.BorderSize = 3;

                intXscore += 1;
                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
            else if (btnR1C3.Text == "X" && btnR2C2.Text == "X" && btnR3C1.Text == "X")
            {
                btnR1C3.FlatStyle = FlatStyle.Flat;
                btnR1C3.FlatAppearance.BorderColor = Color.Red;
                btnR1C3.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR3C1.FlatStyle = FlatStyle.Flat;
                btnR3C1.FlatAppearance.BorderColor = Color.Red;
                btnR3C1.FlatAppearance.BorderSize = 3;

                intXscore += 1;
                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
            else if (btnR1C1.Text == "X" && btnR2C1.Text == "X" && btnR3C1.Text == "X")
            {
                btnR1C1.FlatStyle = FlatStyle.Flat;
                btnR1C1.FlatAppearance.BorderColor = Color.Red;
                btnR1C1.FlatAppearance.BorderSize = 3;

                btnR2C1.FlatStyle = FlatStyle.Flat;
                btnR2C1.FlatAppearance.BorderColor = Color.Red;
                btnR2C1.FlatAppearance.BorderSize = 3;

                btnR3C1.FlatStyle = FlatStyle.Flat;
                btnR3C1.FlatAppearance.BorderColor = Color.Red;
                btnR3C1.FlatAppearance.BorderSize = 3;

                intXscore += 1;
                outXscore.Text = intXscore.ToString();

                disableMoves();

            }
            else if (btnR1C2.Text == "X" && btnR2C2.Text == "X" && btnR3C2.Text == "X")
            {
                btnR1C2.FlatStyle = FlatStyle.Flat;
                btnR1C2.FlatAppearance.BorderColor = Color.Red;
                btnR1C2.FlatAppearance.BorderSize = 3;

                btnR2C2.FlatStyle = FlatStyle.Flat;
                btnR2C2.FlatAppearance.BorderColor = Color.Red;
                btnR2C2.FlatAppearance.BorderSize = 3;

                btnR3C2.FlatStyle = FlatStyle.Flat;
                btnR3C2.FlatAppearance.BorderColor = Color.Red;
                btnR3C2.FlatAppearance.BorderSize = 3;

                intXscore += 1;
                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
            else if (btnR1C3.Text == "X" && btnR2C3.Text == "X" && btnR3C3.Text == "X")
            {
                btnR1C3.FlatStyle = FlatStyle.Flat;
                btnR1C3.FlatAppearance.BorderColor = Color.Red;
                btnR1C3.FlatAppearance.BorderSize = 3;

                btnR2C3.FlatStyle = FlatStyle.Flat;
                btnR2C3.FlatAppearance.BorderColor = Color.Red;
                btnR2C3.FlatAppearance.BorderSize = 3;

                btnR3C3.FlatStyle = FlatStyle.Flat;
                btnR3C3.FlatAppearance.BorderColor = Color.Red;
                btnR3C3.FlatAppearance.BorderSize = 3;

                intXscore += 1;
                outXscore.Text = intXscore.ToString();

                disableMoves();
            }
        }

        private void disableMoves()
        {
            //After a win/match, disable any further moves
            btnR1C1.Enabled = false;
            btnR1C2.Enabled = false;
            btnR1C3.Enabled = false;
            btnR2C1.Enabled = false;
            btnR2C2.Enabled = false;
            btnR2C3.Enabled = false;
            btnR3C1.Enabled = false;
            btnR3C2.Enabled = false;
            btnR3C3.Enabled = false;
        }

        private void flatStyleReset()
        {
            //Reset the board styles

            btnR1C1.FlatStyle = FlatStyle.Standard;
            btnR1C2.FlatStyle = FlatStyle.Standard;
            btnR1C3.FlatStyle = FlatStyle.Standard;
            btnR2C1.FlatStyle = FlatStyle.Standard;
            btnR2C2.FlatStyle = FlatStyle.Standard;
            btnR2C3.FlatStyle = FlatStyle.Standard;
            btnR3C1.FlatStyle = FlatStyle.Standard;
            btnR3C2.FlatStyle = FlatStyle.Standard;
            btnR3C3.FlatStyle = FlatStyle.Standard;
        }

        private void boardReset()
        {
            //Reset the board for a new game

            btnR1C1.Text = "";
            btnR1C1.Enabled = true;

            btnR1C2.Text = "";
            btnR1C2.Enabled = true;

            btnR1C3.Text = "";
            btnR1C3.Enabled = true;

            btnR2C1.Text = "";
            btnR2C1.Enabled = true;

            btnR2C2.Text = "";
            btnR2C2.Enabled = true;

            btnR2C3.Text = "";
            btnR2C3.Enabled = true;

            btnR3C1.Text = "";
            btnR3C1.Enabled = true;

            btnR3C2.Text = "";
            btnR3C2.Enabled = true;

            btnR3C3.Text = "";
            btnR3C3.Enabled = true;
        }

        //Board game handling starts here
        private void btnR1C1_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR1C1.Text = strOsymbol;
                blnOsTurn = false;
            } else
            {
                btnR1C1.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR1C1.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR1C2.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR1C2.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR1C2.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR1C3.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR1C3.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR1C3.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR2C1.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR2C1.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR2C1.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR2C2.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR2C2.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR2C2.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR2C3.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR2C3.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR2C3.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR3C1.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR3C1.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR3C1.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR3C2.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR3C2.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR3C2.Enabled = false;

            checkWin();
            currentturn();
        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            if (blnOsTurn == true)
            {
                btnR3C3.Text = strOsymbol;
                blnOsTurn = false;
            }
            else
            {
                btnR3C3.Text = strXsymbol;
                blnOsTurn = true;
            }

            btnR3C3.Enabled = false;

            checkWin();
            currentturn();
        }
        //Board game handling ends here

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset game. Resets game entirely including current score board.

            flatStyleReset();
            boardReset();
            currentturn();
            intOscore = 0;
            intXscore = 0;
            outOscore.Text = intOscore.ToString();
            outXscore.Text = intXscore.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Start a new game session
            flatStyleReset();
            boardReset();
            currentturn();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void currentturn()
        {
            //Check and show if current turn is for user X or user O
            if (blnOsTurn == true)
            {
                currentTurn.Text = strOsymbol;
            } else
            {
                currentTurn.Text = strXsymbol;
            }
        }
    }
}
