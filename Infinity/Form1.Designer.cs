namespace Infinity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            RememberMe = new CheckBox();
            linkLabel1 = new LinkLabel();
            DiscordBtn = new Button();
            LoginBtn = new Button();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            linkLabel3 = new LinkLabel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 57, 54);
            panel1.Location = new Point(334, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 3);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(152, 149, 145);
            label1.Location = new Point(540, 228);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 2;
            label1.Text = "OR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 57, 54);
            panel2.Location = new Point(569, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 3);
            panel2.TabIndex = 2;
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.FromArgb(8, 8, 8);
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EmailBox.ForeColor = Color.White;
            EmailBox.Location = new Point(334, 267);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(435, 25);
            EmailBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(8, 8, 8);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = Color.White;
            PasswordBox.Location = new Point(334, 332);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(435, 25);
            PasswordBox.TabIndex = 4;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(102, 96, 95);
            label2.Location = new Point(334, 249);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(102, 96, 95);
            label3.Location = new Point(334, 314);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // RememberMe
            // 
            RememberMe.AutoSize = true;
            RememberMe.ForeColor = Color.FromArgb(208, 191, 185);
            RememberMe.Location = new Point(334, 386);
            RememberMe.Name = "RememberMe";
            RememberMe.Size = new Size(109, 19);
            RememberMe.TabIndex = 7;
            RememberMe.Text = "Remember Me?";
            RememberMe.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(31, 110, 41);
            linkLabel1.Location = new Point(642, 390);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password?";
            linkLabel1.VisitedLinkColor = Color.FromArgb(102, 192, 167);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DiscordBtn
            // 
            DiscordBtn.BackColor = Color.FromArgb(88, 101, 242);
            DiscordBtn.FlatAppearance.BorderSize = 0;
            DiscordBtn.FlatStyle = FlatStyle.Flat;
            DiscordBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DiscordBtn.ForeColor = Color.White;
            DiscordBtn.Location = new Point(497, 157);
            DiscordBtn.Name = "DiscordBtn";
            DiscordBtn.Size = new Size(111, 58);
            DiscordBtn.TabIndex = 9;
            DiscordBtn.Text = "Discord";
            DiscordBtn.UseVisualStyleBackColor = false;
            DiscordBtn.Click += DiscordBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(102, 192, 167);
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(415, 424);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(266, 47);
            LoginBtn.TabIndex = 11;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(31, 110, 41);
            linkLabel2.Location = new Point(508, 474);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(80, 15);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Privacy Policy";
            linkLabel2.VisitedLinkColor = Color.FromArgb(102, 192, 167);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(208, 191, 185);
            label4.Location = new Point(428, 508);
            label4.Name = "label4";
            label4.Size = new Size(191, 19);
            label4.TabIndex = 13;
            label4.Text = "Don't have a Infinity account?";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.FromArgb(31, 110, 41);
            linkLabel3.Location = new Point(625, 510);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(47, 15);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Sign up";
            linkLabel3.VisitedLinkColor = Color.FromArgb(102, 192, 167);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(102, 96, 95);
            label5.Location = new Point(269, 630);
            label5.Name = "label5";
            label5.Size = new Size(542, 15);
            label5.TabIndex = 15;
            label5.Text = "Infinity is not affiliated, endorsed, or administered by Epic Games or their respective copyright holders";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1108, 654);
            Controls.Add(label5);
            Controls.Add(linkLabel3);
            Controls.Add(label4);
            Controls.Add(linkLabel2);
            Controls.Add(LoginBtn);
            Controls.Add(DiscordBtn);
            Controls.Add(linkLabel1);
            Controls.Add(RememberMe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Infinity";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Label label2;
        private Label label3;
        private CheckBox RememberMe;
        private LinkLabel linkLabel1;
        private Button DiscordBtn;
        private Button LoginBtn;
        private LinkLabel linkLabel2;
        private Label label4;
        private LinkLabel linkLabel3;
        private Label label5;
    }
}