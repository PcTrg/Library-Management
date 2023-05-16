namespace Morden_Flat_UI_demo
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.settingsBtn = new FontAwesome.Sharp.IconButton();
            this.marketingBtn = new FontAwesome.Sharp.IconButton();
            this.customBtn = new FontAwesome.Sharp.IconButton();
            this.productBtn = new FontAwesome.Sharp.IconButton();
            this.orderBtn = new FontAwesome.Sharp.IconButton();
            this.dashbarBtn = new FontAwesome.Sharp.IconButton();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.marketingBtn);
            this.panelMenu.Controls.Add(this.customBtn);
            this.panelMenu.Controls.Add(this.productBtn);
            this.panelMenu.Controls.Add(this.orderBtn);
            this.panelMenu.Controls.Add(this.dashbarBtn);
            this.panelMenu.Controls.Add(this.panelColor);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 572);
            this.panelMenu.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.settingsBtn.IconColor = System.Drawing.Color.White;
            this.settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsBtn.IconSize = 32;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(0, 440);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingsBtn.Size = new System.Drawing.Size(220, 60);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // marketingBtn
            // 
            this.marketingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketingBtn.FlatAppearance.BorderSize = 0;
            this.marketingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marketingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.marketingBtn.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.marketingBtn.IconColor = System.Drawing.Color.White;
            this.marketingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.marketingBtn.IconSize = 32;
            this.marketingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marketingBtn.Location = new System.Drawing.Point(0, 380);
            this.marketingBtn.Name = "marketingBtn";
            this.marketingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.marketingBtn.Size = new System.Drawing.Size(220, 60);
            this.marketingBtn.TabIndex = 5;
            this.marketingBtn.Text = "Marketing";
            this.marketingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marketingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.marketingBtn.UseVisualStyleBackColor = true;
            this.marketingBtn.Click += new System.EventHandler(this.marketingBtn_Click);
            // 
            // customBtn
            // 
            this.customBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customBtn.FlatAppearance.BorderSize = 0;
            this.customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.customBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.customBtn.IconColor = System.Drawing.Color.White;
            this.customBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customBtn.IconSize = 32;
            this.customBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customBtn.Location = new System.Drawing.Point(0, 320);
            this.customBtn.Name = "customBtn";
            this.customBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.customBtn.Size = new System.Drawing.Size(220, 60);
            this.customBtn.TabIndex = 4;
            this.customBtn.Text = "Customers";
            this.customBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.productBtn.IconColor = System.Drawing.Color.White;
            this.productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productBtn.IconSize = 32;
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(0, 260);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.productBtn.Size = new System.Drawing.Size(220, 60);
            this.productBtn.TabIndex = 3;
            this.productBtn.Text = "Products";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderBtn.FlatAppearance.BorderSize = 0;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.orderBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.orderBtn.IconColor = System.Drawing.Color.White;
            this.orderBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.orderBtn.IconSize = 32;
            this.orderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.Location = new System.Drawing.Point(0, 200);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.orderBtn.Size = new System.Drawing.Size(220, 60);
            this.orderBtn.TabIndex = 2;
            this.orderBtn.Text = "Orders";
            this.orderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // dashbarBtn
            // 
            this.dashbarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashbarBtn.FlatAppearance.BorderSize = 0;
            this.dashbarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbarBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.dashbarBtn.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.dashbarBtn.IconColor = System.Drawing.Color.White;
            this.dashbarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashbarBtn.IconSize = 32;
            this.dashbarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashbarBtn.Location = new System.Drawing.Point(0, 140);
            this.dashbarBtn.Name = "dashbarBtn";
            this.dashbarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dashbarBtn.Size = new System.Drawing.Size(220, 60);
            this.dashbarBtn.TabIndex = 1;
            this.dashbarBtn.Text = "Dash Board";
            this.dashbarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashbarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashbarBtn.UseVisualStyleBackColor = true;
            this.dashbarBtn.Click += new System.EventHandler(this.dashbarBtn_Click);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.btnHome);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(220, 140);
            this.panelColor.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Morden_Flat_UI_demo.Properties.Resources.book;
            this.btnHome.Location = new System.Drawing.Point(13, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 90);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.panelTitleBar.Controls.Add(this.btnMinize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(580, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinize.IconSize = 18;
            this.btnMinize.Location = new System.Drawing.Point(505, 3);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(20, 20);
            this.btnMinize.TabIndex = 4;
            this.btnMinize.UseVisualStyleBackColor = false;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximize.IconSize = 18;
            this.btnMaximize.Location = new System.Drawing.Point(531, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 18;
            this.btnExit.Location = new System.Drawing.Point(557, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 37);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(26, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(580, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(128)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(580, 482);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Morden_Flat_UI_demo.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(161, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelColor;
        private FontAwesome.Sharp.IconButton dashbarBtn;
        private FontAwesome.Sharp.IconButton settingsBtn;
        private FontAwesome.Sharp.IconButton marketingBtn;
        private FontAwesome.Sharp.IconButton customBtn;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton orderBtn;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinize;
        private FontAwesome.Sharp.IconButton btnMaximize;
    }
}

