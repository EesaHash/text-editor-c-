using System;
using System.IO;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool isMatch = false;
            string username = UsernameTxtBox.Text;
            string password = passwordTxtBox.Text;
            if (!File.Exists("login.txt"))
            {
                MessageBox.Show("Login.txt does not exist! Please create an account", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string[] credentials = File.ReadAllLines("login.txt");
            foreach (string credential in credentials)
            {
                string[] details = credential.Split(',');
                if (details[0] == username && details[1] == password)
                {
                    Account account = new Account();
                    account.Username = details[0];
                    account.Password = details[1];
                    account.Type = details[2];
                    account.FirstName = details[3];
                    account.LastName = details[4];
                    account.DateOfBirth = details[5];
                    isMatch = true;
                    new Editor(account, this).Show();
                    Hide();
                    break;
                }
            }
            if (!isMatch)
            {
                MessageBox.Show("Wrong username or password!", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                passwordTxtBox.Text = "";
            }
            
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            passwordTxtBox.UseSystemPasswordChar = true;
            passwordTxtBox.PasswordChar = '*';
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new CreateUser(this).Show();
        }
    }
}
