using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SaleFormAdd : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public SaleFormAdd()
        {
            InitializeComponent();
            LoadProductComboBox();
        }

        private void LoadProductComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ProductCode, ProductName FROM Products";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable productsTable = new DataTable();
                        adapter.Fill(productsTable);

                        // Настроим ComboBox для отображения названия продукта
                        comboBoxProducts.DataSource = productsTable;
                        comboBoxProducts.DisplayMember = "ProductName";
                        comboBoxProducts.ValueMember = "ProductCode";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных продуктов: " + ex.Message);
            }
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            int productCode;
            if (!int.TryParse(comboBoxProducts.SelectedValue.ToString(), out productCode))
            {
                MessageBox.Show("Некорректный продукт.");
                return;
            }

            DateTime saleDate = dateTimePickerSaleDate.Value;
            int soldQuantity = (int)numericUpDownSoldQuantity.Value;
            decimal retailPrice = numericUpDownRetailPrice.Value;

            AddSaleToDatabase(productCode, saleDate, soldQuantity, retailPrice);

            // Закрываем форму после успешного добавления
            this.Close();
        }

        private void AddSaleToDatabase(int productCode, DateTime saleDate, int soldQuantity, decimal retailPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Sales (ProductCode, SaleDate, SoldQuantity, RetailPrice) VALUES (@productCode, @saleDate, @soldQuantity, @retailPrice)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@saleDate", saleDate);
                        command.Parameters.AddWithValue("@soldQuantity", soldQuantity);
                        command.Parameters.AddWithValue("@retailPrice", retailPrice);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Продажа успешно добавлена.");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при добавлении продажи.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении продажи: " + ex.Message);
            }
        }
    }
}
