using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_winforms
{
    public partial class Form1 : Form
    {
        private bool isX = true;
        private bool freeze = false;
        private bool x1 = false;
        private bool x2 = false;
        private bool x3 = false;
        private bool x4 = false;
        private bool x5 = false;
        private bool x6 = false;
        private bool x7 = false;
        private bool x8 = false;
        private bool x9 = false;
        private bool o1 = false;
        private bool o2 = false;
        private bool o3 = false;
        private bool o4 = false;
        private bool o5 = false;
        private bool o6 = false;
        private bool o7 = false;
        private bool o8 = false;
        private bool o9 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void check()
        {
            if (isX)
            {
                current.Text = "Current: X";
            }
            else
            {
                current.Text = "Current: O";
            }
            if (x1 && x2 && x3)
            {
                xWon();
            }
            else if (x4 && x5 && x6)
            {
                xWon();
            }
            else if (x7 && x8 && x9)
            {
                xWon();
            }
            else if (x1 && x5 && x9)
            {
                xWon();
            }
            else if (x3 && x5 && x7)
            {
                xWon();
            }
            else if (x3 && x6 && x9)
            {
                xWon();
            }
            else if (x1 && x4 && x7)
            {
                xWon();
            }
            else if (x2 && x5 && x8)
            {
                xWon();
            }
            else if (o1 && o2 && o3)
            {
                oWon();
            }
            else if (o4 && o5 && o6)
            {
                oWon();
            }
            else if (o7 && o8 && o9)
            {
                oWon();
            }
            else if (o1 && o5 && o9)
            {
                oWon();
            }
            else if (o3 && o5 && o7)
            {
                oWon();
            }
            else if (o3 && o6 && o9)
            {
                oWon();
            }
            else if (o1 && o4 && o7)
            {
                oWon();
            }
            else if (o2 && o5 && o8)
            {
                oWon();
            }
        }

        private void xWon()
        {
            MessageBox.Show("X won!", "Win", MessageBoxButtons.OK);
            current.Text = "X won!";
            freeze = true;
        }

        private void oWon()
        {
            MessageBox.Show("O won!", "Win", MessageBoxButtons.OK);
            current.Text = "O won!";
            freeze = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isX && !x1 && !o1 && !freeze)
            {
                button1.Text = "X";
                x1 = true;
                isX = false;
                check();
            }
            else if (!isX && !x1 && !o1 && !freeze)
            {
                button1.Text = "O";
                o1 = true;
                isX = true;
                check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isX && !x2 && !o2 && !freeze)
            {
                button2.Text = "X";
                x2 = true;
                isX = false;
                check();
            }
            else if (!isX && !x2 && !o2 && !freeze)
            {
                button2.Text = "O";
                o2 = true;
                isX = true;
                check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isX && !x3 && !o3 && !freeze)
            {
                button3.Text = "X";
                x3 = true;
                isX = false;
                check();
            }
            else if (!isX && !x3 && !o3 && !freeze)
            {
                button3.Text = "O";
                o3 = true;
                isX = true;
                check();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isX && !x4 && !o4 && !freeze)
            {
                button4.Text = "X";
                x4 = true;
                isX = false;
                check();
            }
            else if (!isX && !x4 && !o4 && !freeze)
            {
                button4.Text = "O";
                o4 = true;
                isX = true;
                check();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isX && !x5 && !o5 && !freeze)
            {
                button5.Text = "X";
                x5 = true;
                isX = false;
                check();
            }
            else if (!isX && !x5 && !o5 && !freeze)
            {
                button5.Text = "O";
                o5 = true;
                isX = true;
                check();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isX && !x6 && !o6 && !freeze)
            {
                button6.Text = "X";
                x6 = true;
                isX = false;
                check();
            }
            else if (!isX && !x6 && !o6 && !freeze)
            {
                button6.Text = "O";
                o6 = true;
                isX = true;
                check();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isX && !x7 && !o7 && !freeze)
            {
                button7.Text = "X";
                x7 = true;
                isX = false;
                check();
            }
            else if (!isX && !x7 && !o7 && !freeze)
            {
                button7.Text = "O";
                o7 = true;
                isX = true;
                check();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isX && !x8 && !o8 && !freeze)
            {
                button8.Text = "X";
                x8 = true;
                isX = false;
                check();
            }
            else if (!isX && !x8 && !o8 && !freeze)
            {
                button8.Text = "O";
                o8 = true;
                isX = true;
                check();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isX && !x9 && !o9 && !freeze)
            {
                button9.Text = "X";
                x9 = true;
                isX = false;
                check();
            }
            else if (!isX && !x9 && !o9 && !freeze)
            {
                button9.Text = "O";
                o9 = true;
                isX = true;
                check();
            }
        }

        private void resetGame()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
            current.Text = "Current: X";
            freeze = false;
            isX = true;
            x1 = false;
            x2 = false;
            x3 = false;
            x4 = false;
            x5 = false;
            x6 = false;
            x7 = false;
            x8 = false;
            x9 = false;
            o1 = false;
            o2 = false;
            o3 = false;
            o4 = false;
            o5 = false;
            o6 = false;
            o7 = false;
            o8 = false;
            o9 = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
