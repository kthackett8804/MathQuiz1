
namespace WindowsFormsDONE
{
    partial class Question8
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblScore8 = new System.Windows.Forms.Label();
            this.submitAns8 = new System.Windows.Forms.Button();
            this.txtboxQ8 = new System.Windows.Forms.TextBox();
            this.lblQuestion8 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.question8Lbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblHints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(296, 381);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 36);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblScore8
            // 
            this.lblScore8.AutoSize = true;
            this.lblScore8.BackColor = System.Drawing.Color.White;
            this.lblScore8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore8.ForeColor = System.Drawing.Color.Red;
            this.lblScore8.Location = new System.Drawing.Point(42, 398);
            this.lblScore8.Name = "lblScore8";
            this.lblScore8.Size = new System.Drawing.Size(53, 19);
            this.lblScore8.TabIndex = 19;
            this.lblScore8.Text = "Score: ";
            // 
            // submitAns8
            // 
            this.submitAns8.BackColor = System.Drawing.Color.Black;
            this.submitAns8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.submitAns8.ForeColor = System.Drawing.Color.White;
            this.submitAns8.Location = new System.Drawing.Point(380, 179);
            this.submitAns8.Name = "submitAns8";
            this.submitAns8.Size = new System.Drawing.Size(149, 33);
            this.submitAns8.TabIndex = 18;
            this.submitAns8.Text = "Submit answer";
            this.submitAns8.UseVisualStyleBackColor = false;
            this.submitAns8.Click += new System.EventHandler(this.submitAns8_Click);
            // 
            // txtboxQ8
            // 
            this.txtboxQ8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtboxQ8.Location = new System.Drawing.Point(46, 172);
            this.txtboxQ8.Name = "txtboxQ8";
            this.txtboxQ8.Size = new System.Drawing.Size(237, 32);
            this.txtboxQ8.TabIndex = 17;
            this.txtboxQ8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxQ8_KeyDown);
            // 
            // lblQuestion8
            // 
            this.lblQuestion8.AutoSize = true;
            this.lblQuestion8.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion8.Location = new System.Drawing.Point(42, 110);
            this.lblQuestion8.Name = "lblQuestion8";
            this.lblQuestion8.Size = new System.Drawing.Size(81, 22);
            this.lblQuestion8.TabIndex = 16;
            this.lblQuestion8.Text = "question";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(642, 33);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(118, 43);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // question8Lbl
            // 
            this.question8Lbl.AutoSize = true;
            this.question8Lbl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.question8Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question8Lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.question8Lbl.Location = new System.Drawing.Point(41, 40);
            this.question8Lbl.Name = "question8Lbl";
            this.question8Lbl.Size = new System.Drawing.Size(116, 26);
            this.question8Lbl.TabIndex = 14;
            this.question8Lbl.Text = "Question 8";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(529, 33);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHint.FlatAppearance.BorderSize = 4;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(425, 33);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 22;
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
            this.lblHints.Location = new System.Drawing.Point(48, 236);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(47, 20);
            this.lblHints.TabIndex = 23;
            this.lblHints.Text = "label";
            this.lblHints.Visible = false;
            this.lblHints.Click += new System.EventHandler(this.lblHints_Click);
            // 
            // Question8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblScore8);
            this.Controls.Add(this.submitAns8);
            this.Controls.Add(this.txtboxQ8);
            this.Controls.Add(this.lblQuestion8);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.question8Lbl);
            this.Name = "Question8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question8";
            this.Load += new System.EventHandler(this.Question8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore8;
        private System.Windows.Forms.Button submitAns8;
        private System.Windows.Forms.TextBox txtboxQ8;
        private System.Windows.Forms.Label lblQuestion8;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label question8Lbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblHints;
    }
}