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
                    if (parts.Length == 3)
                    {
                        usersList.Add(new User(parts[0], parts[1], parts[2]));
                        users.Items.Add($"{parts[0]}:{parts[2]}");
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
                        writer.WriteLine($"{user.Name};{user.Password};{user.Level}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении пользователей: " + ex.Message);
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Level { get; set; }

        public User(string name, string password, string level)
        {
            Name = name;
            Password = password;
            Level = level;
        }
    }
}
