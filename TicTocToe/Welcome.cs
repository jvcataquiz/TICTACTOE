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
 
    public partial class Form2 : Form
    {
        string versus;
        public static string setValueText1 ="";
        public static string setValueText2 = "";
        public static bool playerController;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        int tick = 0;
        public Form2()
        {
            InitializeComponent();
            player.SoundLocation = "ticbg.wav";
            player.Play();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDisplayP2.Text = "Enter Player2 Name:";
            textBoxDisplayP2.Enabled = true;
            versus = "player2";
            btnSubmit.Enabled = true;
        }

        private void rdbtnCom_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDisplayP2.Enabled = false;
            textBoxDisplayP2.Text = "Computer";
              versus = "com";
            btnSubmit.Enabled = true;
        }
        private void textBoxDisplayP1_TextChanged(object sender, EventArgs e)
        {
            textBoxDisplayP1.Text = textBoxDisplayP1.Text;
        }

        private void textBoxDisplayP2_TextChanged(object sender, EventArgs e)
        {
            textBoxDisplayP2.Text = textBoxDisplayP2.Text;
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxDisplayP1.Text.Length > 10 || textBoxDisplayP2.Text.Length > 10 || textBoxDisplayP2.Text == textBoxDisplayP1.Text)
            {
                labelalert.Visible = true;
            }
            else
            {

         
            if (versus == "player2")
            {
                setValueText1 =Convert.ToString(textBoxDisplayP1.Text);
                setValueText2 = Convert.ToString(textBoxDisplayP2.Text);
                playerController = rbtnPlayer2.Checked;
                this.Hide();
                Form1 form1 = new Form1(); 
                form1.Show();
            }
            else
            {
                setValueText1 = Convert.ToString(textBoxDisplayP1.Text);
                setValueText2 = Convert.ToString(textBoxDisplayP2.Text);
                playerController = rbtnPlayer2.Checked;
                versus = "com";
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textbox1Display(object sender, EventArgs e)
        {
            hoverlabel.Visible = true;
        }

        private void textbox2Display(object sender, EventArgs e)
        {
            hoverlabel2.Visible = true;
        }

        private void textbox2Displayleave(object sender, EventArgs e)
        {
            hoverlabel2.Visible = false;
        }

        private void textbox1Displayleave(object sender, EventArgs e)
        {
            hoverlabel.Visible = false;
        }

        int clck = 0;
        private void timerclock_Tick(object sender, EventArgs e)
        {
            clck++;
            if (clck == 1)
            {
                    this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.labelWelcome.Location = new System.Drawing.Point(165, 70);
            }
            if (clck == 2)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(160, 70);
            }
            if (clck == 3)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(155, 70);
            }
            if (clck == 4)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(150, 70);
            }
            if (clck == 5)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(145, 70);
            }
            if (clck == 6)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(140, 70);
            }
            if (clck == 7)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(135, 70);
            }
            if (clck == 8)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(130, 70);
            }
            if (clck == 9)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(125, 70);
            }
            if (clck == 10)
            {
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelWelcome.Location = new System.Drawing.Point(120, 70);
            }
            
            if (clck == 12)
            {
                labelWelcome.Visible = false;
                labelT.Visible = true;
                labeli.Visible = true;
                labelc.Visible = true;
                labelt2.Visible = true;
                labelA.Visible = true;
                labelc2.Visible = true;
                labelt3.Visible = true;
                labelo.Visible = true;
                labele.Visible = true;

                this.labelT.Location = new System.Drawing.Point(50, 29);
                this.labeli.Location = new System.Drawing.Point(208, 9);
                this.labelc.Location = new System.Drawing.Point(415, 15);
                this.labelt2.Location = new System.Drawing.Point(32, 185);
                this.labelA.Location = new System.Drawing.Point(189,155);

                this.labelc2.Location = new System.Drawing.Point(379,137);
                this.labelt3.Location = new System.Drawing.Point(60, 299);
                this.labelo.Location = new System.Drawing.Point(290, 320);
                this.labele.Location = new System.Drawing.Point(400, 290);
            }
            if (clck == 13)
            {
                this.labelT.Location = new System.Drawing.Point(73, 30);
                this.labeli.Location = new System.Drawing.Point(209, 15);
                this.labelc.Location = new System.Drawing.Point(402, 23);
                this.labelt2.Location = new System.Drawing.Point(43, 174);
                this.labelA.Location = new System.Drawing.Point(191, 150);

                this.labelc2.Location = new System.Drawing.Point(369, 134);
                this.labelt3.Location = new System.Drawing.Point(70, 290);
                this.labelo.Location = new System.Drawing.Point(280, 300);
                this.labele.Location = new System.Drawing.Point(380, 270);
            }
            if (clck == 14)
            {
                this.labelT.Location = new System.Drawing.Point(93, 34);
                this.labeli.Location = new System.Drawing.Point(210, 23);
                this.labelc.Location = new System.Drawing.Point(388, 35);
                this.labelt2.Location = new System.Drawing.Point(57, 165);
                this.labelA.Location = new System.Drawing.Point(193, 145);

                this.labelc2.Location = new System.Drawing.Point(359, 131);
                this.labelt3.Location = new System.Drawing.Point(80, 282);
                this.labelo.Location = new System.Drawing.Point(270, 280);
                this.labele.Location = new System.Drawing.Point(360, 260);
            }
            if (clck == 15)
            {
                this.labelT.Location = new System.Drawing.Point(102, 39);
                this.labeli.Location = new System.Drawing.Point(212, 27);
                this.labelc.Location = new System.Drawing.Point(374, 41);
                this.labelt2.Location = new System.Drawing.Point(75, 148);
                this.labelA.Location = new System.Drawing.Point(195, 140);

                this.labelc2.Location = new System.Drawing.Point(349, 128);
                this.labelt3.Location = new System.Drawing.Point(90, 270);
                this.labelo.Location = new System.Drawing.Point(260, 260);
                this.labele.Location = new System.Drawing.Point(340, 250);
            }
            if (clck == 16)
            {
                this.labelT.Location = new System.Drawing.Point(113, 42);
                this.labeli.Location = new System.Drawing.Point(214, 32);
                this.labelc.Location = new System.Drawing.Point(356, 48);
                this.labelt2.Location = new System.Drawing.Point(90, 136);
                this.labelA.Location = new System.Drawing.Point(197, 135);

                this.labelc2.Location = new System.Drawing.Point(339, 125);
                this.labelt3.Location = new System.Drawing.Point(100, 250);
                this.labelo.Location = new System.Drawing.Point(250, 230);
                this.labele.Location = new System.Drawing.Point(320, 220);
            }
            if (clck == 17)
            {
                this.labelT.Location = new System.Drawing.Point(121, 45);
                this.labeli.Location = new System.Drawing.Point(216, 43);
                this.labelc.Location = new System.Drawing.Point(342, 52);
                this.labelt2.Location = new System.Drawing.Point(101, 121);
                this.labelA.Location = new System.Drawing.Point(201, 125);

                this.labelc2.Location = new System.Drawing.Point(329, 120);
                this.labelt3.Location = new System.Drawing.Point(110, 230);
                this.labelo.Location = new System.Drawing.Point(240, 200);
                this.labele.Location = new System.Drawing.Point(300, 200);
            }
            if (clck == 18)
            {
                this.labelT.Location = new System.Drawing.Point(133, 53);
                this.labeli.Location = new System.Drawing.Point(217, 49);
                this.labelc.Location = new System.Drawing.Point(328, 57);
                this.labelt2.Location = new System.Drawing.Point(120, 115);
                this.labelA.Location = new System.Drawing.Point(205, 117);

                this.labelc2.Location = new System.Drawing.Point(319, 115);
                this.labelt3.Location = new System.Drawing.Point(119, 200);
                this.labelo.Location = new System.Drawing.Point(230, 180);
                this.labele.Location = new System.Drawing.Point(290, 180);
            }
            if (clck == 19)
            {
                this.labelT.Location = new System.Drawing.Point(137, 57);
                this.labeli.Location = new System.Drawing.Point(218, 57);
                this.labelc.Location = new System.Drawing.Point(300, 60);
                this.labelt2.Location = new System.Drawing.Point(132, 111);
                this.labelA.Location = new System.Drawing.Point(209, 113);

                this.labelc2.Location = new System.Drawing.Point(299, 113);
                this.labelt3.Location = new System.Drawing.Point(130, 180);
                this.labelo.Location = new System.Drawing.Point(220, 165);
                this.labele.Location = new System.Drawing.Point(285, 165);
            }
            if (clck == 20)
            {
                this.labelT.Location = new System.Drawing.Point(143, 62);
                this.labeli.Location = new System.Drawing.Point(219, 62);
                this.labelc.Location = new System.Drawing.Point(283, 62);
                this.labelt2.Location = new System.Drawing.Point(143, 108);
                this.labelA.Location = new System.Drawing.Point(213, 108);
                this.labelc2.Location = new System.Drawing.Point(283, 108);
                this.labelt3.Location = new System.Drawing.Point(143, 150);
                this.labelo.Location = new System.Drawing.Point(213, 150);
                this.labele.Location = new System.Drawing.Point(283, 150);
            }
            if (clck == 25)
            {
                this.labelWelcome.Location = new System.Drawing.Point(179, 69);
               
                this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelWelcome.Visible = true;
                labelT.Visible = false;
                labeli.Visible = false;
                labelc.Visible = false;
                labelt2.Visible = false;
                labelA.Visible = false;
                labelc2.Visible = false;
                labelt3.Visible = false;
                labelo.Visible = false;
                labele.Visible = false;
                clck = 0;
            }

            if (labelalert.Visible == true)
            {
                tick++;
                if (tick == 3)
                {
                    labelalert.Visible = false;
                    tick = 0;
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
