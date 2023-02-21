
namespace WindowsFormsDONE
{
    partial class MainMenu
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChild = new System.Windows.Forms.Button();
            this.Background = new System.Windows.Forms.PictureBox();
            this.btnViewScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.BackColor = System.Drawing.Color.Black;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Location = new System.Drawing.Point(628, 9);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(160, 35);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuiz.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnQuiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuiz.Location = new System.Drawing.Point(319, 315);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(129, 32);
            this.btnQuiz.TabIndex = 1;
            this.btnQuiz.Text = "Begin Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(319, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogic_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Bell MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(292, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Magic Maths";
            // 
            // btnChild
            // 
            this.btnChild.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChild.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnChild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChild.Location = new System.Drawing.Point(319, 250);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(129, 43);
            this.btnChild.TabIndex = 4;
            this.btnChild.Text = "Register child";
            this.btnChild.UseVisualStyleBackColor = false;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // Background
            // 
            this.Background.Image = global::WindowsFormsDONE.Properties.Resources.pexels_photo_5453622;
            this.Background.Location = new System.Drawing.Point(-1, -3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(812, 489);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 5;
            this.Background.TabStop = false;
            // 
            // btnViewScore
            // 
            this.btnViewScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewScore.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnViewScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnViewScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnViewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewScore.Location = new System.Drawing.Point(319, 367);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.Size = new System.Drawing.Size(129, 50);
            this.btnViewScore.TabIndex = 6;
            this.btnViewScore.Text = "View ScoreBoard";
            this.btnViewScore.UseVisualStyleBackColor = false;
            this.btnViewScore.Visible = false;
            this.btnViewScore.Click += new System.EventHandler(this.btnViewScore_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewScore);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.Background);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button btnViewScore;
    }
}

