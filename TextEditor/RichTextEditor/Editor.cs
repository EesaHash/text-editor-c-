using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class Editor : Form
    {
        private Account account;
        private string loadedFileDirectory;
        private Form loginForm;
        public Editor(Account account, Form loginForm)
        {
            this.account = account;
            this.loginForm = loginForm;
            loadedFileDirectory = "";
            InitializeComponent();
        }

        private void Set_Privileges()
        {
            if (account.Type == "View")
            {
                Left.Enabled = false;
                Top.Enabled = false;
                newToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                richTxtBox.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }
        }

        private bool Contents_Changed()
        {
            
            if (!loadedFileDirectory.Equals("") && loadedFileDirectory != null)
            {
                if (File.Exists(loadedFileDirectory))
                {
                    string fileContents = File.ReadAllText(loadedFileDirectory);
                    string screenContents = richTxtBox.Text;
                    if (!fileContents.Equals(richTxtBox.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void Editor_Load(object sender, EventArgs e)
        {
            Font loadedFont = richTxtBox.Font;  
            this.usernameLblEditor.Text = account.FirstName + " " + account.LastName + " ";
            this.permissionLbl.Text = account.Type + " ";
            richTxtBox.SelectionFont = new Font(loadedFont.FontFamily, 8, loadedFont.Style);
            fontSizeComboBox.Text = richTxtBox.SelectionFont.Size.ToString();
            Set_Privileges();
        }

        private void New_Strip(object sender, EventArgs e)
        {
            New();
        }

        private void New_Menu(object sender, EventArgs e)
        {
            New();
        }

        private void New()
        {
            if (Contents_Changed())
            {
                DialogResult result = MessageBox.Show("Save File? Unsaved content will be lost!", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    WriteToFile();
                }
            }
            DirectoryLbl.Text = "No File Loaded";
            loadedFileDirectory = "";
            this.richTxtBox.Text = "";
        }

        private void TopOpen_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void Open_Menu(object sender, EventArgs e)
        {
            Open();
        }

        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                loadedFileDirectory = openFileDialog.FileName;
                DirectoryLbl.Text = loadedFileDirectory;
                WriteToTextBox();
            }
        }

        private void WriteToTextBox()
        {
            string ext = Path.GetExtension(loadedFileDirectory);
            if (ext == ".txt")
            {
                this.richTxtBox.LoadFile(loadedFileDirectory, RichTextBoxStreamType.PlainText);
            }
            else if (ext == ".rtf")
            {
                this.richTxtBox.LoadFile(loadedFileDirectory, RichTextBoxStreamType.RichText);
            }
        }

        private void WriteToFile()
        {
            string ext = Path.GetExtension(loadedFileDirectory);
            if (ext == ".txt")
            {
                File.WriteAllText(loadedFileDirectory, this.richTxtBox.Text);
            }
            else if (ext == ".rtf")
            {
                File.WriteAllText(loadedFileDirectory, this.richTxtBox.Rtf);
            }
        }


        private void Save_Strip(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loadedFileDirectory))
                WriteToFile();
            else
                Save();
        }

        private void Save_Menu(object sender, EventArgs e)
        {
            Save_Strip(sender, e);
        }
        private void Save_As_Strip(object sender, EventArgs e)
        {
            Save();
        }

        private void Save_As_Menu(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files RTF files (*.rtf)|*.rtf|(*.txt)|*.txt";
            saveFileDialog.Title = "Select location";

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                loadedFileDirectory = saveFileDialog.FileName;
                DirectoryLbl.Text = loadedFileDirectory;
                WriteToFile();
            }
        }



        private void Cut_Click(object sender, EventArgs e)
        {
            if (this.richTxtBox.SelectionLength != 0)
            {
                this.richTxtBox.Cut();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (this.richTxtBox.SelectionLength != 0)
            {
                this.richTxtBox.Copy();
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            this.richTxtBox.Paste();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTxtBox.SelectionLength != 0)
            {
                this.richTxtBox.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTxtBox.SelectionLength != 0)
            {
                this.richTxtBox.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTxtBox.Paste();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void Bold_Click(object sender, EventArgs e)
        {


            /*if (richTxtBox.SelectionFont != null)
            {
                Font currentFont = richTxtBox.SelectionFont;
                FontStyle newFontStyle = FontStyle.Regular;

                if (currentFont.Bold)
                {
                    if (currentFont.Italic && currentFont.Underline) {
                        newFontStyle = FontStyle.Italic | FontStyle.Underline;
                    }
                    else if (currentFont.Italic)
                    {
                        newFontStyle = FontStyle.Italic;
                    }
                    else if (currentFont.Underline)
                    {
                        newFontStyle = FontStyle.Underline;
                    }
                    bold.Checked = false;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                    bold.Checked = true;
                }

                richTxtBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }*/
            
            float fontSize = richTxtBox.SelectionFont.Size;
            bool isItalic = richTxtBox.SelectionFont.Italic;
            bool isBold = richTxtBox.SelectionFont.Bold;
            bool isUnderLine = richTxtBox.SelectionFont.Underline;
            
            if (isItalic && isUnderLine)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Italic | FontStyle.Underline);
            }
            else if (isItalic)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Italic);
            }
            else if (isUnderLine)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Underline);
            }
            if (isBold)
            {
                if (isItalic || isUnderLine)
                { 
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, richTxtBox.SelectionFont.Style | FontStyle.Regular);
                }
                else
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, FontStyle.Regular);
                }
            }
            else
            {
                if (isItalic || isUnderLine)
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, richTxtBox.SelectionFont.Style | FontStyle.Bold);
                }
                else
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, FontStyle.Bold);
                }
            }
            StyleButtonStatusUpdate();
        }
    

        private void Italic_Click(object sender, EventArgs e)
        {
            float fontSize = richTxtBox.SelectionFont.Size;
            bool isBold = richTxtBox.SelectionFont.Bold;
            bool isItalic = richTxtBox.SelectionFont.Italic;
            bool isUnderLine = richTxtBox.SelectionFont.Underline;
            if (isBold && isUnderLine)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Bold | FontStyle.Underline);
            }
            else if (isBold)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Bold);
            }
            else if (isUnderLine)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Underline);
            }
            if (isItalic)
            {
                if (isBold || isUnderLine)
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, richTxtBox.SelectionFont.Style | FontStyle.Regular);
                }
                else
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, FontStyle.Regular);
                }
            }
            else
            {
                if (isBold || isUnderLine)
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, richTxtBox.SelectionFont.Style | FontStyle.Italic);
                }
                else
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, FontStyle.Italic);
                }
            }
            StyleButtonStatusUpdate();
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            float fontSize = richTxtBox.SelectionFont.Size;
            bool isBold = richTxtBox.SelectionFont.Bold;
            bool isItalic = richTxtBox.SelectionFont.Italic;
            bool isUnderLine = richTxtBox.SelectionFont.Underline;
            if (isItalic && isBold)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Italic | FontStyle.Bold);
            }
            else if (isItalic)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Italic);
            }
            else if (isBold)
            {
                richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, richTxtBox.Font.Size, FontStyle.Bold);
            }
            if (isUnderLine)
            {
                if (isBold || isItalic)
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, richTxtBox.SelectionFont.Style | FontStyle.Regular);
                }
                else
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, FontStyle.Regular);
                }
            }
            else
            {
                if (isBold || isItalic)
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, richTxtBox.SelectionFont.Style | FontStyle.Underline);
                }
                else
                {
                    richTxtBox.SelectionFont = new Font(richTxtBox.SelectionFont.FontFamily, fontSize, FontStyle.Underline);
                }
            }
            StyleButtonStatusUpdate();
        }

        private void RichTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboTextChange(object sender, EventArgs e)
        {
            if (Single.TryParse(fontSizeComboBox.Text, out Single fontSize))
            {
                Font currentFont = richTxtBox.SelectionFont;
                if (currentFont != null)
                    richTxtBox.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            }
            richTxtBox.Focus();

        }

        private void StyleButtonStatusUpdate()
        {
            Font loadedFont = richTxtBox.SelectionFont;
            fontSizeComboBox.Text = loadedFont.Size.ToString();
            if (loadedFont != null)
            {
                if (loadedFont.Bold)
                {
                    bold.Checked = true;
                }
                else
                {
                    bold.Checked = false;
                }
                if (loadedFont.Underline)
                {
                    underline.Checked = true;
                }
                else
                {
                    underline.Checked = false;
                }
                if (loadedFont.Italic)
                {
                    italic.Checked = true;
                }
                else
                {
                    italic.Checked = false;
                }
            }
        }

        private void RichTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            StyleButtonStatusUpdate();
        }

        private void RichTxtBox_SelectionChanged(object sender, EventArgs e)
        {
            StyleButtonStatusUpdate();
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            new About(account).Show();
        }
    }
}
