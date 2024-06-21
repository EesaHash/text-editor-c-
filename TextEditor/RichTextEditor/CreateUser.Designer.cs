namespace RichTextEditor
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.firstLbl = new System.Windows.Forms.Label();
            this.lastLbl = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dobLbl = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordConfirmLbl = new System.Windows.Forms.Label();
            this.retypePasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(82, 208);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(110, 25);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(84, 267);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(106, 25);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password";
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Location = new System.Drawing.Point(82, 84);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(116, 25);
            this.firstLbl.TabIndex = 2;
            this.firstLbl.Text = "First Name";
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Location = new System.Drawing.Point(83, 148);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(115, 25);
            this.lastLbl.TabIndex = 3;
            this.lastLbl.Text = "Last Name";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(167, 435);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(147, 62);
            this.save.TabIndex = 4;
            this.save.Text = "Save User";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(332, 435);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(147, 62);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(277, 264);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(310, 31);
            this.passwordBox.TabIndex = 9;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(220, 373);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(367, 31);
            this.datePicker.TabIndex = 10;
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Location = new System.Drawing.Point(83, 373);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(107, 25);
            this.dobLbl.TabIndex = 11;
            this.dobLbl.Text = "Birth Date";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(220, 208);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(367, 31);
            this.usernameBox.TabIndex = 12;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(220, 142);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(367, 31);
            this.lastBox.TabIndex = 13;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(220, 84);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(367, 31);
            this.firstBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.comboBox1.Location = new System.Drawing.Point(466, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Permission";
            // 
            // passwordConfirmLbl
            // 
            this.passwordConfirmLbl.AutoSize = true;
            this.passwordConfirmLbl.Location = new System.Drawing.Point(82, 320);
            this.passwordConfirmLbl.Name = "passwordConfirmLbl";
            this.passwordConfirmLbl.Size = new System.Drawing.Size(180, 25);
            this.passwordConfirmLbl.TabIndex = 17;
            this.passwordConfirmLbl.Text = "Retype Password";
            // 
            // retypePasswordBox
            // 
            this.retypePasswordBox.Location = new System.Drawing.Point(277, 320);
            this.retypePasswordBox.Name = "retypePasswordBox";
            this.retypePasswordBox.Size = new System.Drawing.Size(310, 31);
            this.retypePasswordBox.TabIndex = 18;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 552);
            this.Controls.Add(this.retypePasswordBox);
            this.Controls.Add(this.passwordConfirmLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.lastLbl);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label firstLbl;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordConfirmLbl;
        private System.Windows.Forms.TextBox retypePasswordBox;
    }
}