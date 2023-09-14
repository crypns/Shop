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
    public partial class UsersForm : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public UsersForm()
        {
            InitializeComponent();
            LoadUsersData();
            RenameDataGridViewColumns();
        }

        private void LoadUsersData()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT UserID, Role, Username, Password, fullname FROM users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable usersTable = new DataTable();
                        adapter.Fill(usersTable);

                        dataGridViewUsers.DataSource = usersTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных из таблицы users: " + ex.Message);
            }
        }

        private void RenameDataGridViewColumns()
        {
            dataGridViewUsers.Columns["UserID"].HeaderText = "ID";
            dataGridViewUsers.Columns["Role"].HeaderText = "Роль";
            dataGridViewUsers.Columns["Username"].HeaderText = "Логин";
            dataGridViewUsers.Columns["Password"].HeaderText = "Пароль";
            dataGridViewUsers.Columns["fullname"].HeaderText = "ФИО";
            dataGridViewUsers.Columns["UserID"].Visible = false;
        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            string roleFilter = textBoxRoleFilter.Text;
            string usernameFilter = textBoxUsernameFilter.Text;
            string fullnameFilter = textBoxFullnameFilter.Text;

            LoadUsersDataWithFilters(roleFilter, usernameFilter, fullnameFilter);
        }

        private void LoadUsersDataWithFilters(string roleFilter, string usernameFilter, string fullnameFilter)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID, Role, Username, Password, fullname FROM users WHERE 1=1";

                if (!string.IsNullOrEmpty(roleFilter))
                {
                    query += " AND Role LIKE @roleFilter";
                }

                if (!string.IsNullOrEmpty(usernameFilter))
                {
                    query += " AND Username LIKE @usernameFilter";
                }

                if (!string.IsNullOrEmpty(fullnameFilter))
                {
                    query += " AND fullname LIKE @fullnameFilter";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(roleFilter))
                    {
                        command.Parameters.AddWithValue("@roleFilter", "%" + roleFilter + "%");
                    }

                    if (!string.IsNullOrEmpty(usernameFilter))
                    {
                        command.Parameters.AddWithValue("@usernameFilter", "%" + usernameFilter + "%");
                    }

                    if (!string.IsNullOrEmpty(fullnameFilter))
                    {
                        command.Parameters.AddWithValue("@fullnameFilter", "%" + fullnameFilter + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable usersTable = new DataTable();
                    adapter.Fill(usersTable);

                    dataGridViewUsers.DataSource = usersTable;
                }
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteUserFromDatabase(userID);
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.");
            }
        }

        private void DeleteUserFromDatabase(int userID)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM users WHERE UserID = @userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно удален.");
                            LoadUsersData();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при удалении пользователя.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении пользователя: " + ex.Message);
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value);

                UsersFormEdit editUserForm = new UsersFormEdit(userID);
                editUserForm.ShowDialog();

                LoadUsersData();
            }
            else
            {
                MessageBox.Show("Выберите пользователя для редактирования.");
            }
        }

        private void AddButtonUser_Click(object sender, EventArgs e)
        {
            UsersFormAdd addUserForm = new UsersFormAdd();
            addUserForm.ShowDialog();

            LoadUsersData();
        }
    }
}
