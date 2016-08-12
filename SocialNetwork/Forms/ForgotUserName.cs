using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network.Forms
{
    public partial class ForgotUserName : Form
    {
        WelcomeScreen parent = null;
        private string password;
        private string email;

        DB dataBase = DB.GetInstance();

        public ForgotUserName()
        {
            InitializeComponent();
        }

        public ForgotUserName(WelcomeScreen previous)
        {
            InitializeComponent();
            parent = previous;
        }

        private void ForgotUserName_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnFindUserName;
        }

        private void btnFindUserName_Click(object sender, EventArgs e)
        {
            password = txtPassword.Text;
            email = txtEmail.Text;

            txtEmail.Clear();
            txtPassword.Clear();

            labResult.Text = dataBase.ForgetMyUserName(password, email);
            labResult.BackColor = Color.Black;
            labResult.ForeColor = Color.White;
            labResult.Font = new Font("Bauhaus 93", 11, FontStyle.Bold);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void labResult_Click(object sender, EventArgs e)
        {

        }
    }
}
