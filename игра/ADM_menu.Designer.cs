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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADM_menu));
            users = new CheckedListBox();
            del_user = new System.Windows.Forms.Button();
            userBindingSource = new BindingSource(components);
            label1 = new Label();
            back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // users
            // 
            users.FormattingEnabled = true;
            resources.ApplyResources(users, "users");
            users.Name = "users";
            users.Tag = "";
            users.SelectedIndexChanged += users_SelectedIndexChanged;
            // 
            // del_user
            // 
            del_user.FlatAppearance.BorderColor = Color.Red;
            del_user.FlatAppearance.BorderSize = 10;
            del_user.FlatAppearance.MouseDownBackColor = Color.Red;
            del_user.FlatAppearance.MouseOverBackColor = Color.Red;
            resources.ApplyResources(del_user, "del_user");
            del_user.Name = "del_user";
            del_user.UseVisualStyleBackColor = true;
            del_user.Click += del_user_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.White;
            label1.Name = "label1";
            // 
            // back
            // 
            resources.ApplyResources(back, "back");
            back.Name = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // ADM_menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.bg;
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(del_user);
            Controls.Add(users);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ADM_menu";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox users;
        private System.Windows.Forms.Button del_user;
        private BindingSource userBindingSource;
        private Label label1;
        private System.Windows.Forms.Button back;
    }
}