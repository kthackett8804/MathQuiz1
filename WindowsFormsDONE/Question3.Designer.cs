
namespace WindowsFormsDONE
{
    partial class Question3
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
            this.question3Lbl = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.txtboxQ3 = new System.Windows.Forms.TextBox();
            this.submitAns3 = new System.Windows.Forms.Button();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblHints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question3Lbl
            // 
            this.question3Lbl.AutoSize = true;
            this.question3Lbl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.question3Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3Lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.question3Lbl.Location = new System.Drawing.Point(36, 25);
            this.question3Lbl.Name = "question3Lbl";
            this.question3Lbl.Size = new System.Drawing.Size(116, 26);
            this.question3Lbl.TabIndex = 3;
            this.question3Lbl.Text = "Question 3";
            this.question3Lbl.Click += new System.EventHandler(this.Question3label_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(637, 18);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(118, 43);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3.Location = new System.Drawing.Point(37, 95);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(81, 22);
            this.lblQuestion3.TabIndex = 5;
            this.lblQuestion3.Text = "question";
            // 
            // txtboxQ3
            // 
            this.txtboxQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtboxQ3.Location = new System.Drawing.Point(41, 157);
            this.txtboxQ3.Name = "txtboxQ3";
            this.txtboxQ3.Size = new System.Drawing.Size(237, 32);
            this.txtboxQ3.TabIndex = 6;
            this.txtboxQ3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtboxQ3_KeyDown);
            // 
            // submitAns3
            // 
            this.submitAns3.BackColor = System.Drawing.Color.Black;
            this.submitAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.submitAns3.ForeColor = System.Drawing.Color.White;
            this.submitAns3.Location = new System.Drawing.Point(375, 164);
            this.submitAns3.Name = "submitAns3";
            this.submitAns3.Size = new System.Drawing.Size(149, 33);
            this.submitAns3.TabIndex = 10;
            this.submitAns3.Text = "Submit answer";
            this.submitAns3.UseVisualStyleBackColor = false;
            this.submitAns3.Click += new System.EventHandler(this.submitAns3_Click);
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.BackColor = System.Drawing.Color.White;
            this.lblScore3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore3.ForeColor = System.Drawing.Color.Red;
            this.lblScore3.Location = new System.Drawing.Point(37, 383);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(53, 19);
            this.lblScore3.TabIndex = 12;
            this.lblScore3.Text = "Score: ";
            this.lblScore3.Click += new System.EventHandler(this.lblscore3_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(291, 366);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 36);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(522, 18);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 14;
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
            this.btnHint.Location = new System.Drawing.Point(420, 18);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 15;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblHints
            // 
            this.lblHints.AutoSize = true;
            this.lblHints.BackColor = System.Drawing.Color.MediumPurple;
            this.lblHints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHints.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHints.Location = new System.Drawing.Point(51, 219);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(47, 20);
            this.lblHints.TabIndex = 16;
            this.lblHints.Text = "label";
            this.lblHints.Visible = false;
            // 
            // Question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.submitAns3);
            this.Controls.Add(this.txtboxQ3);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.question3Lbl);
            this.Name = "Question3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question3";
            this.Load += new System.EventHandler(this.Question3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question3Lbl;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.TextBox txtboxQ3;
        private System.Windows.Forms.Button submitAns3;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblHints;
    }
}