
namespace WindowsFormsDONE
{
    partial class Question1
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
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQ1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQ1.Location = new System.Drawing.Point(52, 26);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(116, 26);
            this.lblQ1.TabIndex = 0;
            this.lblQ1.Text = "Question 1";
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.BackColor = System.Drawing.Color.White;
            this.lblQuestion1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.Location = new System.Drawing.Point(54, 84);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(77, 21);
            this.lblQuestion1.TabIndex = 2;
            this.lblQuestion1.Text = "question";
            this.lblQuestion1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.GhostWhite;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(50, 136);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(118, 43);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "correct";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.GhostWhite;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(227, 136);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(118, 43);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "incorrect";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.GhostWhite;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(392, 136);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(118, 43);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "incorrect ";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnNextQ
            // 
            this.btnNextQ.BackColor = System.Drawing.Color.Black;
            this.btnNextQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQ.ForeColor = System.Drawing.Color.White;
            this.btnNextQ.Location = new System.Drawing.Point(392, 368);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNextQ.Size = new System.Drawing.Size(142, 34);
            this.btnNextQ.TabIndex = 6;
            this.btnNextQ.Text = "Next Question";
            this.btnNextQ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNextQ.UseVisualStyleBackColor = false;
            this.btnNextQ.Visible = false;
            this.btnNextQ.Click += new System.EventHandler(this.btnNextQ2_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(30, 392);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 19);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: ";
            this.lblScore.Click += new System.EventHandler(this.lblscore_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(627, 26);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(118, 43);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(502, 26);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHint.FlatAppearance.BorderSize = 4;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(392, 26);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 9;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.button1_Click);
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.lblQ1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Question1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question1";
            this.Load += new System.EventHandler(this.Question1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
    }
}