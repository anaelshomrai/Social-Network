namespace Social_Network.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dgvLists = new System.Windows.Forms.DataGridView();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnPlaylists = new System.Windows.Forms.Button();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.btnEditPost = new System.Windows.Forms.Button();
            this.btnRemovePost = new System.Windows.Forms.Button();
            this.btnShowMyPosts = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.btnSeeFrienshipRequest = new System.Windows.Forms.Button();
            this.btnRemoveFriend = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnTalkingWithFriend = new System.Windows.Forms.Button();
            this.btnSharePlaylist = new System.Windows.Forms.Button();
            this.btnShowPlaylist = new System.Windows.Forms.Button();
            this.btnApproveRequest = new System.Windows.Forms.Button();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnUnlike = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnShowFeed = new System.Windows.Forms.Button();
            this.mnuAccountOptions = new System.Windows.Forms.MenuStrip();
            this.MnulUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmShowMyAccountDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmRemoveAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tltipMenuHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btnPending = new System.Windows.Forms.Button();
            this.btnFindUserByGenre = new System.Windows.Forms.Button();
            this.btnWatchOnYoutube = new System.Windows.Forms.Button();
            this.labConverstion = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.labFriendshipNotfication = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).BeginInit();
            this.mnuAccountOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLists
            // 
            this.dgvLists.AllowUserToAddRows = false;
            this.dgvLists.AllowUserToDeleteRows = false;
            this.dgvLists.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLists.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            this.dgvLists.Location = new System.Drawing.Point(12, 132);
            this.dgvLists.Name = "dgvLists";
            this.dgvLists.ReadOnly = true;
            this.dgvLists.Size = new System.Drawing.Size(730, 317);
            this.dgvLists.TabIndex = 1;
            this.dgvLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLists_CellContentClick);
            this.dgvLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLists_CellContentClick);
            // 
            // btnPost
            // 
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Bauhaus 93", 15.75F);
            this.btnPost.Location = new System.Drawing.Point(19, 46);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(113, 64);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriends.Font = new System.Drawing.Font("Bauhaus 93", 15.75F);
            this.btnFriends.Location = new System.Drawing.Point(138, 47);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(113, 64);
            this.btnFriends.TabIndex = 3;
            this.btnFriends.Text = "Friends";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Bauhaus 93", 15.75F);
            this.btnMessages.Location = new System.Drawing.Point(257, 47);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(113, 64);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylists.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylists.Location = new System.Drawing.Point(376, 47);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Size = new System.Drawing.Size(113, 64);
            this.btnPlaylists.TabIndex = 6;
            this.btnPlaylists.Text = "Playlists";
            this.btnPlaylists.UseVisualStyleBackColor = true;
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnAddPost
            // 
            this.btnAddPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPost.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnAddPost.Location = new System.Drawing.Point(752, 210);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(178, 32);
            this.btnAddPost.TabIndex = 7;
            this.btnAddPost.Text = "Add Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // btnEditPost
            // 
            this.btnEditPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPost.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnEditPost.Location = new System.Drawing.Point(752, 260);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(178, 32);
            this.btnEditPost.TabIndex = 8;
            this.btnEditPost.Text = "Edit Post";
            this.btnEditPost.UseVisualStyleBackColor = true;
            this.btnEditPost.Click += new System.EventHandler(this.btnEditPost_Click);
            // 
            // btnRemovePost
            // 
            this.btnRemovePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePost.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnRemovePost.Location = new System.Drawing.Point(752, 310);
            this.btnRemovePost.Name = "btnRemovePost";
            this.btnRemovePost.Size = new System.Drawing.Size(178, 32);
            this.btnRemovePost.TabIndex = 9;
            this.btnRemovePost.Text = "Remove Post";
            this.btnRemovePost.UseVisualStyleBackColor = true;
            this.btnRemovePost.Click += new System.EventHandler(this.btnRemovePost_Click);
            // 
            // btnShowMyPosts
            // 
            this.btnShowMyPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyPosts.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnShowMyPosts.Location = new System.Drawing.Point(752, 410);
            this.btnShowMyPosts.Name = "btnShowMyPosts";
            this.btnShowMyPosts.Size = new System.Drawing.Size(178, 32);
            this.btnShowMyPosts.TabIndex = 10;
            this.btnShowMyPosts.Text = "Show My Posts";
            this.btnShowMyPosts.UseVisualStyleBackColor = true;
            this.btnShowMyPosts.Click += new System.EventHandler(this.btnShowMyPosts_Click);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriend.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnAddFriend.Location = new System.Drawing.Point(752, 210);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(178, 32);
            this.btnAddFriend.TabIndex = 11;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // btnSeeFrienshipRequest
            // 
            this.btnSeeFrienshipRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeFrienshipRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeFrienshipRequest.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnSeeFrienshipRequest.Location = new System.Drawing.Point(752, 360);
            this.btnSeeFrienshipRequest.Name = "btnSeeFrienshipRequest";
            this.btnSeeFrienshipRequest.Size = new System.Drawing.Size(178, 32);
            this.btnSeeFrienshipRequest.TabIndex = 12;
            this.btnSeeFrienshipRequest.Text = "See Frienship Request";
            this.btnSeeFrienshipRequest.UseVisualStyleBackColor = true;
            this.btnSeeFrienshipRequest.Click += new System.EventHandler(this.btnSeeFrienshipRequest_Click);
            // 
            // btnRemoveFriend
            // 
            this.btnRemoveFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFriend.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnRemoveFriend.Location = new System.Drawing.Point(752, 260);
            this.btnRemoveFriend.Name = "btnRemoveFriend";
            this.btnRemoveFriend.Size = new System.Drawing.Size(178, 32);
            this.btnRemoveFriend.TabIndex = 13;
            this.btnRemoveFriend.Text = "Remove Friend";
            this.btnRemoveFriend.UseVisualStyleBackColor = true;
            this.btnRemoveFriend.Click += new System.EventHandler(this.btnRemoveFriend_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnSendMessage.Location = new System.Drawing.Point(752, 210);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(178, 32);
            this.btnSendMessage.TabIndex = 14;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnTalkingWithFriend
            // 
            this.btnTalkingWithFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTalkingWithFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalkingWithFriend.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnTalkingWithFriend.Location = new System.Drawing.Point(752, 260);
            this.btnTalkingWithFriend.Name = "btnTalkingWithFriend";
            this.btnTalkingWithFriend.Size = new System.Drawing.Size(178, 32);
            this.btnTalkingWithFriend.TabIndex = 15;
            this.btnTalkingWithFriend.Text = "Show Converstions";
            this.btnTalkingWithFriend.UseVisualStyleBackColor = true;
            this.btnTalkingWithFriend.Click += new System.EventHandler(this.btnTalkingWithFriend_Click);
            // 
            // btnSharePlaylist
            // 
            this.btnSharePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSharePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSharePlaylist.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnSharePlaylist.Location = new System.Drawing.Point(752, 210);
            this.btnSharePlaylist.Name = "btnSharePlaylist";
            this.btnSharePlaylist.Size = new System.Drawing.Size(178, 32);
            this.btnSharePlaylist.TabIndex = 16;
            this.btnSharePlaylist.Text = "Share Playlist";
            this.btnSharePlaylist.UseVisualStyleBackColor = true;
            this.btnSharePlaylist.Click += new System.EventHandler(this.btnSharePlaylist_Click);
            // 
            // btnShowPlaylist
            // 
            this.btnShowPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPlaylist.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnShowPlaylist.Location = new System.Drawing.Point(752, 260);
            this.btnShowPlaylist.Name = "btnShowPlaylist";
            this.btnShowPlaylist.Size = new System.Drawing.Size(178, 32);
            this.btnShowPlaylist.TabIndex = 17;
            this.btnShowPlaylist.Text = "Show Playlist";
            this.btnShowPlaylist.UseVisualStyleBackColor = true;
            this.btnShowPlaylist.Click += new System.EventHandler(this.btnShowPlaylist_Click);
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApproveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveRequest.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnApproveRequest.Location = new System.Drawing.Point(752, 210);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(178, 32);
            this.btnApproveRequest.TabIndex = 18;
            this.btnApproveRequest.Text = "Approve Request";
            this.btnApproveRequest.UseVisualStyleBackColor = true;
            this.btnApproveRequest.Click += new System.EventHandler(this.btnApproveRequest_Click);
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDenyRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyRequest.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnDenyRequest.Location = new System.Drawing.Point(752, 260);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(178, 32);
            this.btnDenyRequest.TabIndex = 19;
            this.btnDenyRequest.Text = "Deny Request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // btnLike
            // 
            this.btnLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnLike.Location = new System.Drawing.Point(752, 260);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(178, 32);
            this.btnLike.TabIndex = 21;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnAddLike_Click);
            // 
            // btnUnlike
            // 
            this.btnUnlike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnlike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlike.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnUnlike.Location = new System.Drawing.Point(752, 310);
            this.btnUnlike.Name = "btnUnlike";
            this.btnUnlike.Size = new System.Drawing.Size(178, 32);
            this.btnUnlike.TabIndex = 22;
            this.btnUnlike.Text = "Unlike";
            this.btnUnlike.UseVisualStyleBackColor = true;
            this.btnUnlike.Click += new System.EventHandler(this.btnUnlike_Click);
            // 
            // btnShare
            // 
            this.btnShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnShare.Location = new System.Drawing.Point(752, 360);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(178, 32);
            this.btnShare.TabIndex = 23;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnShowFeed
            // 
            this.btnShowFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFeed.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnShowFeed.Location = new System.Drawing.Point(752, 210);
            this.btnShowFeed.Name = "btnShowFeed";
            this.btnShowFeed.Size = new System.Drawing.Size(178, 32);
            this.btnShowFeed.TabIndex = 24;
            this.btnShowFeed.Text = "Show Feed";
            this.btnShowFeed.UseVisualStyleBackColor = true;
            this.btnShowFeed.Click += new System.EventHandler(this.btnShowFeed_Click);
            // 
            // mnuAccountOptions
            // 
            this.mnuAccountOptions.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            this.mnuAccountOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnulUserName});
            this.mnuAccountOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuAccountOptions.Name = "mnuAccountOptions";
            this.mnuAccountOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuAccountOptions.Size = new System.Drawing.Size(947, 26);
            this.mnuAccountOptions.TabIndex = 25;
            this.mnuAccountOptions.Text = "Account Options";
            this.tltipMenuHelp.SetToolTip(this.mnuAccountOptions, "Click Here to open additional setting for your account");
            // 
            // MnulUserName
            // 
            this.MnulUserName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MnulUserName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmChangeEmail,
            this.mnuItmChangePassword,
            this.mnuItmShowMyAccountDetails,
            this.mnuItmRemoveAccount});
            this.MnulUserName.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.MnulUserName.Name = "MnulUserName";
            this.MnulUserName.Size = new System.Drawing.Size(91, 22);
            this.MnulUserName.Text = "Hello User";
            // 
            // mnuItmChangeEmail
            // 
            this.mnuItmChangeEmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mnuItmChangeEmail.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            this.mnuItmChangeEmail.Image = global::Social_Network.Properties.Resources.mail;
            this.mnuItmChangeEmail.Name = "mnuItmChangeEmail";
            this.mnuItmChangeEmail.Size = new System.Drawing.Size(242, 22);
            this.mnuItmChangeEmail.Text = "Change My Email";
            this.mnuItmChangeEmail.Click += new System.EventHandler(this.mnuItmChangeEmail_Click);
            // 
            // mnuItmChangePassword
            // 
            this.mnuItmChangePassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mnuItmChangePassword.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            this.mnuItmChangePassword.Image = global::Social_Network.Properties.Resources.password;
            this.mnuItmChangePassword.Name = "mnuItmChangePassword";
            this.mnuItmChangePassword.Size = new System.Drawing.Size(242, 22);
            this.mnuItmChangePassword.Text = "Change My Password";
            this.mnuItmChangePassword.Click += new System.EventHandler(this.mnuItmChangePassword_Click);
            // 
            // mnuItmShowMyAccountDetails
            // 
            this.mnuItmShowMyAccountDetails.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mnuItmShowMyAccountDetails.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            this.mnuItmShowMyAccountDetails.Image = global::Social_Network.Properties.Resources.about;
            this.mnuItmShowMyAccountDetails.Name = "mnuItmShowMyAccountDetails";
            this.mnuItmShowMyAccountDetails.Size = new System.Drawing.Size(242, 22);
            this.mnuItmShowMyAccountDetails.Text = "Show My Account Details";
            this.mnuItmShowMyAccountDetails.Click += new System.EventHandler(this.mnuItmShowMyAccountDetails_Click);
            // 
            // mnuItmRemoveAccount
            // 
            this.mnuItmRemoveAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mnuItmRemoveAccount.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            this.mnuItmRemoveAccount.Image = global::Social_Network.Properties.Resources.delete;
            this.mnuItmRemoveAccount.Name = "mnuItmRemoveAccount";
            this.mnuItmRemoveAccount.Size = new System.Drawing.Size(242, 22);
            this.mnuItmRemoveAccount.Text = "Remove My Account";
            this.mnuItmRemoveAccount.Click += new System.EventHandler(this.mnuItmRemoveAccount_Click);
            // 
            // btnPending
            // 
            this.btnPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnPending.Location = new System.Drawing.Point(752, 310);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(178, 32);
            this.btnPending.TabIndex = 27;
            this.btnPending.Text = "Waiting For Approvel";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnFindUserByGenre
            // 
            this.btnFindUserByGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUserByGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUserByGenre.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnFindUserByGenre.Location = new System.Drawing.Point(752, 310);
            this.btnFindUserByGenre.Name = "btnFindUserByGenre";
            this.btnFindUserByGenre.Size = new System.Drawing.Size(178, 32);
            this.btnFindUserByGenre.TabIndex = 28;
            this.btnFindUserByGenre.Text = "Find User By Genre";
            this.btnFindUserByGenre.UseVisualStyleBackColor = true;
            this.btnFindUserByGenre.Click += new System.EventHandler(this.btnFindUserByGenre_Click);
            // 
            // btnWatchOnYoutube
            // 
            this.btnWatchOnYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchOnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchOnYoutube.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnWatchOnYoutube.Location = new System.Drawing.Point(752, 310);
            this.btnWatchOnYoutube.Name = "btnWatchOnYoutube";
            this.btnWatchOnYoutube.Size = new System.Drawing.Size(178, 32);
            this.btnWatchOnYoutube.TabIndex = 29;
            this.btnWatchOnYoutube.Text = "Watch On Youtube";
            this.btnWatchOnYoutube.UseVisualStyleBackColor = true;
            this.btnWatchOnYoutube.Click += new System.EventHandler(this.btnWatchOnYoutube_Click);
            // 
            // labConverstion
            // 
            this.labConverstion.AutoSize = true;
            this.labConverstion.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labConverstion.Location = new System.Drawing.Point(12, 114);
            this.labConverstion.Name = "labConverstion";
            this.labConverstion.Size = new System.Drawing.Size(132, 18);
            this.labConverstion.TabIndex = 30;
            this.labConverstion.Text = "Converstion With ";
            // 
            // btnReplay
            // 
            this.btnReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnReplay.Location = new System.Drawing.Point(752, 210);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(178, 32);
            this.btnReplay.TabIndex = 31;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // labFriendshipNotfication
            // 
            this.labFriendshipNotfication.AutoSize = true;
            this.labFriendshipNotfication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labFriendshipNotfication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labFriendshipNotfication.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.labFriendshipNotfication.ForeColor = System.Drawing.Color.Red;
            this.labFriendshipNotfication.Location = new System.Drawing.Point(16, 26);
            this.labFriendshipNotfication.Name = "labFriendshipNotfication";
            this.labFriendshipNotfication.Size = new System.Drawing.Size(338, 18);
            this.labFriendshipNotfication.TabIndex = 26;
            this.labFriendshipNotfication.Text = "Will appear if user has new friendship requests";
            this.labFriendshipNotfication.Visible = false;
            this.labFriendshipNotfication.Click += new System.EventHandler(this.labFriendshipNotfication_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnGoBack.Location = new System.Drawing.Point(873, 29);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(62, 53);
            this.btnGoBack.TabIndex = 20;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(947, 458);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.labConverstion);
            this.Controls.Add(this.btnWatchOnYoutube);
            this.Controls.Add(this.btnFindUserByGenre);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.labFriendshipNotfication);
            this.Controls.Add(this.btnShowFeed);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnUnlike);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnApproveRequest);
            this.Controls.Add(this.btnShowPlaylist);
            this.Controls.Add(this.btnSharePlaylist);
            this.Controls.Add(this.btnTalkingWithFriend);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnRemoveFriend);
            this.Controls.Add(this.btnSeeFrienshipRequest);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.btnShowMyPosts);
            this.Controls.Add(this.btnRemovePost);
            this.Controls.Add(this.btnEditPost);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.btnPlaylists);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.dgvLists);
            this.Controls.Add(this.mnuAccountOptions);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuAccountOptions;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).EndInit();
            this.mnuAccountOptions.ResumeLayout(false);
            this.mnuAccountOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnPlaylists;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Button btnEditPost;
        private System.Windows.Forms.Button btnRemovePost;
        private System.Windows.Forms.Button btnShowMyPosts;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.Button btnSeeFrienshipRequest;
        private System.Windows.Forms.Button btnRemoveFriend;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnTalkingWithFriend;
        private System.Windows.Forms.Button btnSharePlaylist;
        private System.Windows.Forms.Button btnShowPlaylist;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnUnlike;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnShowFeed;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeEmail;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuItmRemoveAccount;
        private System.Windows.Forms.ToolTip tltipMenuHelp;
        private System.Windows.Forms.Label labFriendshipNotfication;
        private System.Windows.Forms.ToolStripMenuItem mnuItmShowMyAccountDetails;
        protected System.Windows.Forms.DataGridView dgvLists;
        protected System.Windows.Forms.ToolStripMenuItem MnulUserName;
        protected System.Windows.Forms.MenuStrip mnuAccountOptions;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnFindUserByGenre;
        private System.Windows.Forms.Button btnWatchOnYoutube;
        private System.Windows.Forms.Label labConverstion;
        private System.Windows.Forms.Button btnReplay;
    }
}