
namespace WindowsFormsDONE
{
    partial class Question2
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
            this.menuButton = new System.Windows.Forms.Button();
            this.question2Label = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.rdButton1 = new System.Windows.Forms.RadioButton();
            this.rdButton2 = new System.Windows.Forms.RadioButton();
            this.rdButton3 = new System.Windows.Forms.RadioButton();
            this.rdButton4 = new System.Windows.Forms.RadioButton();
            this.submitAns = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(621, 21);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(118, 43);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // question2Label
            // 
            this.question2Label.AutoSize = true;
            this.question2Label.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.question2Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Label.ForeColor = System.Drawing.SystemColors.Control;
            this.question2Label.Location = new System.Drawing.Point(46, 21);
            this.question2Label.Name = "question2Label";
            this.question2Label.Size = new System.Drawing.Size(116, 26);
            this.question2Label.TabIndex = 2;
            this.question2Label.Text = "Question 2";
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.Location = new System.Drawing.Point(47, 99);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(81, 22);
            this.lblQuestion2.TabIndex = 4;
            this.lblQuestion2.Text = "question";
            // 
            // rdButton1
            // 
            this.rdButton1.AutoSize = true;
            this.rdButton1.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton1.Location = new System.Drawing.Point(51, 177);
            this.rdButton1.Name = "rdButton1";
            this.rdButton1.Size = new System.Drawing.Size(84, 22);
            this.rdButton1.TabIndex = 5;
            this.rdButton1.TabStop = true;
            this.rdButton1.Text = "incorrect";
            this.rdButton1.UseVisualStyleBackColor = false;
            this.rdButton1.CheckedChanged += new System.EventHandler(this.rdButton1_CheckedChanged);
            // 
            // rdButton2
            // 
            this.rdButton2.AutoSize = true;
            this.rdButton2.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdButton2.Location = new System.Drawing.Point(51, 220);
            this.rdButton2.Name = "rdButton2";
            this.rdButton2.Size = new System.Drawing.Size(84, 22);
            this.rdButton2.TabIndex = 6;
            this.rdButton2.TabStop = true;
            this.rdButton2.Text = "incorrect";
            this.rdButton2.UseVisualStyleBackColor = false;
            // 
            // rdButton3
            // 
            this.rdButton3.AutoSize = true;
            this.rdButton3.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdButton3.Location = new System.Drawing.Point(191, 177);
            this.rdButton3.Name = "rdButton3";
            this.rdButton3.Size = new System.Drawing.Size(73, 22);
            this.rdButton3.TabIndex = 7;
            this.rdButton3.TabStop = true;
            this.rdButton3.Text = "correct";
            this.rdButton3.UseVisualStyleBackColor = false;
            this.rdButton3.CheckedChanged += new System.EventHandler(this.rdButton3_CheckedChanged);
            // 
            // rdButton4
            // 
            this.rdButton4.AutoSize = true;
            this.rdButton4.BackColor = System.Drawing.SystemColors.Control;
            this.rdButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdButton4.Location = new System.Drawing.Point(191, 220);
            this.rdButton4.Name = "rdButton4";
            this.rdButton4.Size = new System.Drawing.Size(84, 22);
            this.rdButton4.TabIndex = 8;
            this.rdButton4.TabStop = true;
            this.rdButton4.Text = "incorrect";
            this.rdButton4.UseVisualStyleBackColor = false;
            // 
            // submitAns
            // 
            this.submitAns.BackColor = System.Drawing.Color.Black;
            this.submitAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAns.ForeColor = System.Drawing.Color.White;
            this.submitAns.Location = new System.Drawing.Point(539, 203);
            this.submitAns.Name = "submitAns";
            this.submitAns.Size = new System.Drawing.Size(149, 26);
            this.submitAns.TabIndex = 9;
            this.submitAns.Text = "Submit answer";
            this.submitAns.UseVisualStyleBackColor = false;
            this.submitAns.Click += new System.EventHandler(this.submitAns_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(325, 357);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 36);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.White;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.Red;
            this.lblScore2.Location = new System.Drawing.Point(28, 388);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(53, 19);
            this.lblScore2.TabIndex = 11;
            this.lblScore2.Text = "Score: ";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(509, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 12;
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
            this.btnHint.Location = new System.Drawing.Point(406, 21);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 13;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // Question2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.submitAns);
            this.Controls.Add(this.rdButton4);
            this.Controls.Add(this.rdButton3);
            this.Controls.Add(this.rdButton2);
            this.Controls.Add(this.rdButton1);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.question2Label);
            this.Name = "Question2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question2";
            this.Load += new System.EventHandler(this.Question2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label question2Label;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.RadioButton rdButton1;
        private System.Windows.Forms.RadioButton rdButton2;
        private System.Windows.Forms.RadioButton rdButton3;
        private System.Windows.Forms.RadioButton rdButton4;
        private System.Windows.Forms.Button submitAns;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
    }
}