using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using игра.Properties;

namespace игра
{
    partial class reg_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_menu));
            registrate = new System.Windows.Forms.Button();
            password = new System.Windows.Forms.TextBox();
            username = new System.Windows.Forms.TextBox();
            label2 = new Label();
            label1 = new Label();
            status = new Label();
            SuspendLayout();
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
            // password
            // 
            resources.ApplyResources(password, "password");
            password.ForeColor = SystemColors.ActiveCaptionText;
            password.Name = "password";
            password.TextChanged += password_TextChanged;
            // 
            // username
            // 
            resources.ApplyResources(username, "username");
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Name = "username";
            username.TextChanged += username_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.FromArgb(252, 228, 95);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(252, 228, 95);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // status
            // 
            resources.ApplyResources(status, "status");
            status.BackColor = Color.FromArgb(252, 228, 95);
            status.Name = "status";
            status.Click += status_Click;
            // 
            // reg_menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.bg;
            Controls.Add(status);
            Controls.Add(registrate);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "reg_menu";
            ShowIcon = false;
            Load += reg_menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button registrate;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private Label label2;
        private Label label1;
        private Label status;
    }
}