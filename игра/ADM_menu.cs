using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace игра
{
    public partial class ADM_menu : Form
    {
        private List<User> usersList = new List<User>();

        public ADM_menu()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var lines = File.ReadAllLines("users.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 7)
                    {
                        usersList.Add(new User(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]));
                        users.Items.Add($"{parts[0]};{parts[1]};{parts[2]};{parts[3]};{parts[4]};{parts[5]};{parts[6]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке пользователей: " + ex.Message);
            }
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void levels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void del_user_Click(object sender, EventArgs e)
        {
            var selectedItems = users.CheckedItems.Cast<string>().ToList();

            if (selectedItems.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выделенных пользователей?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (var selectedItem in selectedItems)
                    {
                        var userName = selectedItem.Split(':')[0];
                        usersList.RemoveAll(u => u.Name == userName);
                        users.Items.Remove(selectedItem);
                    }
                    SaveUsers();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пользователей для удаления.");
            }
        }

        private void SaveUsers()
        {
            try
            {
                using (var writer = new StreamWriter("users.txt"))
                {
                    foreach (var user in usersList)
                    {
                        writer.WriteLine($"{user.Name};{user.Password};{user.lvlBASE};{user.lvle};{user.lvln};{user.lvlH};{user.skin}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении пользователей: " + ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            start_menu back = new start_menu();
            back.Show();
            //Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            speedset.Text = $"{trackBar1.Value}";
        }

        private void set_Click(object sender, EventArgs e)
        {
            int speed = trackBar1.Value;
            ReplaceLine("settings.txt", 1, $"{trackBar1.Value}");
        }

        public static void ReplaceLine(string filePath, int lineNumber, string newLine)
        {
            try
            {
                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines(filePath);

                // Проверяем, что номер строки находится в допустимых пределах
                if (lineNumber < 1 || lineNumber > lines.Length)
                {
                    Console.WriteLine("Неверный номер строки.  Номер строки должен быть от 1 до количества строк в файле.");
                    return;
                }

                // Замена строки в массиве
                lines[lineNumber - 1] = newLine;

                // Запись измененных строк обратно в файл
                File.WriteAllLines(filePath, lines);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перезаписи строки: {ex.Message}");
            }
        }

        private void speedset_Click(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string lvlBASE { get; set; }
        public string lvle { get; set; }
        public string lvln { get; set; }
        public string lvlH { get; set; }
        public string skin { get; set; }


        public User(string name, string password, string levelb, string levele, string leveln, string levelH, string skn)
        {
            Name = name;
            Password = password;
            lvlBASE = levelb;
            lvle = levele;
            lvln = leveln;
            lvlH = levelH;
            skin = skn;
        }
    }
}
