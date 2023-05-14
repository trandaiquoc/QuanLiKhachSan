namespace QLKS
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.button_exit = new System.Windows.Forms.Button();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_question = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox_anmk = new System.Windows.Forms.PictureBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_dangnhap = new System.Windows.Forms.Label();
            this.pictureBox_hienmk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hienmk)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_exit.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_exit.Location = new System.Drawing.Point(126, 545);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 50);
            this.button_exit.TabIndex = 21;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_signup
            // 
            this.button_signup.AutoSize = true;
            this.button_signup.BackColor = System.Drawing.Color.Transparent;
            this.button_signup.FlatAppearance.BorderSize = 0;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_signup.Location = new System.Drawing.Point(231, 430);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(184, 38);
            this.button_signup.TabIndex = 20;
            this.button_signup.Text = "Đăng Ký Tài Khoản";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.BackColor = System.Drawing.Color.Transparent;
            this.label_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_question.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_question.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_question.Location = new System.Drawing.Point(34, 436);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(178, 28);
            this.label_question.TabIndex = 19;
            this.label_question.Text = "Chưa có tài khoản?";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_login.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_login.Location = new System.Drawing.Point(126, 323);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(200, 50);
            this.button_login.TabIndex = 18;
            this.button_login.Text = "Đăng Nhập";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox_anmk
            // 
            this.pictureBox_anmk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_anmk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_anmk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_anmk.Image")));
            this.pictureBox_anmk.Location = new System.Drawing.Point(410, 244);
            this.pictureBox_anmk.Name = "pictureBox_anmk";
            this.pictureBox_anmk.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_anmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_anmk.TabIndex = 16;
            this.pictureBox_anmk.TabStop = false;
            this.pictureBox_anmk.Click += new System.EventHandler(this.pictureBox_anmk_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.White;
            this.textBox_pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox_pass.Location = new System.Drawing.Point(22, 243);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(418, 31);
            this.textBox_pass.TabIndex = 15;
            this.textBox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pass_KeyPress);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_pass.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_pass.Location = new System.Drawing.Point(18, 212);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(96, 28);
            this.label_pass.TabIndex = 14;
            this.label_pass.Text = "Mật Khẩu";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.White;
            this.textBox_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox_username.Location = new System.Drawing.Point(22, 145);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(418, 31);
            this.textBox_username.TabIndex = 13;
            this.textBox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_username_KeyPress);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_username.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_username.Location = new System.Drawing.Point(18, 119);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(146, 28);
            this.label_username.TabIndex = 12;
            this.label_username.Text = "Tên Đăng Nhập";
            // 
            // label_dangnhap
            // 
            this.label_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.label_dangnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_dangnhap.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_dangnhap.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_dangnhap.Location = new System.Drawing.Point(0, 0);
            this.label_dangnhap.Name = "label_dangnhap";
            this.label_dangnhap.Size = new System.Drawing.Size(461, 56);
            this.label_dangnhap.TabIndex = 11;
            this.label_dangnhap.Text = "Đăng Nhập";
            this.label_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_hienmk
            // 
            this.pictureBox_hienmk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_hienmk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_hienmk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hienmk.Image")));
            this.pictureBox_hienmk.Location = new System.Drawing.Point(410, 244);
            this.pictureBox_hienmk.Name = "pictureBox_hienmk";
            this.pictureBox_hienmk.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_hienmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hienmk.TabIndex = 17;
            this.pictureBox_hienmk.TabStop = false;
            this.pictureBox_hienmk.Click += new System.EventHandler(this.pictureBox_hienmk_Click);
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 611);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pictureBox_anmk);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_dangnhap);
            this.Controls.Add(this.pictureBox_hienmk);
            this.Name = "DANGNHAP";
            this.Text = "DANGNHAP";
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hienmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox_anmk;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_dangnhap;
        private System.Windows.Forms.PictureBox pictureBox_hienmk;
    }
}