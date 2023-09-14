using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SaleFormEdit : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int saleCode;

        public SaleFormEdit(int selectedSaleCode)
        {
            InitializeComponent();
            saleCode = selectedSaleCode;
            LoadProductComboBox();
            LoadSaleData();
            
        }

        private void LoadSaleData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Sales WHERE SaleCode = @saleCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@saleCode", saleCode);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int productCode = Convert.ToInt32(reader["ProductCode"]);

                            comboBoxProducts.SelectedValue = productCode;

                            dateTimePickerSaleDate.Value = Convert.ToDateTime(reader["SaleDate"]);
                            numericUpDownSoldQuantity.Value = Convert.ToInt32(reader["SoldQuantity"]);
                            numericUpDownRetailPrice.Value = Convert.ToDecimal(reader["RetailPrice"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных продажи: " + ex.Message);
            }
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

        private void UpdateSaleInDatabase(int saleCode, int productCode, DateTime saleDate, int soldQuantity, decimal retailPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Sales SET ProductCode = @productCode, SaleDate = @saleDate, SoldQuantity = @soldQuantity, RetailPrice = @retailPrice WHERE SaleCode = @saleCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@saleCode", saleCode);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@saleDate", saleDate);
                        command.Parameters.AddWithValue("@soldQuantity", soldQuantity);
                        command.Parameters.AddWithValue("@retailPrice", retailPrice);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Продажа успешно обновлена.");
                        }
                        else
                        {
                            MessageBox.Show("Продажа не была обновлена. Проверьте введенные данные.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении продажи: " + ex.Message);
            }
        }

        private void buttonSaveSale_Click(object sender, EventArgs e)
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

            UpdateSaleInDatabase(saleCode, productCode, saleDate, soldQuantity, retailPrice);

            this.Close();
        }
    }
}
