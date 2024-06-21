using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class CreateUser : Form
    {
        private Form loginForm;
        public CreateUser(Form loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd-MM-yyyy";
            comboBox1.Text = "View";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private bool Check_Fields()
        {
            return this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text));
        }

        private void Reset_Fields()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private bool UsernameExists(string username)
        {
            if (File.Exists("login.txt")) {
                string[] lines = File.ReadAllLines("login.txt");
                foreach(string line in lines)
                {
                    string fileUser = line.Split(',')[0];
                    if (fileUser.Equals(username))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void WriteToLoginFile()
        {
            string line = "\n"+usernameBox.Text + "," + passwordBox.Text + ","+comboBox1.Text+","+ firstBox.Text + "," + lastBox.Text + "," + datePicker.Text;
            if (File.Exists("login.txt")) {
                File.AppendAllText("login.txt",line);
            }
            else
            {
                File.WriteAllText("login.txt", line);

            }
        }

        private bool Match_Passwords()
        {
            if (!passwordBox.Text.Equals(retypePasswordBox.Text))
                return false;
            return true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Check_Fields())
            {
                MessageBox.Show("Please fill in all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(UsernameExists(usernameBox.Text))
            {
                MessageBox.Show("User already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Reset_Fields();
            }
            else if(!Match_Passwords())
            {
                MessageBox.Show("Passwords do not match!", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordBox.Text = "";
                retypePasswordBox.Text = "";
            }
            else
            {
                MessageBox.Show("Account Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WriteToLoginFile();
                Close();
            }

        }


    }
}
