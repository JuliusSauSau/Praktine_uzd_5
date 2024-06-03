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
    public partial class Form3 : Form
    {
        private PasswordManager passwordManager;
        private string username;

        public Form3(string username)
        {
            InitializeComponent();
            this.username = username;
            passwordManager = new PasswordManager(username);

            this.FormClosing += Form3_FormClosing;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            passwordManager.DecryptFile();
            LoadPasswords();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            passwordManager.EncryptFile();
        }



        private void Titlelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Titlelist.SelectedItem != null)
            {
                var entry = passwordManager.FindPassword(Titlelist.SelectedItem.ToString());
                if (entry != null)
                {
                    titlebox.Text = entry.Name;
                    urlbox.Text = entry.Url;
                    commentbox.Text = entry.Comment;
                    passwordbox.Text = CryptoHelper.DecryptString(entry.Password);
                }
            }
        }

        private void list_searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_for_titlebtn_Click(object sender, EventArgs e)
        {
            var searchText = list_searchbox.Text.ToLower();
            var matchedEntries = passwordManager.ReadPasswords()
                                                .Where(entry => entry.Name.ToLower().Contains(searchText))
                                                .ToList();
            Titlelist.Items.Clear();
            foreach (var entry in matchedEntries)
            {
                Titlelist.Items.Add(entry.Name);
            }
        }



        private void titlebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_passwordbtn_Click(object sender, EventArgs e)
        {
            var newEntry = new PasswordEntry
            {
                Name = titlebox.Text,
                Password = CryptoHelper.EncryptString(passwordbox.Text),
                Url = urlbox.Text,
                Comment = commentbox.Text
            };

            passwordManager.UpdatePassword(titlebox.Text, newEntry);
            MessageBox.Show("Password updated successfully!");
            LoadPasswords();
        }



        private void new_titlebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_urlbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_commentbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate_passwordbtn_Click(object sender, EventArgs e)
        {
            new_passwordbox.Text = PasswordGenerator.GenerateRandomPassword();
        }

        private void save_new_titlebtn_Click(object sender, EventArgs e)
        {
            var entry = new PasswordEntry
            {
                Name = new_titlebox.Text,
                Password = CryptoHelper.EncryptString(new_passwordbox.Text),
                Url = new_urlbox.Text,
                Comment = new_commentbox.Text
            };

            passwordManager.AddPassword(entry);
            MessageBox.Show("Password added successfully!");
            LoadPasswords();
        }



        private void exitbtn_Click(object sender, EventArgs e)
        {
            passwordManager.EncryptFile();
            this.Close();
        }



        private void LoadPasswords()
        {
            Titlelist.Items.Clear();
            var passwords = passwordManager.ReadPasswords();
            foreach (var entry in passwords)
            {
                Titlelist.Items.Add(entry.Name);
            }
        }
    }
}
