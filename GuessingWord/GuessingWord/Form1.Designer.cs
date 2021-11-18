namespace GuessingWord
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
            this.components = new System.ComponentModel.Container();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreLBL = new System.Windows.Forms.Label();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.labelLetters = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(23, 284);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(57, 52);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonN.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonN.FlatAppearance.BorderSize = 0;
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.ForeColor = System.Drawing.Color.White;
            this.buttonN.Location = new System.Drawing.Point(106, 284);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(57, 52);
            this.buttonN.TabIndex = 2;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonG.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonG.FlatAppearance.BorderSize = 0;
            this.buttonG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonG.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonG.ForeColor = System.Drawing.Color.White;
            this.buttonG.Location = new System.Drawing.Point(189, 284);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(57, 52);
            this.buttonG.TabIndex = 3;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = false;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonE.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonE.FlatAppearance.BorderSize = 0;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.ForeColor = System.Drawing.Color.White;
            this.buttonE.Location = new System.Drawing.Point(272, 284);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(57, 52);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonR.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonR.FlatAppearance.BorderSize = 0;
            this.buttonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonR.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.ForeColor = System.Drawing.Color.White;
            this.buttonR.Location = new System.Drawing.Point(355, 284);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(57, 52);
            this.buttonR.TabIndex = 5;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(110, 356);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(117, 39);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(292, 356);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(117, 39);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(100, 236);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(319, 35);
            this.textBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "WORD TO GUESS";
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonD.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.ForeColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(438, 284);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(57, 52);
            this.buttonD.TabIndex = 14;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Score: ";
            // 
            // ScoreLBL
            // 
            this.ScoreLBL.AutoSize = true;
            this.ScoreLBL.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLBL.Location = new System.Drawing.Point(61, 9);
            this.ScoreLBL.Name = "ScoreLBL";
            this.ScoreLBL.Size = new System.Drawing.Size(22, 26);
            this.ScoreLBL.TabIndex = 16;
            this.ScoreLBL.Text = "0";
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonShuffle.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonShuffle.FlatAppearance.BorderSize = 0;
            this.buttonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShuffle.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShuffle.ForeColor = System.Drawing.Color.White;
            this.buttonShuffle.Location = new System.Drawing.Point(110, 413);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(117, 39);
            this.buttonShuffle.TabIndex = 17;
            this.buttonShuffle.Text = "SHUFFLE";
            this.buttonShuffle.UseVisualStyleBackColor = false;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(292, 413);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(117, 39);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.labelLetters);
            this.panel.Controls.Add(this.time);
            this.panel.Location = new System.Drawing.Point(100, 69);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(319, 161);
            this.panel.TabIndex = 19;
            // 
            // labelLetters
            // 
            this.labelLetters.AutoSize = true;
            this.labelLetters.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetters.Location = new System.Drawing.Point(155, 99);
            this.labelLetters.Name = "labelLetters";
            this.labelLetters.Size = new System.Drawing.Size(0, 62);
            this.labelLetters.TabIndex = 15;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(126, 5);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(66, 84);
            this.time.TabIndex = 14;
            this.time.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(518, 467);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.ScoreLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessingWord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScoreLBL;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelLetters;
        private System.Windows.Forms.Label time;
    }
}

