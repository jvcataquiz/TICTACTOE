
namespace TicTocToe
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisplayP1 = new System.Windows.Forms.TextBox();
            this.rbtnPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdbtnCom = new System.Windows.Forms.RadioButton();
            this.textBoxDisplayP2 = new System.Windows.Forms.TextBox();
            this.textBoxDisplayCom = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(215, 74);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(52, 13);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome";
            this.labelWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player1 Name:";
            // 
            // textBoxDisplayP1
            // 
            this.textBoxDisplayP1.Location = new System.Drawing.Point(174, 168);
            this.textBoxDisplayP1.Name = "textBoxDisplayP1";
            this.textBoxDisplayP1.Size = new System.Drawing.Size(254, 20);
            this.textBoxDisplayP1.TabIndex = 2;
            this.textBoxDisplayP1.Text = " \"Enter your Name\"";
            this.textBoxDisplayP1.TextChanged += new System.EventHandler(this.textBoxDisplayP1_TextChanged);
            // 
            // rbtnPlayer2
            // 
            this.rbtnPlayer2.AutoSize = true;
            this.rbtnPlayer2.Location = new System.Drawing.Point(68, 208);
            this.rbtnPlayer2.Name = "rbtnPlayer2";
            this.rbtnPlayer2.Size = new System.Drawing.Size(94, 17);
            this.rbtnPlayer2.TabIndex = 3;
            this.rbtnPlayer2.TabStop = true;
            this.rbtnPlayer2.Text = "Player2 Name:";
            this.rbtnPlayer2.UseVisualStyleBackColor = true;
            this.rbtnPlayer2.CheckedChanged += new System.EventHandler(this.rbtnPlayer2_CheckedChanged);
            // 
            // rdbtnCom
            // 
            this.rdbtnCom.AutoSize = true;
            this.rdbtnCom.Location = new System.Drawing.Point(68, 242);
            this.rdbtnCom.Name = "rdbtnCom";
            this.rdbtnCom.Size = new System.Drawing.Size(104, 17);
            this.rdbtnCom.TabIndex = 4;
            this.rdbtnCom.TabStop = true;
            this.rdbtnCom.Text = "Computer Name:";
            this.rdbtnCom.UseVisualStyleBackColor = true;
            this.rdbtnCom.CheckedChanged += new System.EventHandler(this.rdbtnCom_CheckedChanged);
            // 
            // textBoxDisplayP2
            // 
            this.textBoxDisplayP2.Location = new System.Drawing.Point(174, 207);
            this.textBoxDisplayP2.Name = "textBoxDisplayP2";
            this.textBoxDisplayP2.Size = new System.Drawing.Size(254, 20);
            this.textBoxDisplayP2.TabIndex = 5;
            this.textBoxDisplayP2.Text = " \"Enter your Name\"";
            this.textBoxDisplayP2.TextChanged += new System.EventHandler(this.textBoxDisplayP2_TextChanged);
            // 
            // textBoxDisplayCom
            // 
            this.textBoxDisplayCom.Location = new System.Drawing.Point(174, 241);
            this.textBoxDisplayCom.Name = "textBoxDisplayCom";
            this.textBoxDisplayCom.Size = new System.Drawing.Size(254, 20);
            this.textBoxDisplayCom.TabIndex = 6;
            this.textBoxDisplayCom.Text = " \"Enter your Name\"";
            this.textBoxDisplayCom.TextChanged += new System.EventHandler(this.textBoxDisplayCom_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(207, 288);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBoxDisplayCom);
            this.Controls.Add(this.textBoxDisplayP2);
            this.Controls.Add(this.rdbtnCom);
            this.Controls.Add(this.rbtnPlayer2);
            this.Controls.Add(this.textBoxDisplayP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDisplayP1;
        private System.Windows.Forms.RadioButton rbtnPlayer2;
        private System.Windows.Forms.RadioButton rdbtnCom;
        private System.Windows.Forms.TextBox textBoxDisplayP2;
        private System.Windows.Forms.TextBox textBoxDisplayCom;
        private System.Windows.Forms.Button btnSubmit;
    }
}