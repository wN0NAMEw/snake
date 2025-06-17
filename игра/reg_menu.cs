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
    public partial class reg_menu : Form
    {
        private const string UsersFilePath = "users.txt";
        public reg_menu()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private bool UserExists(string username)
        {
            return File.Exists(UsersFilePath) && File.ReadLines(UsersFilePath)
                .Any(line =>
                {
                    var parts = line.Split(';');
                    return parts.Length >= 1 && parts[0] == username;
                });
        }

        private void registrate_Click(object sender, EventArgs e)
        {
            string UN = username.Text;
            string PW = password.Text;

            if (string.IsNullOrWhiteSpace(UN) || string.IsNullOrWhiteSpace(PW))
            {
                status.Text = "Пожалуйста, введите имя пользователя и пароль.";
                return;
            }

            if (UserExists(UN))
            {
                status.Text = "Пользователь с таким именем уже существует.";
                return;
            }

            File.AppendAllText(UsersFilePath, $"{UN};{PW};0;0;0;0;0{Environment.NewLine}");
            status.Text = "Регистрация прошла успешно!";
            this.Hide();
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void reg_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
