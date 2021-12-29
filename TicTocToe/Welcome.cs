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
            this.labelT.Location = new System.Drawing.Point(143, 62);


           

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

        private void labeltic_Click(object sender, EventArgs e)
        {

        }

        private void labeltac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
