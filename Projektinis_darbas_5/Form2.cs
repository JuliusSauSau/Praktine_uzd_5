using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektinis_darbas_5
{
    public partial class Form2 : Form
    {
        private UserAccountManager accountManager;

        public Form2()
        {
            InitializeComponent();
            accountManager = new UserAccountManager();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accountManager.CreateUser(username, password);
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 mainForm = new Form3(username);
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
