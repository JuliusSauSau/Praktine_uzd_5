using System;
using System.Windows.Forms;

namespace Projektinis_darbas_5
{
    public partial class Form1 : Form
    {
        private UserAccountManager accountManager;

        public Form1()
        {
            InitializeComponent();
            accountManager = new UserAccountManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (accountManager.VerifyUser(username, password))
            {
                Form3 mainForm = new Form3(username);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
