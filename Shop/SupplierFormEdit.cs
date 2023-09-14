using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplierFormEdit : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int supplierCode;

        public SupplierFormEdit(int selectedSupplierCode)
        {
            InitializeComponent();
            supplierCode = selectedSupplierCode;
            LoadSupplierData();
        }

        private void LoadSupplierData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Suppliers WHERE SupplierCode = @supplierCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierCode", supplierCode);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textBoxSupplierName.Text = reader["SupplierName"].ToString();
                            textBoxAddress.Text = reader["Address"].ToString();
                            textBoxPhone.Text = reader["Phone"].ToString();
                            textBoxContactPerson.Text = reader["ContactPerson"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных поставщика: " + ex.Message);
            }
        }
        private void UpdateSupplierInDatabase(int supplierCode, string supplierName, string address, string phone, string contactPerson)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Suppliers SET SupplierName = @supplierName, Address = @address, Phone = @phone, ContactPerson = @contactPerson WHERE SupplierCode = @supplierCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierCode", supplierCode);
                        command.Parameters.AddWithValue("@supplierName", supplierName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@contactPerson", contactPerson);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Поставщик успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Поставщик не был обновлен. Проверьте введенные данные.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении поставщика: " + ex.Message);
            }
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            string supplierName = textBoxSupplierName.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            string contactPerson = textBoxContactPerson.Text;

            if (string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            UpdateSupplierInDatabase(supplierCode, supplierName, address, phone, contactPerson);

            this.Close();
        }
    }
}
