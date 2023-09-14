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
    public partial class UsersFormEdit : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int userID;

        public UsersFormEdit(int selectedUserID)
        {
            InitializeComponent();
            userID = selectedUserID;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE UserID = @userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textBoxRole.Text = reader["Role"].ToString();
                            textBoxUsername.Text = reader["Username"].ToString();
                            textBoxPassword.Text = reader["Password"].ToString();
                            textBoxUserFullname.Text = reader["Fullname"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных пользователя: " + ex.Message);
            }
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

            UpdateUserInDatabase(userID, role, username, password, fullname);

            this.Close();
        }

        private void UpdateUserInDatabase(int userID, string role, string username, string password, string fullname)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET Role = @role, Username = @username, Password = @password, Fullname = @fullname WHERE UserID = @userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fullname", fullname);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не был обновлен. Проверьте введенные данные.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении пользователя: " + ex.Message);
            }
        }
    }
}
