using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading;

namespace Social_Network.Forms
{
    public partial class Home : Form
    {
        DB dataBase = DB.GetInstance();
        private string userName;
        AbstractUser user = null;
        protected DataGridViewRow row = new DataGridViewRow();
        WelcomeScreen prevForm = null;
        Point btnShowMyPostsOrg;


        public Home()
        {
            InitializeComponent();
        }
        public Home(string userName, string password, WelcomeScreen previous)
        {

            InitializeComponent();
            prevForm = previous;
            this.user = dataBase.FindUser(userName, password);
            btnShowMyPostsOrg = btnShowMyPosts.Location;

        }

        protected virtual void Home_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            HideAllButtons();

            this.userName = user.UserName;
            MnulUserName.Text = "Welcome " + this.userName;
            this.MnulUserName.ForeColor = Color.White;
            mnuAccountOptions.BackColor = Color.Black;
            checkFriendshipRequests();
        }

        protected void checkFriendshipRequests()
        {
            if (dataBase.NewFriendshipRequests(user.UserName) == true)
            {
                labFriendshipNotfication.Visible = true;
                labFriendshipNotfication.Text = "You've got pending friendship requests!";
            }
            else
            {
                labFriendshipNotfication.Visible = false;
                labFriendshipNotfication.Text = "";
            }
        }

        protected void refreshData(string dataSource)
        {
            switch (dataSource)
            {
                case "post":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dataBase.ShowFeed();
                    PaintPosts();
                    removePrivateData();
                    dgvLists.Columns["Like"].Width = 100;
                    dgvLists.Columns["Share"].Width = 100;
                    dgvLists.Columns["From"].Width = 140;
                    dgvLists.Columns["Content"].Width = 170;
                    dgvLists.Columns["Date"].Width = 175;
                    dgvLists.Columns["Like"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvLists.Columns["Share"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvLists.BackgroundColor = Color.LightSkyBlue;
                   
                    break;
                case "friends":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dataBase.ShowFriends(user.UserName);
                    dgvLists.Columns["Gender"].Width = 106;
                    dgvLists.Columns["FirstName"].HeaderText = "First Name";
                    dgvLists.Columns["LastName"].HeaderText = "Last Name";
                    dgvLists.Columns["UserName"].HeaderText = "User Name";
                    dgvLists.Columns["FavoriteGenre"].HeaderText = " Favorite Genre";
                    dgvLists.Columns["FavoriteGenre"].Width = 98;
                    dgvLists.Columns["Email"].Width =  183;
                   
                    break;
                case "message":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dgvLists.DataSource = dataBase.Friendconversations(user.UserName);
                    dgvLists.Columns["FirstName"].HeaderText = "First Name";
                    dgvLists.Columns["LastName"].HeaderText = "Last Name";
                    dgvLists.Columns["UserName"].HeaderText = "User Name";
                    dgvLists.Columns["FavoriteGenre"].HeaderText = " Favorite Genre";
                    dgvLists.Columns["FavoriteGenre"].Width = 108;
                    dgvLists.Columns["Email"].Width = 173;
                    dgvLists.Columns["Gender"].Width = 106;
                    break;
                case "myMessage":
                    dgvLists.Columns["MessageId"].Visible = false;
                    dgvLists.Columns["To"].Visible = false;
                    dgvLists.Columns["From"].Visible = false;
                    PaintMessages();
                    break;
                case "myPost":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dgvLists.DataSource = dataBase.PrintAllMyPosts(user.UserName);
                    dgvLists.Columns["Like"].Width = 100;
                    dgvLists.Columns["Share"].Width = 100;
                    dgvLists.Columns["Content"].Width = 210;
                    dgvLists.Columns["Date"].Width = 175;
                    dgvLists.Columns["Like"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvLists.Columns["Share"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                    removePrivateData();
                    break;
                case "friendshipReq":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dataBase.SeeFriendshipRequests(user.UserName);
                    dgvLists.Columns["SentFrom"].HeaderText = "From";
                    dgvLists.Columns["SentTo"].Visible = false;
                    dgvLists.Columns["Date"].Width = 150;
                    break;
                case "playlist":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dataBase.ShowAllPlaylist();
                    dgvLists.Columns["Singer"].Width = 230;
                    dgvLists.Columns["Song"].Width = 230;
                    dgvLists.Columns["Genre"].Width = 225;

                    break;
                case "users":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dataBase.Users;
                    break;
                case "pendingReq":
                    dgvLists.DataSource = null;
                    dgvLists.DataSource = dataBase.ShowPendingRequest(user.UserName);
                    dgvLists.Columns["SentFrom"].Visible = false;
                    dgvLists.Columns["SentTo"].HeaderText = "Sent To";
                    break;
            }
        }

        private void PaintMessages()
        {
            foreach (DataGridViewRow dgvr in dgvLists.Rows)
            {
                if (dgvr.Cells["From"].FormattedValue.ToString() == user.UserName) // Means that i sent the message
                {
                    dgvLists.Rows[dgvr.Index].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                }
            }
        }

        /////////// Posts ///////////
        private void btnPost_Click(object sender, EventArgs e)
        {
            btnShowMyPosts.Location = btnShowMyPostsOrg;

            HideAllButtons();
            ShowPostButtons();
            HidePostEditingButtons();
            refreshData("post");
        }

        private void PaintPosts()
        {
            foreach (DataGridViewRow dgvr in dgvLists.Rows)
            {
                if (dgvr.Cells["Priority"].FormattedValue.ToString() == "1") // Means its an admin
                {
                    dgvLists.Rows[dgvr.Index].DefaultCellStyle.BackColor = Color.Tomato;
                }
                else if (dgvr.Cells["Priority"].FormattedValue.ToString() == "2") // Means its premium user
                {
                    dgvLists.Rows[dgvr.Index].DefaultCellStyle.BackColor = Color.DarkSalmon;

                }

            }
        }


        private void btnAddPost_Click(object sender, EventArgs e)
        {
            string content = "Here";
            if (MessageDialog.InputBox("Add Post", "Enter your new post", ref content, true) == DialogResult.OK)
            {
                user.AddPost(content);
                refreshData("post");
            }

        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                string content = "";
                int idPost = Convert.ToInt16(row.Cells["IdPost"].FormattedValue.ToString());
                try
                {
                    content = row.Cells[idPost].FormattedValue.ToString();
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                string from = row.Cells["From"].FormattedValue.ToString();
                if (MessageDialog.InputBox("Edit Post", "Edit your post", ref content, true) == DialogResult.OK)
                {
                    if (user.EditPost(idPost, content))
                    {
                        MessageBox.Show("Post edited!");
                        // refrese my posts
                        refreshData("myPost");
                    }
                    else
                    {
                        MessageBox.Show("This post isn't yours!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the post you want to edit");
            }

        }

        private void btnRemovePost_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                int idPost = Convert.ToInt16(row.Cells["IdPost"].FormattedValue.ToString());

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this post?\n", "Remove Post", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (user.RemovePost(idPost))
                    {
                        MessageBox.Show("Post Removed!");
                        // refresh myposts
                        refreshData("myPost");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the post you want to remove");
            }

        }

        private void btnShowMyPosts_Click(object sender, EventArgs e)
        {
            HidePostButtons();
            ShowPostEditingButtons();
            refreshData("myPost");
        }

        private void btnShowFeed_Click(object sender, EventArgs e)
        {
            btnPost.PerformClick();
        }
        private void btnAddLike_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                int idPost = Convert.ToInt16(row.Cells["IdPost"].FormattedValue.ToString());
                dataBase.LikePost(idPost);
                // refrese my posts
                refreshData("post");
            }
            else
            {
                MessageBox.Show("Select the post you want to edit");
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                int idPost = Convert.ToInt16(row.Cells["IdPost"].FormattedValue.ToString());

                dataBase.SharePost(idPost, user);
                // refrese my posts
                refreshData("post");
                PaintPosts();

            }
            else
            {
                MessageBox.Show("Select the post you want to edit");
            }
        }

        private void btnUnlike_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                int idPost = Convert.ToInt16(row.Cells["IdPost"].FormattedValue.ToString());

                dataBase.UnlikePost(idPost);
                // refrese my posts
                refreshData("post");

            }
            else
            {
                MessageBox.Show("Select the post you want to edit");
            }
        }

        protected void HidePostButtons()
        {
            btnAddPost.Visible = false;
            btnEditPost.Visible = false;
            btnRemovePost.Visible = false;
            btnShowMyPosts.Visible = false;
            btnLike.Visible = false;
            btnShare.Visible = false;
            btnUnlike.Visible = false;
        }
        protected void ShowPostButtons()
        {
            btnAddPost.Visible = true;
            btnShowMyPosts.Visible = true;
            btnLike.Visible = true;
            btnShare.Visible = true;
            btnUnlike.Visible = true;
        }

        private void ShowPostEditingButtons()
        {
            btnEditPost.Visible = true;
            btnRemovePost.Visible = true;
            btnShowFeed.Visible = true;
        }

        protected void HidePostEditingButtons()
        {
            btnEditPost.Visible = false;
            btnRemovePost.Visible = false;
            btnShowFeed.Visible = false;
        }

        /////////// Friends ///////////
        protected virtual void btnFriends_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            refreshData("friends");
            removePrivateData();
            ShowFriendButtons();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            string content = "";
            if (row != null && row.Index > -1 && btnFindUserByGenre.Visible == true)
            {
                content = row.Cells["UserName"].FormattedValue.ToString();
            }
            
            if (MessageDialog.InputBox("Add Friend", "Type the user name here", ref content, false) == DialogResult.OK)
            {
                if (content.Equals(user.UserName))
                {
                    MessageBox.Show("You can't add yourself!");
                }
                else
                MessageBox.Show(user.AddFriend(content));
            }
        }

        private void btnRemoveFriend_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                string friendUserName = row.Cells["UserName"].FormattedValue.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + friendUserName + "?\n", "Remove Friend", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (user.RemoveFriend(friendUserName))
                    {
                        MessageBox.Show("friend deleted!");
                        refreshData("friends");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the friend you want to delete");
            }
        }

        private void btnSeeFrienshipRequest_Click(object sender, EventArgs e)
        {
            refreshData("friendshipReq");
            HideAllButtons();
            ShowFriendshipRequestButton();

        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                string sentFrom = row.Cells["SentFrom"].FormattedValue.ToString();
                dataBase.RemoveFriendshipRequest(user.UserName,sentFrom, true);

                MessageBox.Show("Friend Added!");
                // refresh list
                refreshData("friendshipReq");
                checkFriendshipRequests();
            }
            else
            {
                MessageBox.Show("Select the friend you want to approve");
            }
        }

        private void btnDenyRequest_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                string sentFrom = row.Cells["SentFrom"].FormattedValue.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to deny friendship with " + sentFrom + "?\n",
                    "Deny Friendship Request", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataBase.RemoveFriendshipRequest(user.UserName,sentFrom, false);
                    // refresh list
                    refreshData("friendshipReq");
                    checkFriendshipRequests();
                }
            }
            else
            {
                MessageBox.Show("Select the friend you want to deny");
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            refreshData("pendingReq");
            HideFriendshipRequestButton();
            ShowFriendButtons();
            HidePendingButtons();

        }

        private void HidePendingButtons()
        {
            btnAddFriend.Visible = false;
            btnRemoveFriend.Visible = false;
        }

        protected void HideFriendshipRequestButton()
        {
            btnApproveRequest.Visible = false;
            btnDenyRequest.Visible = false;
            btnPending.Visible = false;
        }

        protected void ShowFriendshipRequestButton()
        {
            btnApproveRequest.Visible = true;
            btnDenyRequest.Visible = true;
            btnPending.Visible = true;
        }

        protected void HideFriendButtons()
        {
            btnAddFriend.Visible = false;
            btnSeeFrienshipRequest.Visible = false;
            btnRemoveFriend.Visible = false;
            btnFindUserByGenre.Visible = false;
        }
        protected void ShowFriendButtons()
        {
            btnAddFriend.Visible = true;
            btnSeeFrienshipRequest.Visible = true;
            btnRemoveFriend.Visible = true;
            btnFindUserByGenre.Visible = true;
        }



        /////// Messages //////
        private void btnMessages_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowMessageButton();
            refreshData("message");
            removePrivateData();

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string content = "Content";
            string title = "Title";
            string friendUserName = "";

            if (MessageDialog.sendMessage(ref title, ref content, ref friendUserName, user.UserName) == DialogResult.OK)
            {
                if (friendUserName.Equals(user.UserName))
                {
                    MessageBox.Show("You can't send message to yourself!");
                }
                else if (dataBase.FindUser(friendUserName) == null)
                {
                    MessageBox.Show("User Doesn't Exist!");
                }
                else {
                    if (string.IsNullOrEmpty(content))
                    {
                      MessageBox.Show("You are about to send an empty message", "Empty Message" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.SendMessage(title, content, friendUserName);
                        refreshData("message");
                        MessageBox.Show("Message Sent!");
                    }
                }
            }
        }

        private void btnTalkingWithFriend_Click(object sender, EventArgs e)
        {
            string friendUserName = "";
            string userName = user.UserName;
            if (MessageDialog.TalkingWithFriend(ref friendUserName, ref userName) == DialogResult.OK)
            {
                dgvLists.DataSource = user.ShowMessagesWithFriend(friendUserName);
                refreshData("myMessage");
                HideAllButtons();
                ShowConverstionButton();
                labConverstion.Text = "Converstion with " +friendUserName;
                labConverstion.Visible = true;
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            string content = "Content";
            string title = "Title";
            string friendUserName = labConverstion.Text.Remove(0,17);

            if (MessageDialog.replay(ref title, ref content, ref friendUserName, user.UserName) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(friendUserName))
                {
                    MessageBox.Show("Select Converstaion!");
                }
                else if (string.IsNullOrEmpty(content))
                {
                    MessageBox.Show("You are about to send an empty message", "Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.SendMessage(title, content, friendUserName);
                    dgvLists.DataSource = user.ShowMessagesWithFriend(friendUserName);
                    MessageBox.Show("Message Sent!");
                }
            }
        }

        protected void HideMessageButton()
        {
            btnSendMessage.Visible = false;
        }

        protected void ShowMessageButton()
        {
            btnSendMessage.Visible = true;
            btnTalkingWithFriend.Visible = true;
        }

        private void HideConverstionButton()
        {
            btnTalkingWithFriend.Visible = false;
            btnReplay.Visible = false;
            labConverstion.Visible = false;
        }

        private void ShowConverstionButton()
        {
            btnTalkingWithFriend.Visible = true;
            btnReplay.Visible = true;
        }

        /////// Playlist //////

        protected virtual void btnPlaylists_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowPlaylistButtons();
            refreshData("playlist");
        }


        private void btnWatchOnYoutube_Click(object sender, EventArgs e)
        {
            if (row != null && row.Index > -1)
            {
                string youtubeSong = row.Cells["Singer"].FormattedValue.ToString() + " - " + row.Cells["Song"].FormattedValue.ToString();
                new Forms.WatchOnYoutube(youtubeSong,this).Show();
            }
            else
                MessageBox.Show("Select A Song");

        }

        protected virtual void btnShowPlaylist_Click(object sender, EventArgs e)
        {
            string genre = "";
            if (MessageDialog.SelectGenre(ref genre) == DialogResult.OK)
            {
                dgvLists.DataSource = user.ShowPlaylistByGenres(genre, "0");
            }
        }

        private void btnSharePlaylist_Click(object sender, EventArgs e)
        {
            string song = "";
            string singer = "";
            string genre = "";
            if (MessageDialog.AddToPlaylist(ref singer, ref song, ref genre) == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(singer)) && !(string.IsNullOrEmpty(song)) && !(string.IsNullOrEmpty(genre)))
                {
                    if (!dataBase.CheckIfPlaylistExist(song, singer))
                    {
                        user.SharePlaylist(singer, song, genre);
                        MessageBox.Show("Song Added!");
                        // refresh temp list
                        refreshData("playlist");
                    }
                    else
                        MessageBox.Show("Song is already in the playlist!");
                }
                else
                    MessageBox.Show("You must fill al the fields!");
            }
        }

        protected void HidePlaylistButtons()
        {
            btnShowPlaylist.Visible = false;
            btnSharePlaylist.Visible = false;
            btnWatchOnYoutube.Visible = false;
        }

        protected void ShowPlaylistButtons()
        {
            btnShowPlaylist.Visible = true;
            btnSharePlaylist.Visible = true;
            btnWatchOnYoutube.Visible = true;
        }

        private void dgvLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = dgvLists.Rows[e.RowIndex];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string error = ex.ToString();
                row = null;
            }

        }

        // HideAll // 
        protected virtual void HideAllButtons()
        {
            HideFriendButtons();
            HidePostButtons();
            HidePostEditingButtons();
            HidePlaylistButtons();
            HideMessageButton();
            HideFriendshipRequestButton();
            HideConverstionButton();
        }
        // remove unwanted coulmuns
        protected void removePrivateData()
        {
            string[] privateData = { "Password", "Permission", "IdPost", "Priority" };
            foreach (DataGridViewColumn col in dgvLists.Columns)
            {
                if (col.Name == privateData[0] || col.Name == privateData[1] || col.Name == privateData[2] || col.Name == privateData[3])
                    col.Visible = false;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "WelcomeScreen")
                    Application.OpenForms[i].Dispose();
            }
            prevForm.Show();

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
                e.Cancel = true;
        }


        private void mnuItmChangeEmail_Click(object sender, EventArgs e)
        {
            string oldEmail = "";
            string newEmail = "";
            string res = null;
            if (MessageDialog.ChangeEmail(ref oldEmail, ref newEmail) == DialogResult.OK)
            {
                res = user.ChangeEmail(oldEmail, newEmail);
                MessageBox.Show(res);
            }
        }

        private void mnuItmChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = "";
            string newPassword = "";
            string res = null;
            if (MessageDialog.ChangePassword(ref oldPassword, ref newPassword) == DialogResult.OK)
            {
                res = user.ChangePassword(oldPassword, newPassword);
                MessageBox.Show(res);
                if (res.Equals("Password Changed!"))
                {
                    this.Dispose();
                    prevForm.Show();
                }
            }

        }

        private void mnuItmRemoveAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Warning", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                user.RemoveMyAccount();
                MessageBox.Show("Your Account Removed!\nThank you for using our social network,\nHope to see you soon");
                this.Dispose();
                prevForm.Show();
            }
        }

        private void mnuItmShowMyAccountDetails_Click(object sender, EventArgs e)
        {
            string type = "Unknown";
            if (user.GetType() == typeof(Admin)) type = "Admin";
            else if (user.GetType() == typeof(PremiumUser)) type = "Premium User";
            else if (user.GetType() == typeof(User)) type = "User";

            MessageBox.Show("Account Type: " + type + "\n\nAbout " + user.UserName + "\n\nName: " + user.FirstName + " " + user.LastName
                 + "\nEmail: " + user.Email + "\nGender: " + user.Gender
                + "\nFavorite Genre: " + user.FavoriteGenre, "About");

        }

        private void labFriendshipNotfication_Click(object sender, EventArgs e)
        {
            btnFriends.PerformClick();
            btnSeeFrienshipRequest.PerformClick();
        }

        private void btnFindUserByGenre_Click(object sender, EventArgs e)
        {
            string genre = "";
            if (MessageDialog.FindUserByGenre(ref genre) == DialogResult.OK)
            {
                dgvLists.DataSource = dataBase.FindUserByGenre(genre);
            }
        }

    }
}
