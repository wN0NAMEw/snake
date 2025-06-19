using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace игра
{
    public partial class users_level : Form
    {
        List<string> linii;
        int kfc = 0;
        string name;

        public users_level(string UN)
        {
            InitializeComponent();
            name = UN;
        }

        private void back_Click(object sender, EventArgs e)
        {
            start_menu back = new start_menu();
            back.Show();
            //Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void level1bt_Click(object sender, EventArgs e)
        {
            game lvl1 = new game(1, name);
            lvl1.Show();
            //Hide();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            kfc = 3;
            level1 bbk = new level1(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvle2_Click(object sender, EventArgs e)
        {
            kfc = 3;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvle3_Click(object sender, EventArgs e)
        {
            kfc = 3;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvle4_Click(object sender, EventArgs e)
        {
            kfc = 3;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }

        private void lvln1_Click(object sender, EventArgs e)
        {
            kfc = 2;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvln2_Click(object sender, EventArgs e)
        {
            kfc = 2;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvln3_Click(object sender, EventArgs e)
        {
            kfc = 2;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvln4_Click(object sender, EventArgs e)
        {
            kfc = 2;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }

        private void lvlH1_Click(object sender, EventArgs e)
        {
            kfc = 1;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvlH2_Click(object sender, EventArgs e)
        {
            kfc = 1;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvlH3_Click(object sender, EventArgs e)
        {
            kfc = 1;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }
        private void lvlH4_Click(object sender, EventArgs e)
        {
            kfc = 1;
            game bbk = new game(kfc, name);
            bbk.Show();
            //Hide();
        }

        private void users_level_Load(object sender, EventArgs e)
        {

            string filePath = "users.txt";
            linii = new List<string>();

            if (File.Exists(filePath))
            {
                linii = File.ReadAllLines(filePath).ToList();
            }

            // Теперь можно работать с linii
            for (int i = 0; i < linii.Count; i++)
            {
                string[] parts = linii[i].Split(';');
                if (parts.Length >= 1 && parts[0] == name)
                {
                    label5.Text = $"ваш рекорд: {parts[2]}";
                    break;
                }
            }

            kfc = 0;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void skins_Click(object sender, EventArgs e)
        {
            skinsy bbk = new skinsy(name);
            bbk.Show();
        }
    }
}
