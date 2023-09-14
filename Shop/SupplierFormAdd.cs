using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplierFormAdd : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public SupplierFormAdd()
        {
            InitializeComponent();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
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

            AddSupplierToDatabase(supplierName, address, phone, contactPerson);

            this.Close();
        }

        private void AddSupplierToDatabase(string supplierName, string address, string phone, string contactPerson)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Suppliers (SupplierName, Address, Phone, ContactPerson) VALUES (@supplierName, @address, @phone, @contactPerson)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierName", supplierName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@contactPerson", contactPerson);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Поставщик успешно добавлен.");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при добавлении поставщика.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении поставщика: " + ex.Message);
            }
        }
    }
}
