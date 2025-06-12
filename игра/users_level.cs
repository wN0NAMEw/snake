using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    public partial class users_level : Form
    {
        public users_level()
        {
            InitializeComponent();
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
            game lvl1 = new game();
            lvl1.Show();
            //Hide();
        }
    }
}
