
namespace WindowsFormsDONE
{
    partial class FrmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnTeacher = new System.Windows.Forms.RadioButton();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogin.Location = new System.Drawing.Point(37, 31);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 26);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(512, 238);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 20);
            this.txtPass.TabIndex = 8;
            this.txtPass.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(513, 127);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.Visible = false;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(508, 206);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(96, 20);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password: ";
            this.lblPass.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(509, 93);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(101, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Username: ";
            this.lblUser.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(31, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 31);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please select whether you are a teacher or a student: ";
            // 
            // rdbtnTeacher
            // 
            this.rdbtnTeacher.AutoSize = true;
            this.rdbtnTeacher.Location = new System.Drawing.Point(31, 141);
            this.rdbtnTeacher.Name = "rdbtnTeacher";
            this.rdbtnTeacher.Size = new System.Drawing.Size(65, 17);
            this.rdbtnTeacher.TabIndex = 12;
            this.rdbtnTeacher.TabStop = true;
            this.rdbtnTeacher.Text = "Teacher";
            this.rdbtnTeacher.UseVisualStyleBackColor = true;
            this.rdbtnTeacher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.AutoSize = true;
            this.rdbtnStudent.Location = new System.Drawing.Point(31, 173);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(62, 17);
            this.rdbtnStudent.TabIndex = 13;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "Student";
            this.rdbtnStudent.UseVisualStyleBackColor = true;
            this.rdbtnStudent.CheckedChanged += new System.EventHandler(this.rdbtnStudent_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsDONE.Properties.Resources.clipart_sun_round_51;
            this.pictureBox2.Location = new System.Drawing.Point(584, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsDONE.Properties.Resources.clipart_grass_clear_background_4;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 337);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbtnStudent);
            this.Controls.Add(this.rdbtnTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnTeacher;
        private System.Windows.Forms.RadioButton rdbtnStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}