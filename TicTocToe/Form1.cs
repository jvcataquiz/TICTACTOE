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
        int p1score = 0;
        int p2score = 0;
        bool playerGame ;
        bool player2;
        bool turn = true;
        int countturn = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            //from welcome.cs transfer here
            player1Prof.Text = Form2.setValueText1;
            p2OrCom.Text = Form2.setValueText2;
            //controller whether comp or 2player
            playerGame = Form2.playerController;
                if (playerGame)
            {
                player2 = true;
            }
            else
            {
                player2 = false;
                LabelPlayerone.Text = "X";
                labelPlayerTwo.Text = "O";
                labelturn.Visible = false;
                label2.Visible = false;
            }
            //for music bg location
            player.SoundLocation = "ticbg.wav";
            //function calling music bg
            player.Play();
        }
        //playerRandom
        private void players()
        {
            Random rnd1 = new Random();
            int randNum = rnd1.Next(1, 10);
            if (randNum % 2 == 0)
            {
                LabelPlayerone.Text = "X";
                labelPlayerTwo.Text = "O";
                //setting player name to labelturns
                if (LabelPlayerone.Text == "X")
                {
                    labelturn.Text = player1Prof.Text;
                    
                }
            }
            else
            {
                LabelPlayerone.Text = "O";
                labelPlayerTwo.Text = "X";
                //setting player name to turns
                if (labelPlayerTwo.Text == "X")
                {
                    labelturn.Text = p2OrCom.Text;
                }

            }
        }
        //Hover Events
        private void hover1to9(object sender, EventArgs e)
        {
            Button hover = (Button)sender;
            hover.BackColor = System.Drawing.Color.Gray;
            hover.ForeColor = System.Drawing.Color.Gray;
        }

        //Leave Events
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

        //Click Events
        private void btn1to9(object sender, EventArgs e)
        {
            //player2
            if (player2)
            {
                Button btnclick = (Button)sender;
                if (turn)
                {
                    btnclick.Text = "X";
                    countturn++;
                    if (LabelPlayerone.Text == "X")
                    {
                        labelturn.Text = p2OrCom.Text;
                    }
                    else
                    {
                        labelturn.Text = player1Prof.Text;
                    }
                }
                else
                {
                    btnclick.Text = "O";
                    if (LabelPlayerone.Text == "O")
                    {
                        labelturn.Text = p2OrCom.Text;
                    }
                    else
                    {
                        labelturn.Text = player1Prof.Text;
                    }
                }
                turn = !turn;
                btnclick.Enabled = false;
                winnerChecker();
            }
            //Computer
            else
            {
                Button combtnclick = (Button)sender;
                if (turn)
                {
                    combtnclick.Text = "X";
                    countturn++;
                }
                else
                {
                    combtnclick.Text = "O";
                }
                
                turn = !turn;
                combtnclick.Enabled = false;
                winnerChecker();
                if (!turn)
                {
                    computerplay();
                }
                    
            }
        }

       
        //GameChecker
        private void winnerChecker()
        {

            //hori
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text)&&(!btn1.Enabled))
            {
                labelturn.Text = "";
               if(btn1.Text == LabelPlayerone.Text)
                { 
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();

            }
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
            {
                labelturn.Text = "";
                if (btn4.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();

            }
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
            {
                labelturn.Text = "";
                if (btn7.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();

            }
            //vertical
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
            {
                labelturn.Text = "";
                if (btn1.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();
            }
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
            {
                labelturn.Text = "";
                if (btn2.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();

            }
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
            {
                labelturn.Text = "";
                if (btn3.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();

            }
            //diagonal
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
            {
                labelturn.Text = "";

                if (btn1.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();
            }
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
            {
                labelturn.Text = "";
                if (btn3.Text == LabelPlayerone.Text)
                {
                    MessageBox.Show("Congrats:" + player1Prof.Text);
                    p1score++;
                }
                else
                {
                    MessageBox.Show("Congrats:" + p2OrCom.Text);
                    p2score++;
                }
                btnNewgame.PerformClick();

            }
            else if (countturn == 5){
                labelturn.Text = "";
                MessageBox.Show("DRAW");
                btnNewgame.PerformClick();
            }


           
        }

        private void computerplay()
        {
           
            Button com_Move = null;

            com_Move = winandblock("O");
            if (com_Move == null)
            {
                com_Move = winandblock("X");
                if (com_Move == null)
                {
                    com_Move = corner();
                    if (com_Move == null)
                    {
                        com_Move = freespace();
                        if (com_Move == null)
                        {
                            btnNewgame.PerformClick();
                        }
                    }
                }

            }
            com_Move.PerformClick();
            if (com_Move.Enabled)
            {
                com_Move.BackColor = System.Drawing.Color.Black;
                com_Move.ForeColor = System.Drawing.Color.Black;

            }
            else
            {
                com_Move.BackColor = System.Drawing.Color.Gray;
                com_Move.ForeColor = System.Drawing.Color.Black;
            }

        }

        private Button winandblock(string xo)
        {

            //HORIZONTAL TESTS
            if ((btn1.Text == xo) && (btn2.Text == xo) && (btn3.Text == ""))
                return btn3;
            if ((btn2.Text == xo) && (btn3.Text == xo) && (btn1.Text == ""))
                return btn1;
            if ((btn1.Text == xo) && (btn3.Text == xo) && (btn2.Text == ""))
                return btn2;

            if ((btn4.Text == xo) && (btn5.Text == xo) && (btn6.Text == ""))
                return btn6;
            if ((btn5.Text == xo) && (btn6.Text == xo) && (btn4.Text == ""))
                return btn4;
            if ((btn4.Text == xo) && (btn6.Text == xo) && (btn5.Text == ""))
                return btn5;

            if ((btn7.Text == xo) && (btn8.Text == xo) && (btn9.Text == ""))
                return btn9;
            if ((btn8.Text == xo) && (btn9.Text == xo) && (btn7.Text == ""))
                return btn7;
            if ((btn7.Text == xo) && (btn9.Text == xo) && (btn8.Text == ""))
                return btn8;

            //VERTICAL TESTS
            if ((btn1.Text == xo) && (btn4.Text == xo) && (btn7.Text == ""))
                return btn7;
            if ((btn4.Text == xo) && (btn7.Text == xo) && (btn1.Text == ""))
                return btn1;
            if ((btn1.Text == xo) && (btn7.Text == xo) && (btn4.Text == ""))
                return btn4;

            if ((btn2.Text == xo) && (btn5.Text == xo) && (btn8.Text == ""))
                return btn8;
            if ((btn5.Text == xo) && (btn8.Text == xo) && (btn2.Text == ""))
                return btn2;
            if ((btn2.Text == xo) && (btn8.Text == xo) && (btn5.Text == ""))
                return btn5;

            if ((btn3.Text == xo) && (btn6.Text == xo) && (btn9.Text == ""))
                return btn9;
            if ((btn6.Text == xo) && (btn9.Text == xo) && (btn3.Text == ""))
                return btn3;
            if ((btn3.Text == xo) && (btn9.Text == xo) && (btn6.Text == ""))
                return btn6;

            //DIAGONAL TESTS
            if ((btn1.Text == xo) && (btn5.Text == xo) && (btn9.Text == ""))
                return btn9;
            if ((btn5.Text == xo) && (btn9.Text == xo) && (btn1.Text == ""))
                return btn1;
            if ((btn1.Text == xo) && (btn9.Text == xo) && (btn5.Text == ""))
                return btn5;

            if ((btn3.Text == xo) && (btn5.Text == xo) && (btn7.Text == ""))
                return btn7;
            if ((btn5.Text == xo) && (btn7.Text == xo) && (btn3.Text == ""))
                return btn3;
            if ((btn3.Text == xo) && (btn7.Text == xo) && (btn5.Text == ""))
                return btn5;

            return null;
        }

        private Button corner()
        {
          
            if (btn1.Text == "O")
            {
                if (btn3.Text == "")
                    return btn3;
                if (btn9.Text == "")
                    return btn9;
                if (btn7.Text == "")
                    return btn7;
            }

            if (btn3.Text == "O")
            {
                if (btn1.Text == "")
                    return btn1;
                if (btn9.Text == "")
                    return btn9;
                if (btn7.Text == "")
                    return btn7;
            }

            if (btn7.Text == "O")
            {
                if (btn1.Text == "")
                    return btn3;
                if (btn3.Text == "")
                    return btn3;
                if (btn9.Text == "")
                    return btn9;
            }

            if (btn9.Text == "O")
            {
                if (btn1.Text == "")
                    return btn3;
                if (btn3.Text == "")
                    return btn3;
                if (btn7.Text == "")
                    return btn7;
            }
            if (btn5.Text == "")
                return btn5;
            if (btn1.Text == "")
                return btn1;
            if (btn3.Text == "")
                return btn3;
            if (btn7.Text == "")
                return btn7;
            if (btn9.Text == "")
                return btn9;

            return null;
        }
        private Button freespace()
        {
            if (btn2.Text == "")
                return btn2;
            if (btn4.Text == "")
                return btn4;
            if (btn6.Text == "")
                return btn6;
            if (btn8.Text == "")
                return btn8;
            return null;
        }
        //NewgameBtn
        private void btnNewgame_Click(object sender, EventArgs e)
        {
            //enabling the all butto  for new games
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
            //setting the default color
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;
            //diplaying the score of the player
            labelp1score.Text = Convert.ToString(p1score);
            labelp2score.Text = Convert.ToString(p2score);
            turn = true;
            countturn = 0;
            if (player2 == true)
            {
                players();
            }

        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
          
            Form2 newform2 = new Form2();
            newform2.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (player2 == true)
            {
                players();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

    }
}
