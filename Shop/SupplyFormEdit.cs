using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplyFormEdit : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int supplierCode;
        private int productCode;
        private int selectedSupplierCode;
        private int selectedProductCode;

        public SupplyFormEdit(int selectedSupplierCode, int selectedProductCode)
        {
            InitializeComponent();
            this.selectedSupplierCode = selectedSupplierCode;
            this.selectedProductCode = selectedProductCode;
            LoadComboBoxData();
            LoadSupplyData();
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

        private void LoadSupplyData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM SUPPLY WHERE SupplierCode = @supplierCode AND ProductCode = @productCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierCode", selectedSupplierCode);
                        command.Parameters.AddWithValue("@productCode", selectedProductCode);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            comboBoxSupplierCode.SelectedValue = reader["SupplierCode"];
                            comboBoxProductCode.SelectedValue = reader["ProductCode"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных поставки: " + ex.Message);
            }
        }

        private void buttonSaveSupply_Click(object sender, EventArgs e)
        {
            int newSupplierCode = Convert.ToInt32(comboBoxSupplierCode.SelectedValue);
            int newProductCode = Convert.ToInt32(comboBoxProductCode.SelectedValue);

            if (newSupplierCode <= 0 || newProductCode <= 0)
            {
                MessageBox.Show("Пожалуйста, выберите поставщика и продукт.");
                return;
            }

            UpdateSupplyInDatabase(newSupplierCode, newProductCode);

            this.Close();
        }

        private void UpdateSupplyInDatabase(int newSupplierCode, int newProductCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE SUPPLY SET SupplierCode = @newSupplierCode, ProductCode = @newProductCode WHERE SupplierCode = @supplierCode AND ProductCode = @productCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newSupplierCode", newSupplierCode);
                        command.Parameters.AddWithValue("@newProductCode", newProductCode);
                        command.Parameters.AddWithValue("@supplierCode", selectedSupplierCode);
                        command.Parameters.AddWithValue("@productCode", selectedProductCode);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Поставка успешно обновлена.");
                        }
                        else
                        {
                            MessageBox.Show("Поставка не была обновлена. Проверьте введенные данные.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении поставки: " + ex.Message);
            }
        }


    }
}
