using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using игра.Properties;

namespace игра
{
    partial class users_level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users_level));
            skins = new System.Windows.Forms.Button();
            back = new System.Windows.Forms.Button();
            level1bt = new System.Windows.Forms.Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // skins
            // 
            skins.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(skins, "skins");
            skins.Name = "skins";
            skins.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(back, "back");
            back.Name = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // level1bt
            // 
            level1bt.BackColor = Color.FromArgb(252, 228, 95);
            resources.ApplyResources(level1bt, "level1bt");
            level1bt.Name = "level1bt";
            level1bt.UseVisualStyleBackColor = true;
            level1bt.Click += level1bt_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(252, 228, 95);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // users_level
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.bg;
            Controls.Add(label1);
            Controls.Add(level1bt);
            Controls.Add(back);
            Controls.Add(skins);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "users_level";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button skins;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button level1bt;
        private Label label1;
    }
}