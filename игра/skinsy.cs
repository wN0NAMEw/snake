using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace игра
{
    public partial class skinsy : Form
    {
        List<string> linii;
        string name;
        public skinsy(string un)
        {
            InitializeComponent();
            name = un;
        }

        public void setskin(int numsk)
        {

            for (int i = 0; i < linii.Count; i++)
            {
                string[] parts = linii[i].Split(';');
                if (parts.Length >= 1 && parts[0] == name)
                {
                    string newLine = $"{parts[0]};{parts[1]};{parts[2]};{parts[3]};{parts[4]};{parts[5]};{numsk}";
                    linii[i] = newLine;
                    break;
                }
            }
            File.WriteAllLines("users.txt", linii);
        }


        private void skinsy_Load(object sender, EventArgs e)
        {
            string filePath = "users.txt";
            linii = new List<string>();

            if (File.Exists(filePath))
            {
                linii = File.ReadAllLines(filePath).ToList();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setskin(0);
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setskin(3);
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setskin(4);
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            setskin(5);
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            setskin(2);
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            setskin(1);
            Hide();
        }
    }
}
