namespace Social_Network.Forms
{
    partial class AdminHome
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
            this.btnAdminOptions = new System.Windows.Forms.Button();
            this.btnChangePermission = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.labMembers = new System.Windows.Forms.Label();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminOptions
            // 
            this.btnAdminOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminOptions.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnAdminOptions.Location = new System.Drawing.Point(522, 54);
            this.btnAdminOptions.Name = "btnAdminOptions";
            this.btnAdminOptions.Size = new System.Drawing.Size(70, 54);
            this.btnAdminOptions.TabIndex = 28;
            this.btnAdminOptions.Text = "Admin Options";
            this.btnAdminOptions.UseVisualStyleBackColor = true;
            this.btnAdminOptions.Click += new System.EventHandler(this.btnAdminOptions_Click);
            // 
            // btnChangePermission
            // 
            this.btnChangePermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePermission.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnChangePermission.Location = new System.Drawing.Point(752, 210);
            this.btnChangePermission.Name = "btnChangePermission";
            this.btnChangePermission.Size = new System.Drawing.Size(178, 32);
            this.btnChangePermission.TabIndex = 29;
            this.btnChangePermission.Text = "Change Permission";
            this.btnChangePermission.UseVisualStyleBackColor = true;
            this.btnChangePermission.Click += new System.EventHandler(this.btnChangePermission_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnDeleteUser.Location = new System.Drawing.Point(752, 260);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(178, 32);
            this.btnDeleteUser.TabIndex = 30;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // labMembers
            // 
            this.labMembers.AutoSize = true;
            this.labMembers.Font = new System.Drawing.Font("Bauhaus 93", 9F);
            this.labMembers.Location = new System.Drawing.Point(734, 54);
            this.labMembers.Name = "labMembers";
            this.labMembers.Size = new System.Drawing.Size(119, 14);
            this.labMembers.TabIndex = 31;
            this.labMembers.Text = "How Many Members?";
            this.labMembers.Click += new System.EventHandler(this.labMembers_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStatus.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnCheckStatus.Location = new System.Drawing.Point(752, 54);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(70, 54);
            this.btnCheckStatus.TabIndex = 32;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(947, 458);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.labMembers);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnChangePermission);
            this.Controls.Add(this.btnAdminOptions);
            this.Name = "AdminHome";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Controls.SetChildIndex(this.btnAdminOptions, 0);
            this.Controls.SetChildIndex(this.btnChangePermission, 0);
            this.Controls.SetChildIndex(this.btnDeleteUser, 0);
            this.Controls.SetChildIndex(this.labMembers, 0);
            this.Controls.SetChildIndex(this.btnCheckStatus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdminOptions;
        private System.Windows.Forms.Button btnChangePermission;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label labMembers;
        private System.Windows.Forms.Button btnCheckStatus;
    }
}
