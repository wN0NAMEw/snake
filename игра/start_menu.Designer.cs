namespace игра
{
    partial class start_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_menu));
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            registrate = new Button();
            login = new Button();
            status = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(252, 228, 95);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.FromArgb(252, 228, 95);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // username
            // 
            resources.ApplyResources(username, "username");
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Name = "username";
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            resources.ApplyResources(password, "password");
            password.ForeColor = SystemColors.ActiveCaptionText;
            password.Name = "password";
            password.TextChanged += password_TextChanged;
            // 
            // registrate
            // 
            registrate.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(registrate, "registrate");
            registrate.ForeColor = SystemColors.ActiveCaptionText;
            registrate.Name = "registrate";
            registrate.UseVisualStyleBackColor = false;
            registrate.Click += registrate_Click;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(login, "login");
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Name = "login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // status
            // 
            resources.ApplyResources(status, "status");
            status.BackColor = Color.FromArgb(252, 228, 95);
            status.Name = "status";
            status.Click += status_Click;
            // 
            // start_menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            Controls.Add(status);
            Controls.Add(login);
            Controls.Add(registrate);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "start_menu";
            ShowIcon = false;
            Load += start_menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button registrate;
        private Button login;
        private Label status;
    }
}