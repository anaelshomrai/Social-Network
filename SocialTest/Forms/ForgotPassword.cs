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

    public partial class ForgotPassword : Form
    {
        WelcomeScreen parent = null;

        DB dataBase = DB.GetInstance();
        private string userName;
        private string email;


        public ForgotPassword()
        {
            InitializeComponent();
        }

        public ForgotPassword(WelcomeScreen previous)
        {
            InitializeComponent();
            parent = previous;
        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            email = txtEmail.Text;

            txtEmail.Clear();
            txtUserName.Clear();

            labResult.Text = dataBase.ForgetMyPassword(userName, email);
            labResult.BackColor = Color.Black;
            labResult.ForeColor = Color.White;
            labResult.Font = new Font("Bauhaus 93", 11, FontStyle.Bold);
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnFindPassword;
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
