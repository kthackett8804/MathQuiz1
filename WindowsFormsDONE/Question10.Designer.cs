
namespace WindowsFormsDONE
{
    partial class Question10
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
            this.lblQuestion10 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnNextQ10 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.submitAns = new System.Windows.Forms.Button();
            this.rdButton4 = new System.Windows.Forms.RadioButton();
            this.rdButton3 = new System.Windows.Forms.RadioButton();
            this.rdButton2 = new System.Windows.Forms.RadioButton();
            this.rdButton1 = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion10
            // 
            this.lblQuestion10.AutoSize = true;
            this.lblQuestion10.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQuestion10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion10.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuestion10.Location = new System.Drawing.Point(35, 38);
            this.lblQuestion10.Name = "lblQuestion10";
            this.lblQuestion10.Size = new System.Drawing.Size(128, 26);
            this.lblQuestion10.TabIndex = 30;
            this.lblQuestion10.Text = "Question 10";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(37, 102);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(77, 21);
            this.lblQuestion.TabIndex = 31;
            this.lblQuestion.Text = "question";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(647, 31);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(118, 43);
            this.btnMenu.TabIndex = 32;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNextQ10
            // 
            this.btnNextQ10.BackColor = System.Drawing.Color.Black;
            this.btnNextQ10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQ10.ForeColor = System.Drawing.Color.White;
            this.btnNextQ10.Location = new System.Drawing.Point(379, 368);
            this.btnNextQ10.Name = "btnNextQ10";
            this.btnNextQ10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNextQ10.Size = new System.Drawing.Size(142, 34);
            this.btnNextQ10.TabIndex = 36;
            this.btnNextQ10.Text = "End";
            this.btnNextQ10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNextQ10.UseVisualStyleBackColor = false;
            this.btnNextQ10.Visible = false;
            this.btnNextQ10.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(35, 393);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 19);
            this.lblScore.TabIndex = 35;
            this.lblScore.Text = "Score: ";
            // 
            // submitAns
            // 
            this.submitAns.BackColor = System.Drawing.Color.Black;
            this.submitAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAns.ForeColor = System.Drawing.Color.White;
            this.submitAns.Location = new System.Drawing.Point(526, 196);
            this.submitAns.Name = "submitAns";
            this.submitAns.Size = new System.Drawing.Size(149, 26);
            this.submitAns.TabIndex = 41;
            this.submitAns.Text = "Submit answer";
            this.submitAns.UseVisualStyleBackColor = false;
            this.submitAns.Click += new System.EventHandler(this.submitAns_Click);
            // 
            // rdButton4
            // 
            this.rdButton4.AutoSize = true;
            this.rdButton4.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdButton4.ForeColor = System.Drawing.Color.Black;
            this.rdButton4.Location = new System.Drawing.Point(178, 225);
            this.rdButton4.Name = "rdButton4";
            this.rdButton4.Size = new System.Drawing.Size(84, 22);
            this.rdButton4.TabIndex = 40;
            this.rdButton4.TabStop = true;
            this.rdButton4.Text = "incorrect";
            this.rdButton4.UseVisualStyleBackColor = false;
            // 
            // rdButton3
            // 
            this.rdButton3.AutoSize = true;
            this.rdButton3.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdButton3.ForeColor = System.Drawing.Color.Black;
            this.rdButton3.Location = new System.Drawing.Point(39, 225);
            this.rdButton3.Name = "rdButton3";
            this.rdButton3.Size = new System.Drawing.Size(73, 22);
            this.rdButton3.TabIndex = 39;
            this.rdButton3.TabStop = true;
            this.rdButton3.Text = "correct";
            this.rdButton3.UseVisualStyleBackColor = false;
            // 
            // rdButton2
            // 
            this.rdButton2.AutoSize = true;
            this.rdButton2.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdButton2.ForeColor = System.Drawing.Color.Black;
            this.rdButton2.Location = new System.Drawing.Point(178, 170);
            this.rdButton2.Name = "rdButton2";
            this.rdButton2.Size = new System.Drawing.Size(84, 22);
            this.rdButton2.TabIndex = 38;
            this.rdButton2.TabStop = true;
            this.rdButton2.Text = "incorrect";
            this.rdButton2.UseVisualStyleBackColor = false;
            // 
            // rdButton1
            // 
            this.rdButton1.AutoSize = true;
            this.rdButton1.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton1.ForeColor = System.Drawing.Color.Black;
            this.rdButton1.Location = new System.Drawing.Point(38, 170);
            this.rdButton1.Name = "rdButton1";
            this.rdButton1.Size = new System.Drawing.Size(76, 22);
            this.rdButton1.TabIndex = 37;
            this.rdButton1.TabStop = true;
            this.rdButton1.Text = "incorret";
            this.rdButton1.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(536, 31);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 42;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHint.FlatAppearance.BorderSize = 4;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHint.Location = new System.Drawing.Point(435, 31);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 43;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // Question10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.submitAns);
            this.Controls.Add(this.rdButton4);
            this.Controls.Add(this.rdButton3);
            this.Controls.Add(this.rdButton2);
            this.Controls.Add(this.rdButton1);
            this.Controls.Add(this.btnNextQ10);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestion10);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Question10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question10";
            this.Load += new System.EventHandler(this.Question10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion10;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNextQ10;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button submitAns;
        private System.Windows.Forms.RadioButton rdButton4;
        private System.Windows.Forms.RadioButton rdButton3;
        private System.Windows.Forms.RadioButton rdButton2;
        private System.Windows.Forms.RadioButton rdButton1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
    }
}