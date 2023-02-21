
namespace WindowsFormsDONE
{
    partial class RegChild
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.btnMenuReg = new System.Windows.Forms.Button();
            this.btnSaveChild = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Plum;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(167, 166);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(213, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Enter student username: ";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Plum;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(167, 264);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(210, 20);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Enter student password: ";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(167, 196);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(165, 293);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(212, 20);
            this.txtPass.TabIndex = 4;
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.BackColor = System.Drawing.Color.White;
            this.lblChildForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.Location = new System.Drawing.Point(167, 102);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(198, 26);
            this.lblChildForm.TabIndex = 6;
            this.lblChildForm.Text = "Child Register Form";
            // 
            // btnMenuReg
            // 
            this.btnMenuReg.BackColor = System.Drawing.Color.Black;
            this.btnMenuReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuReg.Location = new System.Drawing.Point(652, 22);
            this.btnMenuReg.Name = "btnMenuReg";
            this.btnMenuReg.Size = new System.Drawing.Size(118, 43);
            this.btnMenuReg.TabIndex = 7;
            this.btnMenuReg.Text = "Main Menu";
            this.btnMenuReg.UseVisualStyleBackColor = false;
            this.btnMenuReg.Click += new System.EventHandler(this.btnMenuReg_Click);
            // 
            // btnSaveChild
            // 
            this.btnSaveChild.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChild.Location = new System.Drawing.Point(475, 253);
            this.btnSaveChild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChild.Name = "btnSaveChild";
            this.btnSaveChild.Size = new System.Drawing.Size(96, 40);
            this.btnSaveChild.TabIndex = 8;
            this.btnSaveChild.Text = "Save info";
            this.btnSaveChild.UseVisualStyleBackColor = false;
            this.btnSaveChild.Click += new System.EventHandler(this.btnSaveChild_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsDONE.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(-89, -84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // RegChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnSaveChild);
            this.Controls.Add(this.btnMenuReg);
            this.Controls.Add(this.lblChildForm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegChild";
            this.Load += new System.EventHandler(this.RegChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblChildForm;
        private System.Windows.Forms.Button btnMenuReg;
        private System.Windows.Forms.Button btnSaveChild;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}