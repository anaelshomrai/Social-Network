namespace Social_Network.Forms
{
    partial class ForgotUserName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotUserName));
            this.labEmail = new System.Windows.Forms.Label();
            this.btnFindUserName = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labEmail.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labEmail.ForeColor = System.Drawing.Color.Black;
            this.labEmail.Location = new System.Drawing.Point(42, 58);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(57, 18);
            this.labEmail.TabIndex = 0;
            this.labEmail.Text = "Email :";
            // 
            // btnFindUserName
            // 
            this.btnFindUserName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFindUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUserName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFindUserName.FlatAppearance.BorderSize = 2;
            this.btnFindUserName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnFindUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUserName.Font = new System.Drawing.Font("Bauhaus 93", 13.8F);
            this.btnFindUserName.ForeColor = System.Drawing.Color.Black;
            this.btnFindUserName.Location = new System.Drawing.Point(91, 177);
            this.btnFindUserName.Name = "btnFindUserName";
            this.btnFindUserName.Size = new System.Drawing.Size(192, 35);
            this.btnFindUserName.TabIndex = 1;
            this.btnFindUserName.Text = "Find My User Name!";
            this.btnFindUserName.UseVisualStyleBackColor = false;
            this.btnFindUserName.Click += new System.EventHandler(this.btnFindUserName_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(143, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labPassword.ForeColor = System.Drawing.Color.Black;
            this.labPassword.Location = new System.Drawing.Point(42, 97);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(83, 18);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(143, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(288, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(53, 45);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labResult.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labResult.Location = new System.Drawing.Point(88, 136);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(144, 18);
            this.labResult.TabIndex = 6;
            this.labResult.Text = "Your User Name is : ";
            this.labResult.Click += new System.EventHandler(this.labResult_Click);
            // 
            // ForgotUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.ControlBox = false;
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnFindUserName);
            this.Controls.Add(this.labEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotUserName";
            this.Load += new System.EventHandler(this.ForgotUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Button btnFindUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label labResult;
    }
}