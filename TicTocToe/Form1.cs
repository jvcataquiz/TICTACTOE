using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTocToe
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        string operation;
        ////when button is clicked
     

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            operation = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Enabled = false;
            operation = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Enabled = false;
            operation = "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Enabled = false;
            operation = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Enabled = false;
            operation = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Enabled = false;
            operation = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Enabled = false;
            operation = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Enabled = false;
            operation = "9";
        }
        //when button is hovered
        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.BackColor = System.Drawing.Color.Gray;
        }

       
        private void btn2_MouseHover(object sender, EventArgs e)
        {
            btn2.BackColor = System.Drawing.Color.Gray;
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            btn3.BackColor = System.Drawing.Color.Gray;
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            btn4.BackColor = System.Drawing.Color.Gray;
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            btn5.BackColor = System.Drawing.Color.Gray;
        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            btn6.BackColor = System.Drawing.Color.Gray;
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            btn7.BackColor = System.Drawing.Color.Gray;
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            btn8.BackColor = System.Drawing.Color.Gray;
        }

        private void btn9_MouseHover(object sender, EventArgs e)
        {
            btn9.BackColor = System.Drawing.Color.Gray;
        }
        //when cursor leave in the top of the button
        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = System.Drawing.Color.Black;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = System.Drawing.Color.Black;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackColor = System.Drawing.Color.Black;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackColor = System.Drawing.Color.Black;
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btn5.BackColor = System.Drawing.Color.Black;
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            btn6.BackColor = System.Drawing.Color.Black;
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            btn7.BackColor = System.Drawing.Color.Black;
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            btn8.BackColor = System.Drawing.Color.Black;
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            btn9.BackColor = System.Drawing.Color.Black;
        }


        private void btnNewgame_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true; 
            btn9.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            operation = "1";
        }

        private void player1Prof_Click(object sender, EventArgs e)
        {
          
        }


        public void names(string playerP1,string p2OrComs)
        {
            playerP1 = player1Prof.Text;
            p2OrComs = p2OrCom.Text;
        }

        private void p2OrCom_Click(object sender, EventArgs e)
        {
           
        }
    }
}
