
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisplayP1 = new System.Windows.Forms.TextBox();
            this.rbtnPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdbtnCom = new System.Windows.Forms.RadioButton();
            this.textBoxDisplayP2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hoverlabel = new System.Windows.Forms.Label();
            this.hoverlabel2 = new System.Windows.Forms.Label();
            this.labelalert = new System.Windows.Forms.Label();
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.labelT = new System.Windows.Forms.Label();
            this.labeli = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.labelc2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelt2 = new System.Windows.Forms.Label();
            this.label7e = new System.Windows.Forms.Label();
            this.labelo = new System.Windows.Forms.Label();
            this.labelt3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Aquamarine;
            this.labelWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Red;
            this.labelWelcome.Location = new System.Drawing.Point(179, 69);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(159, 42);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 239);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player1 Name:";
            // 
            // textBoxDisplayP1
            // 
            this.textBoxDisplayP1.Location = new System.Drawing.Point(174, 232);
            this.textBoxDisplayP1.MaxLength = 10;
            this.textBoxDisplayP1.Name = "textBoxDisplayP1";
            this.textBoxDisplayP1.Size = new System.Drawing.Size(254, 20);
            this.textBoxDisplayP1.TabIndex = 2;
            this.textBoxDisplayP1.TabStop = false;
            this.textBoxDisplayP1.Text = " \"Enter Player1 Name:\"";
            this.textBoxDisplayP1.TextChanged += new System.EventHandler(this.textBoxDisplayP1_TextChanged);
            this.textBoxDisplayP1.MouseLeave += new System.EventHandler(this.textbox1Displayleave);
            this.textBoxDisplayP1.MouseHover += new System.EventHandler(this.textbox1Display);
            // 
            // rbtnPlayer2
            // 
            this.rbtnPlayer2.AutoSize = true;
            this.rbtnPlayer2.Location = new System.Drawing.Point(68, 272);
            this.rbtnPlayer2.Name = "rbtnPlayer2";
            this.rbtnPlayer2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rbtnPlayer2.Size = new System.Drawing.Size(99, 17);
            this.rbtnPlayer2.TabIndex = 3;
            this.rbtnPlayer2.Text = "Player2 Name:";
            this.rbtnPlayer2.UseVisualStyleBackColor = true;
            this.rbtnPlayer2.CheckedChanged += new System.EventHandler(this.rbtnPlayer2_CheckedChanged);
            // 
            // rdbtnCom
            // 
            this.rdbtnCom.AutoSize = true;
            this.rdbtnCom.Location = new System.Drawing.Point(68, 306);
            this.rdbtnCom.Name = "rdbtnCom";
            this.rdbtnCom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rdbtnCom.Size = new System.Drawing.Size(78, 17);
            this.rdbtnCom.TabIndex = 4;
            this.rdbtnCom.Text = "Computer:";
            this.rdbtnCom.UseVisualStyleBackColor = true;
            this.rdbtnCom.CheckedChanged += new System.EventHandler(this.rdbtnCom_CheckedChanged);
            // 
            // textBoxDisplayP2
            // 
            this.textBoxDisplayP2.Enabled = false;
            this.textBoxDisplayP2.Location = new System.Drawing.Point(174, 271);
            this.textBoxDisplayP2.MaxLength = 10;
            this.textBoxDisplayP2.Name = "textBoxDisplayP2";
            this.textBoxDisplayP2.Size = new System.Drawing.Size(254, 20);
            this.textBoxDisplayP2.TabIndex = 5;
            this.textBoxDisplayP2.TabStop = false;
            this.textBoxDisplayP2.Text = " \"Enter Player2 Name:\"";
            this.textBoxDisplayP2.TextChanged += new System.EventHandler(this.textBoxDisplayP2_TextChanged);
            this.textBoxDisplayP2.MouseLeave += new System.EventHandler(this.textbox2Displayleave);
            this.textBoxDisplayP2.MouseHover += new System.EventHandler(this.textbox2Display);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(207, 352);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hoverlabel
            // 
            this.hoverlabel.AutoSize = true;
            this.hoverlabel.Location = new System.Drawing.Point(334, 216);
            this.hoverlabel.Name = "hoverlabel";
            this.hoverlabel.Size = new System.Drawing.Size(94, 13);
            this.hoverlabel.TabIndex = 9;
            this.hoverlabel.Text = "10 characters only";
            this.hoverlabel.Visible = false;
            // 
            // hoverlabel2
            // 
            this.hoverlabel2.AutoSize = true;
            this.hoverlabel2.Location = new System.Drawing.Point(334, 255);
            this.hoverlabel2.Name = "hoverlabel2";
            this.hoverlabel2.Size = new System.Drawing.Size(94, 13);
            this.hoverlabel2.TabIndex = 10;
            this.hoverlabel2.Text = "10 characters only";
            this.hoverlabel2.Visible = false;
            // 
            // labelalert
            // 
            this.labelalert.AutoSize = true;
            this.labelalert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelalert.ForeColor = System.Drawing.Color.DarkRed;
            this.labelalert.Location = new System.Drawing.Point(159, 329);
            this.labelalert.Name = "labelalert";
            this.labelalert.Size = new System.Drawing.Size(179, 20);
            this.labelalert.TabIndex = 11;
            this.labelalert.Text = "PlayerName is Invalid";
            this.labelalert.Visible = false;
            // 
            // timerclock
            // 
            this.timerclock.Enabled = true;
            this.timerclock.Interval = 1000;
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.BackColor = System.Drawing.Color.Aquamarine;
            this.labelT.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(22, 23);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(64, 46);
            this.labelT.TabIndex = 12;
            this.labelT.Text = "T";
            this.labelT.Visible = false;
            // 
            // labeli
            // 
            this.labeli.AutoSize = true;
            this.labeli.BackColor = System.Drawing.Color.Aquamarine;
            this.labeli.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeli.Location = new System.Drawing.Point(224, 23);
            this.labeli.Name = "labeli";
            this.labeli.Size = new System.Drawing.Size(53, 46);
            this.labeli.TabIndex = 13;
            this.labeli.Text = "I";
            this.labeli.Visible = false;
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.BackColor = System.Drawing.Color.Aquamarine;
            this.labelc.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.Location = new System.Drawing.Point(426, 9);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(67, 46);
            this.labelc.TabIndex = 14;
            this.labelc.Text = "C";
            this.labelc.Visible = false;
            // 
            // labelc2
            // 
            this.labelc2.AutoSize = true;
            this.labelc2.BackColor = System.Drawing.Color.Aquamarine;
            this.labelc2.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc2.Location = new System.Drawing.Point(389, 140);
            this.labelc2.Name = "labelc2";
            this.labelc2.Size = new System.Drawing.Size(67, 46);
            this.labelc2.TabIndex = 17;
            this.labelc2.Text = "C";
            this.labelc2.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Aquamarine;
            this.label.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(187, 166);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 46);
            this.label.TabIndex = 16;
            this.label.Text = "A";
            this.label.Visible = false;
            // 
            // labelt2
            // 
            this.labelt2.AutoSize = true;
            this.labelt2.BackColor = System.Drawing.Color.Aquamarine;
            this.labelt2.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelt2.Location = new System.Drawing.Point(22, 191);
            this.labelt2.Name = "labelt2";
            this.labelt2.Size = new System.Drawing.Size(64, 46);
            this.labelt2.TabIndex = 15;
            this.labelt2.Text = "T";
            this.labelt2.Visible = false;
            // 
            // label7e
            // 
            this.label7e.AutoSize = true;
            this.label7e.BackColor = System.Drawing.Color.Aquamarine;
            this.label7e.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7e.Location = new System.Drawing.Point(412, 309);
            this.label7e.Name = "label7e";
            this.label7e.Size = new System.Drawing.Size(72, 46);
            this.label7e.TabIndex = 20;
            this.label7e.Text = "E";
            this.label7e.Visible = false;
            // 
            // labelo
            // 
            this.labelo.AutoSize = true;
            this.labelo.BackColor = System.Drawing.Color.Aquamarine;
            this.labelo.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelo.Location = new System.Drawing.Point(258, 294);
            this.labelo.Name = "labelo";
            this.labelo.Size = new System.Drawing.Size(69, 46);
            this.labelo.TabIndex = 19;
            this.labelo.Text = "O";
            this.labelo.Visible = false;
            // 
            // labelt3
            // 
            this.labelt3.AutoSize = true;
            this.labelt3.BackColor = System.Drawing.Color.Aquamarine;
            this.labelt3.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelt3.Location = new System.Drawing.Point(32, 326);
            this.labelt3.Name = "labelt3";
            this.labelt3.Size = new System.Drawing.Size(64, 46);
            this.labelt3.TabIndex = 18;
            this.labelt3.Text = "T";
            this.labelt3.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 384);
            this.ControlBox = false;
            this.Controls.Add(this.label7e);
            this.Controls.Add(this.labelo);
            this.Controls.Add(this.labelt3);
            this.Controls.Add(this.labelc2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelt2);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.labeli);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labelalert);
            this.Controls.Add(this.hoverlabel2);
            this.Controls.Add(this.hoverlabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBoxDisplayP2);
            this.Controls.Add(this.rdbtnCom);
            this.Controls.Add(this.rbtnPlayer2);
            this.Controls.Add(this.textBoxDisplayP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICTACTOE";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hoverlabel;
        private System.Windows.Forms.Label hoverlabel2;
        private System.Windows.Forms.Label labelalert;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labeli;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label labelc2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelt2;
        private System.Windows.Forms.Label label7e;
        private System.Windows.Forms.Label labelo;
        private System.Windows.Forms.Label labelt3;
    }
}