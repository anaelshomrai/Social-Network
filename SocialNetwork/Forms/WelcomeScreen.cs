using System;
using System.IO;
using System.Windows.Forms;

namespace Social_Network.Forms
{
    public partial class WelcomeScreen : Form
    {

        DB dataBase = DB.GetInstance();
        private string userName;
        private string password;
        RealDataBase db = RealDataBase.Instance;


        public WelcomeScreen()
        {
            InitializeComponent();
            dataBase.InitLists();

        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbstractUser user = null;
            userName = txtUserName.Text;
            password = txtPassword.Text;
            user = dataBase.FindUser(userName, password);
           if (user != null)
            {
               if (user.GetType() == typeof(Admin))
                {
                    AdminHome h = new AdminHome(user.UserName, user.Password, this);
                    this.Hide();
                    h.Show();
                }
               else if (user.GetType() == typeof(User))
                {
                    Home h = new Home(user.UserName, user.Password, this);
                    this.Hide();
                    h.Show();
                }
                else if (user.GetType() == typeof(PremiumUser))
                {
                    PremiumUserHome h = new PremiumUserHome(user.UserName, user.Password, this);
                    this.Hide();
                    h.Show();
                }

            }
            else
            {
                MessageBox.Show("Not found");
            }
            ClearScreen();

        }

        private void ClearScreen()
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpScreen signUpScreen = new SignUpScreen(this);
            this.Hide();
            signUpScreen.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(this);
            this.Hide();
            forgotPassword.Show();
            
        }

        private void btnForgotUserName_Click(object sender, EventArgs e)
        {
            ForgotUserName forgotUserName = new ForgotUserName(this);
            this.Hide();
            forgotUserName.Show();
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

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            try {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sound.wav");
                player.Play();
            }catch(FileNotFoundException fileNotFound)
            {
                MessageBox.Show("Lioz, you deleted the sound in bin folder!");
            }
        }
    }
  }
