using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class About : Form
    {
        private Account account;
        public About(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void iconLbl_Click(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {
            firstLbl.Text = account.FirstName;
            lastLbl.Text = account.LastName;
            dobLbl.Text = account.DateOfBirth;
            permissionLbl.Text = account.Type;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
