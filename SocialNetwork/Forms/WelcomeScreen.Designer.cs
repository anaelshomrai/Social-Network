namespace Social_Network.Forms
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotUserName = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Black;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignUp.FlatAppearance.BorderSize = 2;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Bauhaus 93", 13.8F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(179, 420);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(106, 50);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPassword.Font = new System.Drawing.Font("Bauhaus 93", 13.8F);
            this.labPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPassword.Location = new System.Drawing.Point(37, 65);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(96, 21);
            this.labPassword.TabIndex = 9;
            this.labPassword.Text = "Password:";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labUserName.Font = new System.Drawing.Font("Bauhaus 93", 13.8F);
            this.labUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labUserName.Location = new System.Drawing.Point(37, 40);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(104, 21);
            this.labUserName.TabIndex = 8;
            this.labUserName.Text = "User name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.txtPassword.Location = new System.Drawing.Point(146, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(147, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bauhaus 93", 13.8F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(67, 420);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotUserName
            // 
            this.btnForgotUserName.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnForgotUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForgotUserName.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Underline);
            this.btnForgotUserName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnForgotUserName.Location = new System.Drawing.Point(304, 42);
            this.btnForgotUserName.Name = "btnForgotUserName";
            this.btnForgotUserName.Size = new System.Drawing.Size(98, 24);
            this.btnForgotUserName.TabIndex = 11;
            this.btnForgotUserName.Text = "Forgot User Name";
            this.btnForgotUserName.UseVisualStyleBackColor = false;
            this.btnForgotUserName.Click += new System.EventHandler(this.btnForgotUserName_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForgotPassword.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Underline);
            this.btnForgotPassword.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnForgotPassword.Location = new System.Drawing.Point(304, 68);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(98, 24);
            this.btnForgotPassword.TabIndex = 15;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Social_Network.Properties.Resources.tumblr_mk1uaaLXb21s0r4jho1_1280;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 540);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.BackColor = System.Drawing.Color.Black;
            this.btnPlayMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayMusic.FlatAppearance.BorderSize = 0;
            this.btnPlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMusic.Location = new System.Drawing.Point(82, 267);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(6, 6);
            this.btnPlayMusic.TabIndex = 18;
            this.btnPlayMusic.UseVisualStyleBackColor = false;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 514);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnForgotUserName);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotUserName;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlayMusic;
    }
}