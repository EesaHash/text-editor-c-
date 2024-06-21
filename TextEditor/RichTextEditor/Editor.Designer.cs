namespace RichTextEditor
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Top = new System.Windows.Forms.ToolStrip();
            this.TopNew = new System.Windows.Forms.ToolStripButton();
            this.TopOpen = new System.Windows.Forms.ToolStripButton();
            this.topSave = new System.Windows.Forms.ToolStripButton();
            this.topSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.italic = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.usernameLblEditor = new System.Windows.Forms.ToolStripLabel();
            this.permissionLbl = new System.Windows.Forms.ToolStripLabel();
            this.Left = new System.Windows.Forms.ToolStrip();
            this.cut = new System.Windows.Forms.ToolStripButton();
            this.copy = new System.Windows.Forms.ToolStripButton();
            this.paste = new System.Windows.Forms.ToolStripButton();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.DirectoryLbl = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.Top.SuspendLayout();
            this.Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.Menu.Size = new System.Drawing.Size(796, 48);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 46);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.New_Menu);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Menu);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Menu);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.Save_As_Menu);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(288, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.Logout_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 46);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.cutting;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(284, 44);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(284, 44);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::RichTextEditor.Properties.Resources.paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(284, 44);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 46);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Image = global::RichTextEditor.Properties.Resources.info;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(227, 44);
            this.aboutMenu.Text = "About...";
            this.aboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // Top
            // 
            this.Top.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopNew,
            this.TopOpen,
            this.topSave,
            this.topSaveAs,
            this.toolStripSeparator3,
            this.bold,
            this.italic,
            this.underline,
            this.fontSizeComboBox,
            this.usernameLblEditor,
            this.permissionLbl});
            this.Top.Location = new System.Drawing.Point(0, 48);
            this.Top.Name = "Top";
            this.Top.Padding = new System.Windows.Forms.Padding(0);
            this.Top.Size = new System.Drawing.Size(796, 50);
            this.Top.TabIndex = 1;
            this.Top.Text = "topToolStrip";
            // 
            // TopNew
            // 
            this.TopNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TopNew.Image = global::RichTextEditor.Properties.Resources._new;
            this.TopNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopNew.Name = "TopNew";
            this.TopNew.Size = new System.Drawing.Size(46, 44);
            this.TopNew.Text = "New";
            this.TopNew.Click += new System.EventHandler(this.New_Strip);
            // 
            // TopOpen
            // 
            this.TopOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TopOpen.Image = global::RichTextEditor.Properties.Resources.open;
            this.TopOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopOpen.Name = "TopOpen";
            this.TopOpen.Size = new System.Drawing.Size(46, 44);
            this.TopOpen.Text = "Open";
            this.TopOpen.ToolTipText = "Open";
            this.TopOpen.Click += new System.EventHandler(this.TopOpen_Click);
            // 
            // topSave
            // 
            this.topSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topSave.Image = global::RichTextEditor.Properties.Resources.save;
            this.topSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topSave.Name = "topSave";
            this.topSave.Size = new System.Drawing.Size(46, 44);
            this.topSave.Text = "Save";
            this.topSave.Click += new System.EventHandler(this.Save_Strip);
            // 
            // topSaveAs
            // 
            this.topSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topSaveAs.Image = global::RichTextEditor.Properties.Resources.save_as;
            this.topSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topSaveAs.Name = "topSaveAs";
            this.topSaveAs.Size = new System.Drawing.Size(46, 44);
            this.topSaveAs.Text = "Save As";
            this.topSaveAs.Click += new System.EventHandler(this.Save_As_Strip);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // bold
            // 
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.Image = global::RichTextEditor.Properties.Resources.bold;
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(46, 44);
            this.bold.Text = "Bold";
            this.bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // italic
            // 
            this.italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italic.Image = global::RichTextEditor.Properties.Resources.italic;
            this.italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(46, 44);
            this.italic.Text = "Italic";
            this.italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // underline
            // 
            this.underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline.Image = global::RichTextEditor.Properties.Resources.underline;
            this.underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(46, 44);
            this.underline.Text = "Underline";
            this.underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(75, 50);
            this.fontSizeComboBox.ToolTipText = "Select Font Size";
            this.fontSizeComboBox.TextChanged += new System.EventHandler(this.ComboTextChange);
            // 
            // usernameLblEditor
            // 
            this.usernameLblEditor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usernameLblEditor.Image = global::RichTextEditor.Properties.Resources.user;
            this.usernameLblEditor.Name = "usernameLblEditor";
            this.usernameLblEditor.Size = new System.Drawing.Size(32, 44);
            // 
            // permissionLbl
            // 
            this.permissionLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.permissionLbl.Image = global::RichTextEditor.Properties.Resources.key_person;
            this.permissionLbl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.permissionLbl.Name = "permissionLbl";
            this.permissionLbl.Size = new System.Drawing.Size(32, 44);
            // 
            // Left
            // 
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Left.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut,
            this.copy,
            this.paste});
            this.Left.Location = new System.Drawing.Point(0, 98);
            this.Left.Name = "Left";
            this.Left.Padding = new System.Windows.Forms.Padding(0);
            this.Left.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Left.Size = new System.Drawing.Size(46, 484);
            this.Left.TabIndex = 2;
            this.Left.Text = "leftToolStrip";
            // 
            // cut
            // 
            this.cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut.Image = global::RichTextEditor.Properties.Resources.cutting;
            this.cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(45, 36);
            this.cut.Text = "Cut";
            this.cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // copy
            // 
            this.copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy.Image = global::RichTextEditor.Properties.Resources.copy;
            this.copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(45, 36);
            this.copy.Text = "Copy";
            this.copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // paste
            // 
            this.paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paste.Image = global::RichTextEditor.Properties.Resources.paste;
            this.paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(45, 36);
            this.paste.Text = "Paste";
            this.paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // richTxtBox
            // 
            this.richTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBox.Location = new System.Drawing.Point(48, 75);
            this.richTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(737, 485);
            this.richTxtBox.TabIndex = 3;
            this.richTxtBox.Text = "";
            this.richTxtBox.SelectionChanged += new System.EventHandler(this.RichTxtBox_SelectionChanged);
            this.richTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTxtBox_MouseClick);
            this.richTxtBox.TextChanged += new System.EventHandler(this.RichTxtBox_TextChanged);
            // 
            // DirectoryLbl
            // 
            this.DirectoryLbl.AutoSize = true;
            this.DirectoryLbl.Location = new System.Drawing.Point(359, 562);
            this.DirectoryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirectoryLbl.Name = "DirectoryLbl";
            this.DirectoryLbl.Size = new System.Drawing.Size(140, 26);
            this.DirectoryLbl.TabIndex = 4;
            this.DirectoryLbl.Text = "File Directory";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 582);
            this.Controls.Add(this.DirectoryLbl);
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Editor";
            this.Text = "Magnificent Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            this.Left.ResumeLayout(false);
            this.Left.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStrip Top;
        private System.Windows.Forms.ToolStripButton TopNew;
        private System.Windows.Forms.ToolStripButton TopOpen;
        private System.Windows.Forms.ToolStripButton topSave;
        private System.Windows.Forms.ToolStripButton topSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton italic;
        private System.Windows.Forms.ToolStripButton underline;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripLabel usernameLblEditor;
        private System.Windows.Forms.ToolStrip Left;
        private System.Windows.Forms.ToolStripButton cut;
        private System.Windows.Forms.ToolStripButton copy;
        private System.Windows.Forms.ToolStripButton paste;
        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.Label DirectoryLbl;
        private System.Windows.Forms.ToolStripLabel permissionLbl;
    }
}