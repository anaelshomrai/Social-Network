namespace Social_Network.Forms
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.labEmail = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnFindPassword = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labEmail.ForeColor = System.Drawing.Color.Black;
            this.labEmail.Location = new System.Drawing.Point(42, 58);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(61, 18);
            this.labEmail.TabIndex = 0;
            this.labEmail.Text = "Email : ";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labUserName.ForeColor = System.Drawing.Color.Black;
            this.labUserName.Location = new System.Drawing.Point(42, 97);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(90, 18);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "User Name :";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(143, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(143, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // btnFindPassword
            // 
            this.btnFindPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFindPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFindPassword.FlatAppearance.BorderSize = 2;
            this.btnFindPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnFindPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPassword.Font = new System.Drawing.Font("Bauhaus 93", 13.8F);
            this.btnFindPassword.ForeColor = System.Drawing.Color.Black;
            this.btnFindPassword.Location = new System.Drawing.Point(91, 177);
            this.btnFindPassword.Name = "btnFindPassword";
            this.btnFindPassword.Size = new System.Drawing.Size(180, 35);
            this.btnFindPassword.TabIndex = 4;
            this.btnFindPassword.Text = "Find My Password!";
            this.btnFindPassword.UseVisualStyleBackColor = false;
            this.btnFindPassword.Click += new System.EventHandler(this.btnFindPassword_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labResult.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labResult.Location = new System.Drawing.Point(88, 137);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(137, 18);
            this.labResult.TabIndex = 5;
            this.labResult.Text = "Your Password is : ";
            this.labResult.Click += new System.EventHandler(this.labResult_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(288, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(53, 45);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnFindPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labEmail);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnFindPassword;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnGoBack;
    }
}