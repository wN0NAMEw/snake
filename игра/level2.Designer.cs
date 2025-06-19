using System.Windows.Forms;
using игра.Properties;

namespace игра
{
    partial class level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level2));
            pictureBox1 = new PictureBox();
            winblok = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox8 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox30 = new PictureBox();
            pictureBox31 = new PictureBox();
            pictureBox32 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winblok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.head;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // winblok
            // 
            winblok.Image = Resources.block;
            resources.ApplyResources(winblok, "winblok");
            winblok.Name = "winblok";
            winblok.TabStop = false;
            winblok.Click += winblok_Click_1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick_1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Resources.lava;
            resources.ApplyResources(pictureBox8, "pictureBox8");
            pictureBox8.Name = "pictureBox8";
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "lava";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.lava;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "lava";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.lava;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "lava";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.lava;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "lava";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.lava;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "lava";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Resources.lava;
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "lava";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Resources.lava;
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "lava";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Resources.lava;
            resources.ApplyResources(pictureBox9, "pictureBox9");
            pictureBox9.Name = "pictureBox9";
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "lava";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Resources.lava;
            resources.ApplyResources(pictureBox10, "pictureBox10");
            pictureBox10.Name = "pictureBox10";
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "lava";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Resources.lava;
            resources.ApplyResources(pictureBox11, "pictureBox11");
            pictureBox11.Name = "pictureBox11";
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "lava";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Resources.lava;
            resources.ApplyResources(pictureBox12, "pictureBox12");
            pictureBox12.Name = "pictureBox12";
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "lava";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Resources.lava;
            resources.ApplyResources(pictureBox13, "pictureBox13");
            pictureBox13.Name = "pictureBox13";
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "lava";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Resources.lava;
            resources.ApplyResources(pictureBox15, "pictureBox15");
            pictureBox15.Name = "pictureBox15";
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "lava";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Resources.lava;
            resources.ApplyResources(pictureBox16, "pictureBox16");
            pictureBox16.Name = "pictureBox16";
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "lava";
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Resources.lava;
            resources.ApplyResources(pictureBox17, "pictureBox17");
            pictureBox17.Name = "pictureBox17";
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "lava";
            // 
            // pictureBox19
            // 
            pictureBox19.Image = Resources.lava;
            resources.ApplyResources(pictureBox19, "pictureBox19");
            pictureBox19.Name = "pictureBox19";
            pictureBox19.TabStop = false;
            pictureBox19.Tag = "lava";
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Resources.lava;
            resources.ApplyResources(pictureBox20, "pictureBox20");
            pictureBox20.Name = "pictureBox20";
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "lava";
            // 
            // pictureBox21
            // 
            pictureBox21.Image = Resources.lava;
            resources.ApplyResources(pictureBox21, "pictureBox21");
            pictureBox21.Name = "pictureBox21";
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "lava";
            // 
            // pictureBox22
            // 
            pictureBox22.Image = Resources.lava;
            resources.ApplyResources(pictureBox22, "pictureBox22");
            pictureBox22.Name = "pictureBox22";
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "lava";
            // 
            // pictureBox23
            // 
            pictureBox23.Image = Resources.lava;
            resources.ApplyResources(pictureBox23, "pictureBox23");
            pictureBox23.Name = "pictureBox23";
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "lava";
            // 
            // pictureBox24
            // 
            pictureBox24.Image = Resources.lava;
            resources.ApplyResources(pictureBox24, "pictureBox24");
            pictureBox24.Name = "pictureBox24";
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "lava";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Resources.lava;
            resources.ApplyResources(pictureBox14, "pictureBox14");
            pictureBox14.Name = "pictureBox14";
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "lava";
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Resources.lava;
            resources.ApplyResources(pictureBox18, "pictureBox18");
            pictureBox18.Name = "pictureBox18";
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "lava";
            // 
            // pictureBox25
            // 
            pictureBox25.Image = Resources.lava;
            resources.ApplyResources(pictureBox25, "pictureBox25");
            pictureBox25.Name = "pictureBox25";
            pictureBox25.TabStop = false;
            pictureBox25.Tag = "lava";
            // 
            // pictureBox26
            // 
            pictureBox26.Image = Resources.lava;
            resources.ApplyResources(pictureBox26, "pictureBox26");
            pictureBox26.Name = "pictureBox26";
            pictureBox26.TabStop = false;
            pictureBox26.Tag = "lava";
            // 
            // pictureBox27
            // 
            pictureBox27.Image = Resources.lava;
            resources.ApplyResources(pictureBox27, "pictureBox27");
            pictureBox27.Name = "pictureBox27";
            pictureBox27.TabStop = false;
            pictureBox27.Tag = "lava";
            // 
            // pictureBox28
            // 
            pictureBox28.Image = Resources.lava;
            resources.ApplyResources(pictureBox28, "pictureBox28");
            pictureBox28.Name = "pictureBox28";
            pictureBox28.TabStop = false;
            pictureBox28.Tag = "lava";
            // 
            // pictureBox29
            // 
            pictureBox29.Image = Resources.lava;
            resources.ApplyResources(pictureBox29, "pictureBox29");
            pictureBox29.Name = "pictureBox29";
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "lava";
            // 
            // pictureBox30
            // 
            pictureBox30.Image = Resources.lava;
            resources.ApplyResources(pictureBox30, "pictureBox30");
            pictureBox30.Name = "pictureBox30";
            pictureBox30.TabStop = false;
            pictureBox30.Tag = "lava";
            // 
            // pictureBox31
            // 
            pictureBox31.Image = Resources.lava;
            resources.ApplyResources(pictureBox31, "pictureBox31");
            pictureBox31.Name = "pictureBox31";
            pictureBox31.TabStop = false;
            pictureBox31.Tag = "lava";
            // 
            // pictureBox32
            // 
            pictureBox32.Image = Resources.lava;
            resources.ApplyResources(pictureBox32, "pictureBox32");
            pictureBox32.Name = "pictureBox32";
            pictureBox32.TabStop = false;
            pictureBox32.Tag = "lava";
            // 
            // level2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.map;
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox29);
            Controls.Add(winblok);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "level2";
            ShowIcon = false;
            Load += level2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)winblok).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox winblok;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox14;
        private PictureBox pictureBox18;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
    }
}