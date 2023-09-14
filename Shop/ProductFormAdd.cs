using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class ProductFormAdd : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public ProductFormAdd()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            int quantity = (int)numericUpDownQuantity.Value;
            decimal purchasePrice = numericUpDownPurchasePrice.Value;


            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля и убедитесь, что числовые поля содержат корректные значения.");
                return;
            }

            AddProductToDatabase(productName, arrivalDate, quantity, purchasePrice);

            // Закрываем форму после успешного добавления
            this.Close();
        }

        public void AddProductToDatabase(string productName, DateTime arrivalDate, int quantity, decimal purchasePrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Products (ProductName, ArrivalDate, Quantity, PurchasePrice) VALUES (@productName, @arrivalDate, @quantity, @purchasePrice)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Продукт успешно добавлен.");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при добавлении продукта.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении продукта: " + ex.Message);
            }
        }
    }
}
