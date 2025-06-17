using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.DataFormats;

namespace игра
{
    public partial class start_menu : Form
    {
        private const string UsersFilePath = "users.txt";
        private const string AdminUsername = "asd"; // Имя администратора
        private const string AdminPassword = "asd"; // Пароль для администратора

        public start_menu()
        {
            InitializeComponent();
        }

        private void start_menu_Load(object sender, EventArgs e)
        {

        }

        private void registrate_Click(object sender, EventArgs e)
        {
            reg_menu reg = new reg_menu();
            reg.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string UN = username.Text;
            string PW = password.Text;

            if (string.IsNullOrWhiteSpace(UN) || string.IsNullOrWhiteSpace(PW))
            {
                status.Text = "Пожалуйста, введите имя пользователя и пароль.";
                return;
            }

            if (UN == AdminUsername && PW == AdminPassword)
            {
                status.Text = "Добро пожаловать, администратор!";
                ADM_menu heh = new ADM_menu();
                heh.Show();
                //this.Hide();
                return;
            }

            if (ValidateUser(UN, PW))
            {
                status.Text = "Вход выполнен успешно!";
                users_level ul = new users_level();
                ul.Show();
                //this.Hide();
            }
            else
            {
                status.Text = "Неверное имя пользователя или пароль.";
            }
        }

        private bool ValidateUser(string username, string password)
        {
            if (!File.Exists(UsersFilePath))
                return false;

            return File.ReadLines(UsersFilePath).Any(line =>
            {
                var parts = line.Split(';');
                return parts.Length >= 2 && parts[0] == username && parts[1] == password;
            });
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}