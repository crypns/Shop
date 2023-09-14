using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplyFormAdd : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public SupplyFormAdd()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string supplierQuery = "SELECT SupplierCode, SupplierName FROM Suppliers";
                    using (SqlCommand supplierCommand = new SqlCommand(supplierQuery, connection))
                    {
                        SqlDataAdapter supplierAdapter = new SqlDataAdapter(supplierCommand);
                        DataTable supplierTable = new DataTable();
                        supplierAdapter.Fill(supplierTable);

                        comboBoxSupplierCode.DataSource = supplierTable;
                        comboBoxSupplierCode.DisplayMember = "SupplierName";
                        comboBoxSupplierCode.ValueMember = "SupplierCode";
                    }

                    string productQuery = "SELECT ProductCode, ProductName FROM Products";
                    using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                    {
                        SqlDataAdapter productAdapter = new SqlDataAdapter(productCommand);
                        DataTable productTable = new DataTable();
                        productAdapter.Fill(productTable);

                        comboBoxProductCode.DataSource = productTable;
                        comboBoxProductCode.DisplayMember = "ProductName";
                        comboBoxProductCode.ValueMember = "ProductCode";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void buttonAddSupply_Click(object sender, EventArgs e)
        {
            int supplierCode = Convert.ToInt32(comboBoxSupplierCode.SelectedValue);
            int productCode = Convert.ToInt32(comboBoxProductCode.SelectedValue);

            if (supplierCode <= 0 || productCode <= 0)
            {
                MessageBox.Show("Пожалуйста, выберите поставщика и продукт.");
                return;
            }

            if (IsSupplyExists(supplierCode, productCode))
            {
                MessageBox.Show("Данный поставщик уже поставляет данный товар.");
                return;
            }

            AddSupplyToDatabase(supplierCode, productCode);

            this.Close();
        }

        private bool IsSupplyExists(int supplierCode, int productCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SUPPLY WHERE SupplierCode = @supplierCode AND ProductCode = @productCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@supplierCode", supplierCode);
                    command.Parameters.AddWithValue("@productCode", productCode);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        private void AddSupplyToDatabase(int supplierCode, int productCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO SUPPLY (SupplierCode, ProductCode) VALUES (@supplierCode, @productCode)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierCode", supplierCode);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Поставка успешно добавлена.");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при добавлении поставки.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении поставки: " + ex.Message);
            }
        }
    }
}
