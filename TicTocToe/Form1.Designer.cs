
namespace TicTocToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnNewgame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player1Prof = new System.Windows.Forms.Label();
            this.p2OrCom = new System.Windows.Forms.Label();
            this.LabelPlayerone = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGameMode = new System.Windows.Forms.GroupBox();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelp1score = new System.Windows.Forms.Label();
            this.labelp2score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelturn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxGameMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(133, 116);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(105, 105);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1to9);
            this.btn1.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn1.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn2.Location = new System.Drawing.Point(244, 116);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn2.Size = new System.Drawing.Size(105, 105);
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = false;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1to9);
            this.btn2.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn2.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn3.Location = new System.Drawing.Point(355, 116);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn3.Size = new System.Drawing.Size(105, 105);
            this.btn3.TabIndex = 2;
            this.btn3.TabStop = false;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn1to9);
            this.btn3.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn3.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn4.Location = new System.Drawing.Point(133, 227);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn4.Size = new System.Drawing.Size(105, 105);
            this.btn4.TabIndex = 3;
            this.btn4.TabStop = false;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn1to9);
            this.btn4.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn4.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn5.Location = new System.Drawing.Point(244, 227);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn5.Size = new System.Drawing.Size(105, 105);
            this.btn5.TabIndex = 4;
            this.btn5.TabStop = false;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn1to9);
            this.btn5.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn5.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn6.Location = new System.Drawing.Point(355, 227);
            this.btn6.Name = "btn6";
            this.btn6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn6.Size = new System.Drawing.Size(105, 105);
            this.btn6.TabIndex = 5;
            this.btn6.TabStop = false;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn1to9);
            this.btn6.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn6.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn7.Location = new System.Drawing.Point(133, 338);
            this.btn7.Name = "btn7";
            this.btn7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn7.Size = new System.Drawing.Size(105, 105);
            this.btn7.TabIndex = 6;
            this.btn7.TabStop = false;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn1to9);
            this.btn7.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn7.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn8.Location = new System.Drawing.Point(244, 338);
            this.btn8.Name = "btn8";
            this.btn8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn8.Size = new System.Drawing.Size(105, 105);
            this.btn8.TabIndex = 7;
            this.btn8.TabStop = false;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1to9);
            this.btn8.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn8.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60.75F);
            this.btn9.Location = new System.Drawing.Point(355, 339);
            this.btn9.Name = "btn9";
            this.btn9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn9.Size = new System.Drawing.Size(105, 105);
            this.btn9.TabIndex = 8;
            this.btn9.TabStop = false;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn1to9);
            this.btn9.MouseLeave += new System.EventHandler(this.leave1to9);
            this.btn9.MouseHover += new System.EventHandler(this.hover1to9);
            // 
            // btnNewgame
            // 
            this.btnNewgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.btnNewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNewgame.Location = new System.Drawing.Point(355, 450);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(105, 40);
            this.btnNewgame.TabIndex = 9;
            this.btnNewgame.TabStop = false;
            this.btnNewgame.Text = "New Game";
            this.btnNewgame.UseVisualStyleBackColor = false;
            this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBoxGameMode);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.labelp1score);
            this.panel1.Controls.Add(this.labelp2score);
            this.panel1.Controls.Add(this.btnNewgame);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 502);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelturn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.player1Prof);
            this.panel2.Controls.Add(this.p2OrCom);
            this.panel2.Controls.Add(this.LabelPlayerone);
            this.panel2.Controls.Add(this.labelPlayerTwo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 110);
            this.panel2.TabIndex = 21;
            // 
            // player1Prof
            // 
            this.player1Prof.AutoSize = true;
            this.player1Prof.BackColor = System.Drawing.Color.White;
            this.player1Prof.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Prof.ForeColor = System.Drawing.Color.OrangeRed;
            this.player1Prof.Location = new System.Drawing.Point(43, 45);
            this.player1Prof.Name = "player1Prof";
            this.player1Prof.Size = new System.Drawing.Size(90, 19);
            this.player1Prof.TabIndex = 10;
            this.player1Prof.Text = "nameofp1";
            // 
            // p2OrCom
            // 
            this.p2OrCom.AutoSize = true;
            this.p2OrCom.BackColor = System.Drawing.Color.White;
            this.p2OrCom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.p2OrCom.ForeColor = System.Drawing.Color.OrangeRed;
            this.p2OrCom.Location = new System.Drawing.Point(478, 45);
            this.p2OrCom.Name = "p2OrCom";
            this.p2OrCom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p2OrCom.Size = new System.Drawing.Size(70, 19);
            this.p2OrCom.TabIndex = 11;
            this.p2OrCom.Text = "nameof";
            this.p2OrCom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPlayerone
            // 
            this.LabelPlayerone.AutoSize = true;
            this.LabelPlayerone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.25F);
            this.LabelPlayerone.Location = new System.Drawing.Point(55, 70);
            this.LabelPlayerone.Name = "LabelPlayerone";
            this.LabelPlayerone.Size = new System.Drawing.Size(45, 29);
            this.LabelPlayerone.TabIndex = 14;
            this.LabelPlayerone.Text = "P1";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.25F);
            this.labelPlayerTwo.Location = new System.Drawing.Point(494, 72);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(45, 29);
            this.labelPlayerTwo.TabIndex = 13;
            this.labelPlayerTwo.Text = "P2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(226, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "TICTACTOE";
            // 
            // groupBoxGameMode
            // 
            this.groupBoxGameMode.Controls.Add(this.radioButtonHard);
            this.groupBoxGameMode.Controls.Add(this.radioButtonMedium);
            this.groupBoxGameMode.Controls.Add(this.radioButtonEasy);
            this.groupBoxGameMode.Location = new System.Drawing.Point(12, 398);
            this.groupBoxGameMode.Name = "groupBoxGameMode";
            this.groupBoxGameMode.Size = new System.Drawing.Size(105, 92);
            this.groupBoxGameMode.TabIndex = 20;
            this.groupBoxGameMode.TabStop = false;
            this.groupBoxGameMode.Text = "Computer Mode:";
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(6, 63);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(48, 17);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(6, 43);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Checked = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(6, 23);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(48, 17);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonHome.Location = new System.Drawing.Point(482, 450);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(105, 40);
            this.buttonHome.TabIndex = 19;
            this.buttonHome.TabStop = false;
            this.buttonHome.Text = "HOME";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelp1score
            // 
            this.labelp1score.AutoSize = true;
            this.labelp1score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelp1score.Location = new System.Drawing.Point(56, 136);
            this.labelp1score.Name = "labelp1score";
            this.labelp1score.Size = new System.Drawing.Size(24, 25);
            this.labelp1score.TabIndex = 18;
            this.labelp1score.Text = "0";
            // 
            // labelp2score
            // 
            this.labelp2score.AutoSize = true;
            this.labelp2score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelp2score.Location = new System.Drawing.Point(503, 136);
            this.labelp2score.Name = "labelp2score";
            this.labelp2score.Size = new System.Drawing.Size(24, 25);
            this.labelp2score.TabIndex = 17;
            this.labelp2score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Turns";
            // 
            // labelturn
            // 
            this.labelturn.AutoSize = true;
            this.labelturn.BackColor = System.Drawing.Color.White;
            this.labelturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelturn.ForeColor = System.Drawing.Color.Red;
            this.labelturn.Location = new System.Drawing.Point(237, 75);
            this.labelturn.Name = "labelturn";
            this.labelturn.Size = new System.Drawing.Size(112, 24);
            this.labelturn.TabIndex = 23;
            this.labelturn.Text = "PlayerTurn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 502);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxGameMode.ResumeLayout(false);
            this.groupBoxGameMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnNewgame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelp2score;
        private System.Windows.Forms.Label labelp1score;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBoxGameMode;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.Label player1Prof;
        private System.Windows.Forms.Label p2OrCom;
        private System.Windows.Forms.Label LabelPlayerone;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelturn;
    }
}

