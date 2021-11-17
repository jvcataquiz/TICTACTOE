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
  
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            
            textBoxDisplayP2.Enabled = true;
            versus = "player2";
        }

        private void rdbtnCom_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDisplayP2.Enabled = false;
            textBoxDisplayP2.Text = "Computer";
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

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (versus == "player2")
            {
                setValueText1 =Convert.ToString(textBoxDisplayP1.Text);
                setValueText2 = Convert.ToString(textBoxDisplayP2.Text);
                
                this.Hide();
                Form1 form1 = new Form1();
               
                form1.Show();
            }
            else
            {
                setValueText1 = Convert.ToString(textBoxDisplayP1.Text);
                setValueText2 = Convert.ToString(textBoxDisplayP2.Text);
                versus = "com";
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
