namespace Infinity
{
    partial class Settings
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
            FolderPathText = new TextBox();
            FindFolderBtn = new Button();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            UserNameText = new Label();
            UserId = new Label();
            label3 = new Label();
            VersionCode = new Label();
            UseLauncherConsoleCheck = new CheckBox();
            SuspendLayout();
            // 
            // FolderPathText
            // 
            FolderPathText.BackColor = Color.FromArgb(8, 8, 8);
            FolderPathText.BorderStyle = BorderStyle.None;
            FolderPathText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FolderPathText.ForeColor = Color.White;
            FolderPathText.Location = new Point(24, 31);
            FolderPathText.Name = "FolderPathText";
            FolderPathText.Size = new Size(978, 20);
            FolderPathText.TabIndex = 0;
            // 
            // FindFolderBtn
            // 
            FindFolderBtn.BackColor = Color.FromArgb(8, 8, 8);
            FindFolderBtn.FlatAppearance.BorderSize = 0;
            FindFolderBtn.FlatStyle = FlatStyle.Flat;
            FindFolderBtn.ForeColor = SystemColors.Control;
            FindFolderBtn.Location = new Point(1008, 29);
            FindFolderBtn.Name = "FindFolderBtn";
            FindFolderBtn.Size = new Size(24, 23);
            FindFolderBtn.TabIndex = 1;
            FindFolderBtn.Text = "...";
            FindFolderBtn.UseVisualStyleBackColor = false;
            FindFolderBtn.Click += FindFolderBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(94, 94, 94);
            label4.Location = new Point(24, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 8;
            label4.Text = "Fortnite Path:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 57, 54);
            panel1.Location = new Point(41, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 1);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(94, 94, 94);
            label2.Location = new Point(41, 573);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(94, 94, 94);
            label1.Location = new Point(41, 589);
            label1.Name = "label1";
            label1.Size = new Size(20, 13);
            label1.TabIndex = 12;
            label1.Text = "Id:";
            // 
            // UserNameText
            // 
            UserNameText.AutoSize = true;
            UserNameText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameText.ForeColor = Color.FromArgb(94, 94, 94);
            UserNameText.Location = new Point(101, 573);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(72, 13);
            UserNameText.TabIndex = 13;
            UserNameText.Text = "{playername}";
            // 
            // UserId
            // 
            UserId.AutoSize = true;
            UserId.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserId.ForeColor = Color.FromArgb(94, 94, 94);
            UserId.Location = new Point(62, 589);
            UserId.Name = "UserId";
            UserId.Size = new Size(54, 13);
            UserId.TabIndex = 14;
            UserId.Text = "{playerid}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(94, 94, 94);
            label3.Location = new Point(41, 607);
            label3.Name = "label3";
            label3.Size = new Size(77, 13);
            label3.TabIndex = 15;
            label3.Text = "Client version";
            // 
            // VersionCode
            // 
            VersionCode.AutoSize = true;
            VersionCode.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VersionCode.ForeColor = Color.FromArgb(94, 94, 94);
            VersionCode.Location = new Point(114, 608);
            VersionCode.Name = "VersionCode";
            VersionCode.Size = new Size(50, 13);
            VersionCode.TabIndex = 16;
            VersionCode.Text = "{version}";
            // 
            // UseLauncherConsoleCheck
            // 
            UseLauncherConsoleCheck.AutoSize = true;
            UseLauncherConsoleCheck.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UseLauncherConsoleCheck.ForeColor = Color.FromArgb(94, 94, 94);
            UseLauncherConsoleCheck.Location = new Point(24, 71);
            UseLauncherConsoleCheck.Name = "UseLauncherConsoleCheck";
            UseLauncherConsoleCheck.Size = new Size(156, 21);
            UseLauncherConsoleCheck.TabIndex = 18;
            UseLauncherConsoleCheck.Text = "Use Launcher Console";
            UseLauncherConsoleCheck.UseVisualStyleBackColor = true;
            UseLauncherConsoleCheck.CheckedChanged += FNConsoleStateChangeHook;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1108, 654);
            Controls.Add(UseLauncherConsoleCheck);
            Controls.Add(VersionCode);
            Controls.Add(label3);
            Controls.Add(UserId);
            Controls.Add(UserNameText);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(FindFolderBtn);
            Controls.Add(FolderPathText);
            Name = "Settings";
            Text = "Infinity";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FolderPathText;
        private Button FindFolderBtn;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label UserNameText;
        private Label UserId;
        private Label label3;
        private Label VersionCode;
        private CheckBox UseLauncherConsoleCheck;
    }
}