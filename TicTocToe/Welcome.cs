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
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDisplayCom.Enabled = false;
            textBoxDisplayP2.Enabled = true;
            versus = "player2";
        }

        private void rdbtnCom_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDisplayP2.Enabled = false;
            textBoxDisplayCom.Enabled = true;
            versus = "com";
        }
        private void textBoxDisplayP1_TextChanged(object sender, EventArgs e)
        {
            textBoxDisplayP1.Text = textBoxDisplayP1.Text;
        }

        private void textBoxDisplayP2_TextChanged(object sender, EventArgs e)
        {
            textBoxDisplayP2.Text = textBoxDisplayP2.Text;
        }

        private void textBoxDisplayCom_TextChanged(object sender, EventArgs e)
        {
            textBoxDisplayCom.Text += textBoxDisplayCom.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (versus == "player2")
            {
               
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            
            
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
