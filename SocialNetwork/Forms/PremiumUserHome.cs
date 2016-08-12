using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Network.Forms
{
    public partial class PremiumUserHome : Social_Network.Forms.Home
    {
        DB dataBase = DB.GetInstance();
        AbstractUser user = null;
        PremiumUser premiumUser = null;
        string genre;

        public PremiumUserHome()
        {
            InitializeComponent();
        }

        public PremiumUserHome(string userName, string password, WelcomeScreen previous)
            :base(userName, password, previous)
        {
            InitializeComponent();
            user = dataBase.FindUser(userName, password);
        }

        protected override void Home_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            premiumUser = (PremiumUser)user;  
            HideAllButtons();
            MnulUserName.Font = new System.Drawing.Font("Bauhaus 93" ,11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnulUserName.ForeColor = Color.DarkSalmon;
            MnulUserName.Text = "Welcome " + premiumUser.UserName;
            checkFriendshipRequests();
            this.mnuAccountOptions.BackColor = System.Drawing.Color.Black;

        }

        protected void HideNewPlaylstdButtons()
        {
            gboxOrder.Visible = false;
        }

        protected void ShowNewPlaylistButtons()
        {
            gboxOrder.Visible = true;
        }

        protected override void btnPlaylists_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowPlaylistButtons();
            refreshData("playlist");
        }

        protected override void btnFriends_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            refreshData("friends");
            removePrivateData();
            ShowFriendButtons();
        }

        protected override void HideAllButtons()
        {
            base.HideAllButtons();
            HideNewPlaylstdButtons();
        }

        protected override void btnShowPlaylist_Click(object sender, EventArgs e)
        {
            genre = "";
            if (MessageDialog.SelectGenre(ref genre) == DialogResult.OK)
            {
                dgvLists.DataSource = user.ShowPlaylistByGenres(genre, "0");
                ShowNewPlaylistButtons();
            }
            
        }

        private void rdbABCSingers_CheckedChanged(object sender, EventArgs e)
        {
            dgvLists.DataSource = user.ShowPlaylistByGenres(genre, "1");
        }

        private void rdbABCSongs_CheckedChanged(object sender, EventArgs e)
        {
            dgvLists.DataSource = user.ShowPlaylistByGenres(genre, "2");
        }


    }
}
