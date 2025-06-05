using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using игра.Properties;

namespace игра
{
    partial class ADM_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADM_menu));
            levels = new CheckedListBox();
            users = new CheckedListBox();
            del_user = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // levels
            // 
            levels.FormattingEnabled = true;
            resources.ApplyResources(levels, "levels");
            levels.Name = "levels";
            levels.SelectedIndexChanged += levels_SelectedIndexChanged;
            // 
            // users
            // 
            users.FormattingEnabled = true;
            resources.ApplyResources(users, "users");
            users.Name = "users";
            users.SelectedIndexChanged += users_SelectedIndexChanged;
            // 
            // del_user
            // 
            resources.ApplyResources(del_user, "del_user");
            del_user.Name = "del_user";
            del_user.UseVisualStyleBackColor = true;
            del_user.Click += del_user_Click;
            // 
            // ADM_menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.bg;
            Controls.Add(del_user);
            Controls.Add(users);
            Controls.Add(levels);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ADM_menu";
            ShowIcon = false;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox levels;
        private CheckedListBox users;
        private System.Windows.Forms.Button del_user;
    }
}