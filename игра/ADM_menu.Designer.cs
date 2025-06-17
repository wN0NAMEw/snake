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
            back = new System.Windows.Forms.Button();
            label2 = new Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            set = new System.Windows.Forms.Button();
            speedset = new Label();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            del_user.BackColor = Color.FromArgb(252, 228, 100);
            del_user.FlatAppearance.BorderColor = Color.Black;
            del_user.FlatAppearance.MouseDownBackColor = Color.Transparent;
            del_user.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resources.ApplyResources(del_user, "del_user");
            del_user.Name = "del_user";
            del_user.UseVisualStyleBackColor = false;
            del_user.Click += del_user_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(back, "back");
            back.Name = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.FromArgb(252, 228, 95);
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(trackBar1, "trackBar1");
            trackBar1.Maximum = 5000;
            trackBar1.Minimum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.TickFrequency = 100;
            trackBar1.Value = 500;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // set
            // 
            set.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(set, "set");
            set.Name = "set";
            set.UseVisualStyleBackColor = false;
            set.Click += set_Click;
            // 
            // speedset
            // 
            resources.ApplyResources(speedset, "speedset");
            speedset.BackColor = Color.FromArgb(252, 228, 95);
            speedset.Name = "speedset";
            speedset.Click += speedset_Click;
            // 
            // ADM_menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.bg;
            Controls.Add(speedset);
            Controls.Add(set);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(back);
            Controls.Add(del_user);
            Controls.Add(users);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ADM_menu";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox users;
        private System.Windows.Forms.Button del_user;
        private BindingSource userBindingSource;
        private System.Windows.Forms.Button back;
        private Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button set;
        private Label speedset;
    }
}