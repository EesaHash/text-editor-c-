namespace RichTextEditor
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.headerLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.iconLbl = new System.Windows.Forms.Label();
            this.firstLbl = new System.Windows.Forms.Label();
            this.lastLbl = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.permissionLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.headerLbl.Location = new System.Drawing.Point(144, 156);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(289, 44);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = "Rich Text Editor";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.versionLbl.Location = new System.Drawing.Point(242, 202);
            this.versionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(70, 31);
            this.versionLbl.TabIndex = 1;
            this.versionLbl.Text = "V1.0";
            // 
            // iconLbl
            // 
            this.iconLbl.AutoSize = true;
            this.iconLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.iconLbl.Image = global::RichTextEditor.Properties.Resources.info;
            this.iconLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconLbl.Location = new System.Drawing.Point(236, 79);
            this.iconLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconLbl.MinimumSize = new System.Drawing.Size(80, 77);
            this.iconLbl.Name = "iconLbl";
            this.iconLbl.Size = new System.Drawing.Size(80, 77);
            this.iconLbl.TabIndex = 2;
            this.iconLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Location = new System.Drawing.Point(224, 235);
            this.firstLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(116, 25);
            this.firstLbl.TabIndex = 3;
            this.firstLbl.Text = "First Name";
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Location = new System.Drawing.Point(224, 260);
            this.lastLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(115, 25);
            this.lastLbl.TabIndex = 4;
            this.lastLbl.Text = "Last Name";
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Location = new System.Drawing.Point(224, 285);
            this.dobLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(107, 25);
            this.dobLbl.TabIndex = 5;
            this.dobLbl.Text = "Birth Date";
            // 
            // permissionLbl
            // 
            this.permissionLbl.AutoSize = true;
            this.permissionLbl.Location = new System.Drawing.Point(224, 310);
            this.permissionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.permissionLbl.Name = "permissionLbl";
            this.permissionLbl.Size = new System.Drawing.Size(118, 25);
            this.permissionLbl.TabIndex = 6;
            this.permissionLbl.Text = "Permission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 454);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 7;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(210, 340);
            this.button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(150, 60);
            this.button.TabIndex = 8;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.permissionLbl);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.lastLbl);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.iconLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.headerLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label iconLbl;
        private System.Windows.Forms.Label firstLbl;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label permissionLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button;
    }
}