using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class ProductFormEdit : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int productCode;

        public ProductFormEdit(int selectedProductCode)
        {
            InitializeComponent();
            productCode = selectedProductCode;
            LoadProductData();
        }

        public void LoadProductData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Products WHERE ProductCode = @productCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productCode", productCode);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textBoxProductName.Text = reader["ProductName"].ToString();
                            dateTimePickerArrivalDate.Value = Convert.ToDateTime(reader["ArrivalDate"]);
                            numericUpDownQuantity.Value = Convert.ToInt32(reader["Quantity"]);
                            numericUpDownPurchasePrice.Value = Convert.ToDecimal(reader["PurchasePrice"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных продукта: " + ex.Message);
            }
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            int quantity = (int)numericUpDownQuantity.Value;
            decimal purchasePrice = numericUpDownPurchasePrice.Value;

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            UpdateProductInDatabase(productCode, productName, arrivalDate, quantity, purchasePrice);

            this.Close();
        }

        public void UpdateProductInDatabase(int productCode, string productName, DateTime arrivalDate, int quantity, decimal purchasePrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Products SET ProductName = @productName, ArrivalDate = @arrivalDate, Quantity = @quantity, PurchasePrice = @purchasePrice WHERE ProductCode = @productCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Продукт успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Продукт не был обновлен. Проверьте введенные данные.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении продукта: " + ex.Message);
            }
        }
    }
}