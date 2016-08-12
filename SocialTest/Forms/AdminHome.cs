using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Network.Forms
{
    public partial class AdminHome : Social_Network.Forms.PremiumUserHome
    {
        DB dataBase = DB.GetInstance();
        AbstractUser user = null;
        Admin admin = null;


        public AdminHome()
        {
            InitializeComponent();
        }

        public AdminHome(string userName,string password, WelcomeScreen previous)
            :base(userName,password, previous)
        {
            InitializeComponent();
            user = dataBase.FindUser(userName, password); 
        }

        protected override void Home_Load(object sender, EventArgs e)
        {
          //  if (DesignMode) return;

            admin = (Admin)user;
            base.HideAllButtons();
            HideAdminButtons();
            MnulUserName.Font = new System.Drawing.Font("Bauhaus 93", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnulUserName.ForeColor = Color.Tomato;
            MnulUserName.Text = "Welcome " + admin.UserName;
            checkFriendshipRequests();
            labMembers.Visible = false;
            this.mnuAccountOptions.BackColor = System.Drawing.Color.Black;


        }

        private void refreshTotalMembers()
        {
            labMembers.Text = dataBase.HowManyMembers();
        }

        private void btnAdminOptions_Click(object sender, EventArgs e)
        {
            refreshData("users");
            base.HideAllButtons();
            ShowAdminButtons();
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            refreshData("users");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AbstractUser u = null;
            if (row != null && row.Index > -1)
            {
                string userName = row.Cells["UserName"].FormattedValue.ToString();
                string password = row.Cells["Password"].FormattedValue.ToString();
                string res;
                u = dataBase.FindUser(userName, password);
                if (u != null)
                {

                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete " + userName + " ?", "Delete User", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        res = admin.DeleteUser(u);
                        MessageBox.Show(res);
                        refreshTotalMembers();
                        refreshData("users");
                    }
                    // refresh list
                }
            }
            else
            {
                MessageBox.Show("Select User!");
            }
        }

        private void btnChangePermission_Click(object sender, EventArgs e)
        {
            int permission = 0;
            AbstractUser u = null;
            if (row != null && row.Index > -1)
            {
                string userName = row.Cells["UserName"].FormattedValue.ToString();
                string password = row.Cells["Password"].FormattedValue.ToString();
                string res;
                u = dataBase.FindUser(userName, password);
                if (u != null)
                {

                    if (MessageDialog.ChangePermission(ref permission) == DialogResult.OK)
                    {
                        if (permission == u.Permission && permission != 1)
                        {
                            MessageBox.Show(u.UserName + " already has this permissions");
                        }
                        else
                        {
                            res = admin.ChangePermission(permission, u);
                            MessageBox.Show(res);
                            refreshTotalMembers();
                            refreshData("users");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select User!");
            }
        }

        private void HideAdminButtons()
        {
            btnChangePermission.Visible = false;
            btnDeleteUser.Visible = false;
        }

        private void ShowAdminButtons()
        {
            btnChangePermission.Visible = true;
            btnDeleteUser.Visible = true;
        }

        protected override void HideAllButtons()
        {
            base.HideAllButtons();
            HideAdminButtons();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            labMembers.Visible = true;
            refreshTotalMembers();
            btnCheckStatus.Visible = false;
        }

        private void labMembers_Click(object sender, EventArgs e)
        {
            labMembers.Visible = false;
            btnCheckStatus.Visible = true;
        }
    }
}
