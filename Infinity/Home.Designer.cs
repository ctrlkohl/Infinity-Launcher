namespace Infinity
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            SettingsBtn = new Button();
            label1 = new Label();
            LaunchBtn = new PictureBox();
            label2 = new Label();
            FriendCount = new Label();
            label4 = new Label();
            infinityNews2 = new InfinityNews();
            ProfileBtn = new Button();
            infinityFriends1 = new InfinityFriends();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LaunchBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(94, 94, 94);
            button1.Location = new Point(60, 123);
            button1.Name = "button1";
            button1.Size = new Size(74, 40);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackColor = Color.Transparent;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsBtn.ForeColor = Color.FromArgb(94, 94, 94);
            SettingsBtn.Location = new Point(60, 169);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(74, 40);
            SettingsBtn.TabIndex = 2;
            SettingsBtn.Text = "Settings";
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(94, 94, 94);
            label1.Location = new Point(824, 38);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 3;
            label1.Text = "Free to play";
            label1.Click += label1_Click;
            // 
            // LaunchBtn
            // 
            LaunchBtn.Image = (Image)resources.GetObject("LaunchBtn.Image");
            LaunchBtn.Location = new Point(824, 60);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.Size = new Size(270, 101);
            LaunchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LaunchBtn.TabIndex = 4;
            LaunchBtn.TabStop = false;
            LaunchBtn.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(94, 94, 94);
            label2.Location = new Point(813, 229);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 5;
            label2.Text = "Friends";
            // 
            // FriendCount
            // 
            FriendCount.AutoSize = true;
            FriendCount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FriendCount.ForeColor = Color.White;
            FriendCount.Location = new Point(872, 229);
            FriendCount.Name = "FriendCount";
            FriendCount.Size = new Size(33, 19);
            FriendCount.TabIndex = 6;
            FriendCount.Text = "000";
            FriendCount.TextAlign = ContentAlignment.MiddleLeft;
            FriendCount.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(94, 94, 94);
            label4.Location = new Point(216, 38);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 7;
            label4.Text = "News";
            label4.Click += label4_Click;
            // 
            // infinityNews2
            // 
            infinityNews2.Location = new Point(209, 60);
            infinityNews2.Name = "infinityNews2";
            infinityNews2.Size = new Size(598, 491);
            infinityNews2.TabIndex = 8;
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = Color.Transparent;
            ProfileBtn.FlatAppearance.BorderSize = 0;
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileBtn.ForeColor = Color.FromArgb(94, 94, 94);
            ProfileBtn.Location = new Point(33, 602);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(177, 40);
            ProfileBtn.TabIndex = 9;
            ProfileBtn.Text = "{Player Name}";
            ProfileBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProfileBtn.UseVisualStyleBackColor = false;
            // 
            // infinityFriends1
            // 
            infinityFriends1.Location = new Point(816, 251);
            infinityFriends1.Name = "infinityFriends1";
            infinityFriends1.Size = new Size(295, 380);
            infinityFriends1.TabIndex = 10;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1108, 654);
            Controls.Add(infinityFriends1);
            Controls.Add(ProfileBtn);
            Controls.Add(infinityNews2);
            Controls.Add(label4);
            Controls.Add(FriendCount);
            Controls.Add(label2);
            Controls.Add(LaunchBtn);
            Controls.Add(label1);
            Controls.Add(SettingsBtn);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LaunchBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button SettingsBtn;
        private Label label1;
        private PictureBox LaunchBtn;
        private Label label2;
        private Label FriendCount;
        private Label label4;
        private InfinityNews infinityNews1;
        private InfinityNews infinityNews2;
        private Button ProfileBtn;
        private InfinityFriends infinityFriends1;
    }
}