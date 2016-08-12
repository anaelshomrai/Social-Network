using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Social_Network.Properties;


namespace Social_Network.Forms
{
    public partial class MessageDialog : Form
    {
        public MessageDialog()
        {
            InitializeComponent();

        }

        public static DialogResult TalkingWithFriend(ref string friendUserName, ref string userName)
        {
            DB dataBase = DB.GetInstance();
            Form form = new Form();

            Label labChooseFriend = new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            ComboBox cobFriends = new ComboBox();

            labChooseFriend.Font = new Font("Bauhaus 93", 11F);
            cobFriends.Font = new Font("Bauhaus 93", 11F);
            btnOk.Font = new Font("Bauhaus 93", 11F);
            btnCancel.Font = new Font("Bauhaus 93", 11F);

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

        
            form.BackColor = System.Drawing.Color.LightSkyBlue;

            labChooseFriend.Text = "Choose Friend : ";

            cobFriends.DataSource = dataBase.Friendconversations(userName).Select(l => l.UserName).ToList();
            cobFriends.DropDownStyle = ComboBoxStyle.DropDownList;

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Text = "Show Converstion : ";
            labChooseFriend.SetBounds(12, 21, 115, 16);
            cobFriends.SetBounds(133, 20, 121, 21);
            btnOk.SetBounds(216, 70, 75, 23);
            btnCancel.SetBounds(297, 70, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(390, 115);
            form.Controls.AddRange(new Control[] { labChooseFriend, cobFriends, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;


            DialogResult dialogResult = form.ShowDialog();
            friendUserName = cobFriends.Text;
            return dialogResult;
        }


        public static DialogResult sendMessage(ref string title, ref string content, ref string friend, string userName)
        {
            DB dataBase = DB.GetInstance();
            Form form = new Form();

            Label labFriendUserName = new Label();
            Label labTitle = new Label();
            Label labContent = new Label();
            TextBox txtContent = new TextBox();
            TextBox txtTitle = new TextBox();
            TextBox txtFriendUserName = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();  

            labTitle.Font = new Font("Bauhaus 93", 11F);
            labFriendUserName.Font = new Font("Bauhaus 93", 11F);
            labContent.Font = new Font("Bauhaus 93", 11F);
            txtContent.Font = new Font("Bauhaus 93", 9F);
            txtFriendUserName.Font = new Font("Bauhaus 93", 9F);
            
            txtTitle.Font = new Font("Bauhaus 93", 9F);
            btnOk.Font = new Font("Bauhaus 93", 11F);
            btnCancel.Font = new Font("Bauhaus 93", 11F);

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            txtContent.BorderStyle = BorderStyle.FixedSingle;
            txtFriendUserName.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            form.BackColor = System.Drawing.Color.LightSkyBlue;


            labFriendUserName.Text = "Friend User Name : ";
            labTitle.Text = "Title : ";
            labContent.Text = "Content : ";

            txtContent.Multiline = true;

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Text = "Send Message";
            labFriendUserName.SetBounds(12, 20, 135, 15);
            labTitle.SetBounds(12, 47, 135, 15);
            labContent.SetBounds(12, 82, 135, 15);
            txtFriendUserName.SetBounds(150, 20, 107, 20);
            txtTitle.SetBounds(150, 47, 107, 20);
            txtContent.SetBounds(15, 98, 357, 82);
            btnOk.SetBounds(216, 192, 75, 23);
            btnCancel.SetBounds(297, 192, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(390, 236);
            form.Controls.AddRange(new Control[] { labFriendUserName, labTitle, labContent, txtFriendUserName, txtTitle, txtContent, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;;


            DialogResult dialogResult = form.ShowDialog();
            content = txtContent.Text;
            title = txtTitle.Text;
            friend = txtFriendUserName.Text;
            return dialogResult;
        }

        public static DialogResult replay(ref string title, ref string content, ref string friend, string userName)
        {
            DB dataBase = DB.GetInstance();
            Form form = new Form();

            Label labFriendUserName = new Label();
            Label labTitle = new Label();
            Label labContent = new Label();
            TextBox txtContent = new TextBox();
            TextBox txtTitle = new TextBox();
            TextBox txtFriendUserName = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            labTitle.Font = new Font("Bauhaus 93", 11F);
            labFriendUserName.Font = new Font("Bauhaus 93", 11F);
            labContent.Font = new Font("Bauhaus 93", 11F);
            txtContent.Font = new Font("Bauhaus 93", 9F);
            txtFriendUserName.Font = new Font("Bauhaus 93", 9F);

            txtTitle.Font = new Font("Bauhaus 93", 9F);
            btnOk.Font = new Font("Bauhaus 93", 11F);
            btnCancel.Font = new Font("Bauhaus 93", 11F);

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            txtContent.BorderStyle = BorderStyle.FixedSingle;
            txtFriendUserName.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            form.BackColor = System.Drawing.Color.LightSkyBlue;

            txtFriendUserName.Text = friend;
            txtFriendUserName.Enabled = false;

            labFriendUserName.Text = "Friend User Name : ";
            labTitle.Text = "Title : ";
            labContent.Text = "Content : ";

            txtContent.Multiline = true;

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Text = "Send Message";
            labFriendUserName.SetBounds(12, 20, 135, 15);
            labTitle.SetBounds(12, 47, 135, 15);
            labContent.SetBounds(12, 82, 135, 15);
            txtFriendUserName.SetBounds(150, 20, 107, 20);
            txtTitle.SetBounds(150, 47, 107, 20);
            txtContent.SetBounds(15, 98, 357, 82);
            btnOk.SetBounds(216, 192, 75, 23);
            btnCancel.SetBounds(297, 192, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(390, 236);
            form.Controls.AddRange(new Control[] { labFriendUserName, labTitle, labContent, txtFriendUserName, txtTitle, txtContent, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk; ;


            DialogResult dialogResult = form.ShowDialog();
            content = txtContent.Text;
            title = txtTitle.Text;
            friend = txtFriendUserName.Text;
            return dialogResult;
        } 

        public static DialogResult InputBox(string title, string promptText, ref string value, bool isMultiLine)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            label.Font = new Font("Bauhaus 93", 11F);
            textBox.Font = new Font("Bauhaus 93", 9F);
            buttonOk.Font = new Font("Bauhaus 93", 11F);
            buttonCancel.Font = new Font("Bauhaus 93", 11F);

            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatStyle = FlatStyle.Flat;

            buttonOk.Cursor = Cursors.Hand;
            buttonCancel.Cursor = Cursors.Hand;
            
            form.BackColor = System.Drawing.Color.LightSkyBlue;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 360, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(410, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            if (isMultiLine)
            {
                textBox.Multiline = true;
                textBox.SetBounds(12, 36, 372, 83);
                form.ClientSize = new Size(405, 180);
            }


            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult SelectGenre(ref string genre)
        {
            Form form = new Form();

            Label labChooseGenre = new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            ComboBox cobGenres = new ComboBox();


            btnOk.Font = new Font("Bauhaus 93", 11F);
            btnCancel.Font = new Font("Bauhaus 93", 11F);
            cobGenres.Font = new Font("Bauhaus 93", 11F);

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            form.BackColor = System.Drawing.Color.LightSkyBlue;

            Array genres = Enum.GetValues(typeof(DB.Genres));
            cobGenres.DataSource = Enum.GetValues(typeof(DB.Genres));
            cobGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            
            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Text = "Show Playlist";
            labChooseGenre.SetBounds(12, 22, 95, 15);
            cobGenres.SetBounds(113, 22, 128, 21);
            btnOk.SetBounds(231, 70, 75, 23);
            btnCancel.SetBounds(312, 70, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(415, 127);
            form.Controls.AddRange(new Control[] { labChooseGenre, cobGenres, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;


            DialogResult dialogResult = form.ShowDialog();
            genre = cobGenres.SelectedValue.ToString();
            return dialogResult;


        }

        public static DialogResult AddToPlaylist(ref string song, ref string singer,ref string genre)
        {
            Form form = new Form();

            Label labChooseGenre = new Label();
            Label labSong = new Label();
            Label labSinger= new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            ComboBox cobGenres = new ComboBox();
            TextBox txtSong = new TextBox();
            TextBox txtSinger = new TextBox();

            labChooseGenre.Text = "Choose Genre :";
            labChooseGenre.Font = new Font("Bauhaus 93", 11F);
            labSong.Text = "Song : ";
            labSong.Font = new Font("Bauhaus 93", 11F);
            labSinger.Text = "Singer : ";
            labSinger.Font = new Font("Bauhaus 93", 11F);
            btnOk.Font = new Font("Bauhaus 93", 11F);
            btnCancel.Font = new Font("Bauhaus 93", 11F);
            cobGenres.Font = new Font("Bauhaus 93", 11F);

            txtSong.BorderStyle = BorderStyle.FixedSingle;
            txtSinger.BorderStyle = BorderStyle.FixedSingle;

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            form.BackColor = System.Drawing.Color.LightSkyBlue;

            cobGenres.DataSource = Enum.GetValues(typeof(DB.Genres));
            cobGenres.DropDownStyle = ComboBoxStyle.DropDownList;

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Text = "Add To Playlist";
            labChooseGenre.SetBounds(12, 22, 110, 15);
            labSong.SetBounds(12, 50, 100, 15);
            labSinger.SetBounds(12, 76, 100, 15);
            txtSong.SetBounds(125, 75, 146, 20); 
            txtSinger.SetBounds(125, 50, 146, 20);
            cobGenres.SetBounds(125, 22, 146, 21);
            btnOk.SetBounds(216, 125, 75, 23);
            btnCancel.SetBounds(297, 125, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 190);
            form.Controls.AddRange(new Control[] { labChooseGenre, cobGenres, labSong, txtSong, labSinger, txtSinger,btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;


            DialogResult dialogResult = form.ShowDialog();
            genre = cobGenres.SelectedValue.ToString();
            singer = txtSinger.Text;
            song = txtSong.Text;
            return dialogResult;


        }

        public static DialogResult ChangePassword(ref string oldPassword, ref string newPassword)
        {
            Form form = new Form();

            Label labOldPassword = new Label();
            Label labNewPassword = new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            TextBox txtOldPassword = new TextBox();
            TextBox txtNewPassword = new TextBox();



            labOldPassword.Text = "Enter Your Old Password : ";
            labNewPassword.Text = "Enter Your New Password : ";

            form.BackColor = System.Drawing.Color.LightSkyBlue;
            labNewPassword.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            labOldPassword.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnOk.Font = new System.Drawing.Font("Bauhaus 93", 11F);


            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;


            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;


            form.Text = "Change Password";
            labOldPassword.SetBounds(28, 40, 185, 13);
            labNewPassword.SetBounds(28,70, 185, 13);
            txtOldPassword.SetBounds(230, 40, 126, 15);
            txtNewPassword.SetBounds(230, 70, 126, 15);
            btnOk.SetBounds(216, 117, 75, 23);
            btnCancel.SetBounds(297, 117, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 190);
            form.Controls.AddRange(new Control[] { labOldPassword, labNewPassword, txtOldPassword, txtNewPassword, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;

            DialogResult dialogResult = form.ShowDialog();
            oldPassword = txtOldPassword.Text;
            newPassword = txtNewPassword.Text;
            return dialogResult;
        }

        public static DialogResult ChangeEmail(ref string oldPassword, ref string newPassword)
        {
            Form form = new Form();

            Label labOldEmail = new Label();
            Label labNewEmail = new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            TextBox txtOldEmail = new TextBox();
            TextBox txtNewEmail = new TextBox();


            labOldEmail.Text = "Enter Your Old Email : ";
            labNewEmail.Text = "Enter Your New Email : ";

            form.BackColor = System.Drawing.Color.LightSkyBlue;
            labOldEmail.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            labNewEmail.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnOk.Font = new System.Drawing.Font("Bauhaus 93", 11F);

            txtOldEmail.BorderStyle = BorderStyle.FixedSingle;
            txtNewEmail.BorderStyle = BorderStyle.FixedSingle;

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            form.Text = "Change Email";
            labOldEmail.SetBounds(28, 40, 185, 13);
            labNewEmail.SetBounds(28, 70, 185, 13);
            txtOldEmail.SetBounds(230, 40, 126, 15);
            txtNewEmail.SetBounds(230, 70, 126, 15);
            btnOk.SetBounds(216, 117, 75, 23);
            btnCancel.SetBounds(297, 117, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 190);
            form.Controls.AddRange(new Control[] { labOldEmail, labNewEmail, txtOldEmail, txtNewEmail, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;

            DialogResult dialogResult = form.ShowDialog();
            oldPassword = txtOldEmail.Text;
            newPassword = txtNewEmail.Text;
            return dialogResult;
        }

        public static DialogResult ChangePermission(ref int permission)
        {
            Form form = new Form();

            Label labTypeOfPermission = new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            GroupBox gboxPermission = new GroupBox();
            RadioButton rdbAdmin = new RadioButton();
            RadioButton rdbPremiumUser = new RadioButton();
            RadioButton rdbUser = new RadioButton();

            rdbPremiumUser.UseVisualStyleBackColor = true;
            rdbAdmin.UseVisualStyleBackColor = true;
            rdbUser.UseVisualStyleBackColor = true;

            form.BackColor = System.Drawing.Color.LightSkyBlue;
            labTypeOfPermission.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            rdbAdmin.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            rdbPremiumUser.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            rdbUser.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnOk.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            gboxPermission.Font = new System.Drawing.Font("Bauhaus 93", 11F);


            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            labTypeOfPermission.Text = "What type of permission you want to grant?"; 
            gboxPermission.Text = "Types of permissions: ";

            rdbUser.Text = "User";
            rdbPremiumUser.Text = "Premium User";
            rdbAdmin.Text = "Admin";
            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Text = "Change Permission";
            labTypeOfPermission.SetBounds(0, 0, 239, 15);


            rdbAdmin.SetBounds(6, 19, 68, 20);
            rdbPremiumUser.SetBounds(80, 19, 114, 20);
            rdbUser.SetBounds(200, 19, 53, 20);
            gboxPermission.SetBounds(12, 28, 281, 47);
            btnCancel.SetBounds(297, 90, 75, 23);
            btnOk.SetBounds(216, 90, 75, 23);

            gboxPermission.Controls.Add(rdbAdmin);
            gboxPermission.Controls.Add(rdbPremiumUser);
            gboxPermission.Controls.Add(rdbUser);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(384, 125);
            form.Controls.AddRange(new Control[] { labTypeOfPermission, gboxPermission, btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            DialogResult dialogResult = form.ShowDialog();
            if (rdbAdmin.Checked) permission = 1;
            else if (rdbPremiumUser.Checked) permission = 2;
            else if (rdbUser.Checked) permission = 3;
            return dialogResult;
        }

        public static DialogResult FindUserByGenre(ref string genre)
        {
            Form form = new Form();

            Label labChooseGenre = new Label();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            ComboBox cobGenre = new ComboBox();

            labChooseGenre.Text = " Choose Genre :";
            

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            cobGenre.DataSource = Enum.GetValues(typeof(DB.Genres));
            cobGenre.DropDownStyle = ComboBoxStyle.DropDownList;

            form.BackColor = System.Drawing.Color.LightSkyBlue;
            cobGenre.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            labChooseGenre.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnOk.Font = new System.Drawing.Font("Bauhaus 93", 11F);
            btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 11F);

            btnOk.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;

            btnOk.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;

            form.Text = "Find User By Genre";
            labChooseGenre.SetBounds(12, 21, 115, 16);
            cobGenre.SetBounds(133, 20, 121, 21);
            btnOk.SetBounds(216, 60, 75, 23);
            btnCancel.SetBounds(297, 60, 75, 23);

            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 137);
            form.Controls.AddRange(new Control[] { labChooseGenre, cobGenre,btnOk, btnCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnOk;

            DialogResult dialogResult = form.ShowDialog();
            genre = cobGenre.Text;
            return dialogResult;
        }

    }
}
