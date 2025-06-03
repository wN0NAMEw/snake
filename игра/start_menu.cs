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

namespace игра
{
    public partial class start_menu : Form
    {
        private const string UsersFilePath = "users.txt";
        private const string AdminUsername = "admin"; // Имя администратора
        private const string AdminPassword = "admin"; // Пароль для администратора

        public start_menu()
        {
            InitializeComponent();
        }

        private void start_menu_Load(object sender, EventArgs e)
        {

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
            File.AppendAllText(UsersFilePath, $"{UN};{PW}{Environment.NewLine}");
            status.Text = "Регистрация прошла успешно!";
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
                // переход к админ-панели
                return;
            }

            if (ValidateUser(UN, PW))
            {
                status.Text = "Вход выполнен успешно!";
                // переход к игровому меню
            }
            else
            {
                status.Text = "Неверное имя пользователя или пароль.";
            }
        }

        private bool UserExists(string username)
        {
            return File.Exists(UsersFilePath) && File.ReadLines(UsersFilePath)
                .Any(line => line.Split(';')[0] == username);
        }

        private bool ValidateUser(string username, string password)
        {
            if (!File.Exists(UsersFilePath))
                return false;

            return File.ReadLines(UsersFilePath)
                .Any(line =>
                {
                    var parts = line.Split(';');
                    return parts.Length == 2 && parts[0] == username && parts[1] == password;
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
    }
}