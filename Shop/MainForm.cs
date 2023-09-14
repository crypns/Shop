using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class MainForm : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int userID;
        private BindingSource loginHistoryBindingSource = new BindingSource();

        public MainForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserData();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Role, Username, photo, fullname FROM users WHERE UserID = @userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        string username = reader["Username"].ToString();
                        byte[] imageBytes = reader["photo"] as byte[];
                        string fullname = reader["fullname"].ToString();

                        labelRole.Text = "Роль: " + role;
                        labelUsername.Text = "Логин: " + username;
                        labelFullname.Text = "ФИО: " + fullname;

                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null; 
                        }
                    }
                }
            }
        }

        private void UpdateImageInDatabase(string imagePath)
        {
            try
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET photo = @photo WHERE UserID = @userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.Add("@photo", SqlDbType.VarBinary, -1).Value = imageBytes;
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Изображение успешно обновлено в базе данных.");
                        }
                        else
                        {
                            MessageBox.Show("Изображение не было обновлено. Проверьте, существует ли запись с указанным UserID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении изображения: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg;*.png)|*.jpg;*.png|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                UpdateImageInDatabase(imagePath);
                LoadUserData();
            }
        }

        private void labelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private string LoadUserRole()
        {
            string role = "Гость";

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Role FROM users WHERE UserID = @userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        role = reader["Role"].ToString();
                    }
                }
            }

            return role;
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
                            MessageBox.Show("Изменения успешно сохранены.");
                            LoadUserData();
                        }
                        else
                        {
                            MessageBox.Show("Изменения не были сохранены. Проверьте, существует ли запись с указанным UserID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении изменений: " + ex.Message);
            }
        }


        private void buttonLoginHistory_Click(object sender, EventArgs e)
        {
            string userRole = LoadUserRole();
            if (userRole == "Администратор")
            {
                LoginHistoryForm loginHistoryForm = new LoginHistoryForm();
                loginHistoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет разрешения на выполнение этой операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            string userRole = LoadUserRole();
            if (userRole == "Администратор")
            {
                UsersForm usersForm = new UsersForm();
                usersForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет разрешения на выполнение этой операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();

        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void buttonSupply_Click(object sender, EventArgs e)
        {
            SupplyForm supplyForm = new SupplyForm();
            supplyForm.ShowDialog();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm(LoadUserRole());
            salesForm.ShowDialog();
        }

    }
}
