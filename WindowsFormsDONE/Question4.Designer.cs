
namespace WindowsFormsDONE
{
    partial class Question4
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
            this.lblQuestion4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblScore4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.lblWrong1 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong2 = new System.Windows.Forms.Label();
            this.lblWrong3 = new System.Windows.Forms.Label();
            this.Mathpic = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mathpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion4
            // 
            this.lblQuestion4.AutoSize = true;
            this.lblQuestion4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQuestion4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuestion4.Location = new System.Drawing.Point(24, 26);
            this.lblQuestion4.Name = "lblQuestion4";
            this.lblQuestion4.Size = new System.Drawing.Size(116, 26);
            this.lblQuestion4.TabIndex = 4;
            this.lblQuestion4.Text = "Question 4";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(670, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(118, 43);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblScore4
            // 
            this.lblScore4.AutoSize = true;
            this.lblScore4.BackColor = System.Drawing.Color.White;
            this.lblScore4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore4.ForeColor = System.Drawing.Color.Red;
            this.lblScore4.Location = new System.Drawing.Point(49, 384);
            this.lblScore4.Name = "lblScore4";
            this.lblScore4.Size = new System.Drawing.Size(53, 19);
            this.lblScore4.TabIndex = 13;
            this.lblScore4.Text = "Score: ";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(310, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 36);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.BackColor = System.Drawing.SystemColors.Control;
            this.lblQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ4.Location = new System.Drawing.Point(25, 72);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(331, 20);
            this.lblQ4.TabIndex = 15;
            this.lblQ4.Text = " Drag correct answer onto image below: ";
            // 
            // lblWrong1
            // 
            this.lblWrong1.AutoSize = true;
            this.lblWrong1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblWrong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong1.Location = new System.Drawing.Point(64, 144);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(50, 24);
            this.lblWrong1.TabIndex = 17;
            this.lblWrong1.Text = "Five";
            this.lblWrong1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selected);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(233, 144);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(39, 24);
            this.lblCorrect.TabIndex = 18;
            this.lblCorrect.Text = "Six";
            this.lblCorrect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selected);
            // 
            // lblWrong2
            // 
            this.lblWrong2.AutoSize = true;
            this.lblWrong2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblWrong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong2.Location = new System.Drawing.Point(64, 227);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(69, 24);
            this.lblWrong2.TabIndex = 19;
            this.lblWrong2.Text = "Seven";
            this.lblWrong2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selected);
            // 
            // lblWrong3
            // 
            this.lblWrong3.AutoSize = true;
            this.lblWrong3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblWrong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong3.Location = new System.Drawing.Point(218, 227);
            this.lblWrong3.Name = "lblWrong3";
            this.lblWrong3.Size = new System.Drawing.Size(54, 24);
            this.lblWrong3.TabIndex = 20;
            this.lblWrong3.Text = "Four";
            this.lblWrong3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selected);
            // 
            // Mathpic
            // 
            this.Mathpic.Image = global::WindowsFormsDONE.Properties.Resources.Apple123;
            this.Mathpic.Location = new System.Drawing.Point(425, 136);
            this.Mathpic.Name = "Mathpic";
            this.Mathpic.Size = new System.Drawing.Size(324, 192);
            this.Mathpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mathpic.TabIndex = 16;
            this.Mathpic.TabStop = false;
            this.Mathpic.Click += new System.EventHandler(this.Mathpic_Click);
            this.Mathpic.DragDrop += new System.Windows.Forms.DragEventHandler(this.Check);
            this.Mathpic.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataDropCheck);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(554, 19);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 43);
            this.saveBtn.TabIndex = 21;
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
            this.btnHint.Location = new System.Drawing.Point(452, 19);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 43);
            this.btnHint.TabIndex = 22;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // Question4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lblWrong3);
            this.Controls.Add(this.lblWrong2);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblWrong1);
            this.Controls.Add(this.Mathpic);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblScore4);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblQuestion4);
            this.Name = "Question4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question4";
            this.Load += new System.EventHandler(this.Question4_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selected);
            ((System.ComponentModel.ISupportInitialize)(this.Mathpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblScore4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.PictureBox Mathpic;
        private System.Windows.Forms.Label lblWrong1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong2;
        private System.Windows.Forms.Label lblWrong3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnHint;
    }
}