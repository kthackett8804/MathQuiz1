
namespace WindowsFormsDONE
{
    partial class Question9
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
            this.btnNextQ9 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnIncorrect2 = new System.Windows.Forms.Button();
            this.btnIncorrect1 = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestion9 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextQ9
            // 
            this.btnNextQ9.BackColor = System.Drawing.Color.Black;
            this.btnNextQ9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQ9.ForeColor = System.Drawing.Color.White;
            this.btnNextQ9.Location = new System.Drawing.Point(373, 368);
            this.btnNextQ9.Name = "btnNextQ9";
            this.btnNextQ9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNextQ9.Size = new System.Drawing.Size(142, 34);
            this.btnNextQ9.TabIndex = 34;
            this.btnNextQ9.Text = "Next Question";
            this.btnNextQ9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNextQ9.UseVisualStyleBackColor = false;
            this.btnNextQ9.Visible = false;
            this.btnNextQ9.Click += new System.EventHandler(this.btnNextQ9_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(29, 393);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 19);
            this.lblScore.TabIndex = 33;
            this.lblScore.Text = "Score: ";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // btnIncorrect2
            // 
            this.btnIncorrect2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIncorrect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrect2.Location = new System.Drawing.Point(218, 165);
            this.btnIncorrect2.Name = "btnIncorrect2";
            this.btnIncorrect2.Size = new System.Drawing.Size(118, 43);
            this.btnIncorrect2.TabIndex = 32;
            this.btnIncorrect2.Text = "incorrect";
            this.btnIncorrect2.UseVisualStyleBackColor = false;
            this.btnIncorrect2.Click += new System.EventHandler(this.btnIncorrect2_Click);
            // 
            // btnIncorrect1
            // 
            this.btnIncorrect1.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIncorrect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrect1.Location = new System.Drawing.Point(39, 165);
            this.btnIncorrect1.Name = "btnIncorrect1";
            this.btnIncorrect1.Size = new System.Drawing.Size(118, 43);
            this.btnIncorrect1.TabIndex = 31;
            this.btnIncorrect1.Text = "incorrect";
            this.btnIncorrect1.UseVisualStyleBackColor = false;
            this.btnIncorrect1.Click += new System.EventHandler(this.btnIncorrect1_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.Location = new System.Drawing.Point(397, 165);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(118, 43);
            this.btnCorrect.TabIndex = 30;
            this.btnCorrect.Text = "correct";
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(35, 113);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(77, 21);
            this.lblQuestion.TabIndex = 29;
            this.lblQuestion.Text = "question";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblQuestion9
            // 
            this.lblQuestion9.AutoSize = true;
            this.lblQuestion9.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQuestion9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion9.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuestion9.Location = new System.Drawing.Point(34, 45);
            this.lblQuestion9.Name = "lblQuestion9";
            this.lblQuestion9.Size = new System.Drawing.Size(116, 26);
            this.lblQuestion9.TabIndex = 28;
            this.lblQuestion9.Text = "Question 9";
            this.lblQuestion9.Click += new System.EventHandler(this.lblQuestion6_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(654, 38);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(118, 43);
            this.btnMenu.TabIndex = 27;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(541, 38);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHint.FlatAppearance.BorderSize = 4;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(429, 38);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 36;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // Question9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnNextQ9);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnIncorrect2);
            this.Controls.Add(this.btnIncorrect1);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestion9);
            this.Controls.Add(this.btnMenu);
            this.Name = "Question9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question9";
            this.Load += new System.EventHandler(this.Question9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextQ9;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnIncorrect2;
        private System.Windows.Forms.Button btnIncorrect1;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestion9;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
    }
}