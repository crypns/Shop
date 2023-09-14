using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class UsersFormAdd : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public UsersFormAdd()    
        {
            InitializeComponent();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            string role = textBoxRole.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string fullname = textBoxUserFullname.Text;

            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullname))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            AddUserToDatabase(role, username, password, fullname);

            this.Close();
        }

        private void AddUserToDatabase(string role, string username, string password, string fullname)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO users (Role, Username, Password, Fullname) VALUES (@role, @username, @password, @fullname)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fullname", fullname);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно добавлен.");
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не был добавлен. Проверьте, возможно, такой пользователь уже существует.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении пользователя: " + ex.Message);
            }
        }
    }
}
