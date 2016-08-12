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
    public partial class SignUpScreen : Form
    {
        WelcomeScreen parent = null;
        DB dataBase = DB.GetInstance();
        protected string userName;
        protected string fGenre;
        protected string gender;
        protected string lastName;
        protected string password;
        protected string email;
        protected string firstName;

        public SignUpScreen()
        {
            InitializeComponent();
        }
        public SignUpScreen(WelcomeScreen previous)
        {
            InitializeComponent();
            parent = previous;
            
        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSignUp;
            this.cboxFavoriteGenre.DataSource = Enum.GetValues(typeof(DB.Genres));
            labPayPal.Hide();
            txtPayPal.Hide();
            labSignUp.Hide();
            cboxFavoriteGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            rdbUser.Checked = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            EnableSignUp();
            if (btnSignUp.Enabled == true)
            {
                password = txtPassword.Text;
                email = txtEmail.Text;
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                fGenre = cboxFavoriteGenre.Text;
                if (rdbFemale.Checked) gender = rdbFemale.Text;
                else if (rdbMale.Checked) gender = rdbMale.Text;
                else gender = rdbNa.Text;
                userName = txtUserName.Text;
                MessageBox.Show("Sign Up Succefuly!");
                btnGoBack.PerformClick();
                if (rdbPremiumUser.Checked)
                {
                    MessageBox.Show("Premium Yay!");
                    dataBase.SignUp(1, firstName, lastName, email, gender, userName, password, fGenre);
                }
                else if (rdbUser.Checked)
                {
                    dataBase.SignUp(2, firstName, lastName, email, gender, userName, password, fGenre);
                }
            }
            else
            {
                btnSignUp.Enabled = true;
            }

        }


        private void rdbPremiumUser_CheckedChanged(object sender, EventArgs e)
        {
            txtPayPal.Show();
            labPayPal.Show();
            labPayPal.Location = new Point(37, 268);
            txtPayPal.Location = new Point(159, 268);
            btnSignUp.Location = new Point(171, 337);
            labSignUp.Location = new Point(156, 249);
        }

        private void rdbUser_CheckedChanged(object sender, EventArgs e)
        {
            txtPayPal.Hide();
            labPayPal.Hide();
            btnSignUp.Location = new Point(171, 337);
            labSignUp.Location = new Point(156, 249);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            if (txtFirstName.Focused)
            {
                labValidFirstName.Visible = true;
                labValidFirstName.Text = InputValidation.CheckFirstName(firstName);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            if (txtUserName.Focused)
            {
                labValidUserName.Visible = true;
                labValidUserName.Text = InputValidation.CheckUserName(userName);
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lastName = txtLastName.Text;
            if (txtLastName.Focused)
            {
                labValidLastName.Visible = true;
                labValidLastName.Text = InputValidation.CheckLastName(lastName);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
            if (txtPassword.Focused)
            {
                labValidPassword.Visible = true;
                labValidPassword.Text = InputValidation.CheckPassword(password);
            }
        }

        private void EnableSignUp()
        {
            labValidFirstName.Text = InputValidation.CheckFirstName(txtFirstName.Text);
            labValidLastName.Text = InputValidation.CheckLastName(txtLastName.Text);
            labValidPassword.Text = InputValidation.CheckPassword(txtPassword.Text);
            labValidUserName.Text = InputValidation.CheckUserName(txtUserName.Text);

            if ((labValidPassword.Text.Equals("") && labValidLastName.Text.Equals("") &&
                labValidUserName.Text.Equals("") && labValidFirstName.Text.Equals("") ) &&
                (rdbFemale.Checked || rdbMale.Checked || rdbNa.Checked) &&
                (rdbUser.Checked || rdbPremiumUser.Checked))
            {
                labSignUp.Show();
                this.btnSignUp.Enabled = true;
            }
            else
            {
                this.btnSignUp.Enabled = false;
                labSignUp.Show();
                labSignUp.Text = "Missing Information!";
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
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

        private void labFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
