
namespace WindowsFormsDONE
{
    partial class Score
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.listOfScores = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(312, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Score Board";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreboard.Location = new System.Drawing.Point(312, 145);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(0, 25);
            this.lblScoreboard.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(666, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(118, 43);
            this.btnMenu.TabIndex = 28;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // listOfScores
            // 
            this.listOfScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfScores.FormattingEnabled = true;
            this.listOfScores.ItemHeight = 18;
            this.listOfScores.Location = new System.Drawing.Point(278, 160);
            this.listOfScores.Margin = new System.Windows.Forms.Padding(2);
            this.listOfScores.Name = "listOfScores";
            this.listOfScores.Size = new System.Drawing.Size(227, 148);
            this.listOfScores.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsDONE.Properties.Resources._06dc71ca083a55cace08e12ea4a10e38;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.listOfScores);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblScoreboard);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "score";
            this.Load += new System.EventHandler(this.score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreboard;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ListBox listOfScores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}