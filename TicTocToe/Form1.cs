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
      bool playerGame ;
       
        bool player2;
      
        bool turn = true;
        int countturn = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            
            player1Prof.Text = Form2.setValueText1;
            p2OrCom.Text = Form2.setValueText2;
            player.SoundLocation = "ticbg.wav";
            playerGame = Form2.playerController;
                if (playerGame)
            {
                player2 = true;
            }
            else
            {
                player2 = false;
            }
            player.Play();


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
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";


            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;
            turn = true;
            countturn = 0;
            players();
        }

        


        private void player1Prof_Click(object sender, EventArgs e)
        {
          
        }


        

        private void p2OrCom_Click(object sender, EventArgs e)
        {
           
        }
       
        private void btn1to9(object sender, EventArgs e)
        {
            
            if (player2)
            {
                Button btnclick = (Button)sender;
                if (turn)
                {
                    btnclick.Text = "X";
                    countturn++;
                }
                else
                {
                    btnclick.Text = "O";
                }
                turn = !turn;
                btnclick.Enabled = false;
                winnerChecker();
               
            }
            else
            {
                Button combtnclick = (Button)sender;
                if (turn)
                {
                  
                    combtnclick.Text = LabelPlayerone.Text;
                    countturn++;
                }
                else
                {
                    combtnclick.Text = labelPlayerTwo.Text;
                    
                }
                
            }
        }

        private void hover1to9(object sender, EventArgs e)
        {
            Button hover = (Button)sender;
            hover.BackColor = System.Drawing.Color.Gray;
            hover.ForeColor = System.Drawing.Color.Gray;
        }

        private void leave1to9(object sender, EventArgs e)
        {
            Button leave = (Button)sender;
            if (leave.Enabled)
            {
                leave.BackColor = System.Drawing.Color.Black;
                leave.ForeColor = System.Drawing.Color.Black;

            }
            else
            {
                leave.BackColor = System.Drawing.Color.Gray;
                leave.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void players()
        {
            Random rnd1 = new Random();
            int randNum = rnd1.Next(1, 10);
            if (randNum % 2 == 0)
            {
                LabelPlayerone.Text =  "X";
                labelPlayerTwo.Text = "O";

            }
            else
            {
                LabelPlayerone.Text = "O";
                labelPlayerTwo.Text = "X";
            }
        }
        private void winnerChecker()
        {

            //hori
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text)&&(!btn1.Enabled))
            {
               if(btn1.Text == LabelPlayerone.Text)
                { 
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();

            }
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
            {
                if (btn4.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();

            }
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
            {
                if (btn7.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();

            }
            //vertical
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
            {
                if (btn1.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();
            }
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
            {
                if (btn2.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();

            }
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
            {
                if (btn3.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();

            }
            //diagonal
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
            {

                if (btn1.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();
            }
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
            {
                if (btn3.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                }
                btnNewgame.PerformClick();

            }
            else if (countturn == 5){
                MessageBox.Show("DRAW");
            }


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            players();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }
        private void computerPlay(bool comp)
        {
           
            
        }
    }
}
