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
    public partial class ProductForm : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public ProductForm()
        {
            InitializeComponent();
            LoadProductsData();
            RenameDataGridViewColumns();
        }

        public void LoadProductsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ProductCode, ProductName, ArrivalDate, Quantity, PurchasePrice FROM Products";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable productsTable = new DataTable();
                        adapter.Fill(productsTable);

                        dataGridViewProducts.DataSource = productsTable;

                        labelTotalRecords.Text = "Всего записей: " + productsTable.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных из таблицы Products: " + ex.Message);
            }
        }

        private void RenameDataGridViewColumns()
        {
            dataGridViewProducts.Columns["ProductCode"].HeaderText = "Код продукта";
            dataGridViewProducts.Columns["ProductName"].HeaderText = "Наименование";
            dataGridViewProducts.Columns["ArrivalDate"].HeaderText = "Дата поставки";
            dataGridViewProducts.Columns["Quantity"].HeaderText = "Количество";
            dataGridViewProducts.Columns["PurchasePrice"].HeaderText = "Цена закупки";
            dataGridViewProducts.Columns["ProductCode"].Visible = false;
        }
        
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productCode = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductCode"].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот продукт?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteProductFromDatabase(productCode);
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления.");
            }
        }

        public void DeleteProductFromDatabase(int productCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Products WHERE ProductCode = @productCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productCode", productCode);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Продукт успешно удален.");
                            LoadProductsData();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при удалении продукта.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении продукта: " + ex.Message);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productCode = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductCode"].Value);

                ProductFormEdit productFormEdit = new ProductFormEdit(productCode);
                productFormEdit.ShowDialog();

                LoadProductsData();
            }
            else
            {
                MessageBox.Show("Выберите продукт для редактирования.");
            }
        }

        private void AddButtonProduct_Click(object sender, EventArgs e)
        {
            ProductFormAdd addProductForm = new ProductFormAdd();
            addProductForm.ShowDialog();

            LoadProductsData();
        }

        private void LoadProductsDataWithFilters(string productNameFilter, int minQuantity, int maxQuantity, decimal minPrice, decimal maxPrice, DateTime minDate, DateTime maxDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ProductCode, ProductName, ArrivalDate, Quantity, PurchasePrice FROM Products WHERE 1=1";

                if (!string.IsNullOrEmpty(productNameFilter))
                {
                    query += " AND ProductName LIKE @productNameFilter";
                }

                if (minQuantity > 0)
                {
                    query += " AND Quantity >= @minQuantity";
                }

                if (maxQuantity > 0)
                {
                    query += " AND Quantity <= @maxQuantity";
                }

                if (minPrice > 0)
                {
                    query += " AND PurchasePrice >= @minPrice";
                }

                if (maxPrice > 0)
                {
                    query += " AND PurchasePrice <= @maxPrice";
                }

                if (minDate != DateTime.MinValue)
                {
                    query += " AND ArrivalDate >= @minDate";
                }

                if (maxDate != DateTime.MinValue)
                {
                    query += " AND ArrivalDate <= @maxDate";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(productNameFilter))
                    {
                        command.Parameters.AddWithValue("@productNameFilter", "%" + productNameFilter + "%");
                    }

                    if (minQuantity > 0)
                    {
                        command.Parameters.AddWithValue("@minQuantity", minQuantity);
                    }

                    if (maxQuantity > 0)
                    {
                        command.Parameters.AddWithValue("@maxQuantity", maxQuantity);
                    }

                    if (minPrice > 0)
                    {
                        command.Parameters.AddWithValue("@minPrice", minPrice);
                    }

                    if (maxPrice > 0)
                    {
                        command.Parameters.AddWithValue("@maxPrice", maxPrice);
                    }

                    if (minDate != DateTime.MinValue)
                    {
                        command.Parameters.AddWithValue("@minDate", minDate);
                    }

                    if (maxDate != DateTime.MinValue)
                    {
                        command.Parameters.AddWithValue("@maxDate", maxDate);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable productsTable = new DataTable();
                    adapter.Fill(productsTable);

                    dataGridViewProducts.DataSource = productsTable;
                }
            }
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            string productNameFilter = textBoxProductNameFilter.Text;
            int minQuantity, maxQuantity;
            decimal minPrice, maxPrice;
            DateTime minDate, maxDate;

            if (!int.TryParse(textBoxMinQuantity.Text, out minQuantity))
            {
                minQuantity = 0;
            }

            if (!int.TryParse(textBoxMaxQuantity.Text, out maxQuantity))
            {
                maxQuantity = 0;
            }

            if (!decimal.TryParse(textBoxMinPrice.Text, out minPrice))
            {
                minPrice = 0;
            }

            if (!decimal.TryParse(textBoxMaxPrice.Text, out maxPrice))
            {
                maxPrice = 0;
            }

            if (!DateTime.TryParse(textBoxMinDate.Text, out minDate))
            {
                minDate = DateTime.MinValue;
            }

            if (!DateTime.TryParse(textBoxMaxDate.Text, out maxDate))
            {
                maxDate = DateTime.MinValue;
            }

            LoadProductsDataWithFilters(productNameFilter, minQuantity, maxQuantity, minPrice, maxPrice, minDate, maxDate);

            labelFilteredRecords.Text = dataGridViewProducts.Rows.Count.ToString();
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            textBoxProductNameFilter.Text = "";
            textBoxMinQuantity.Text = "";
            textBoxMaxQuantity.Text = "";
            textBoxMinPrice.Text = "";
            textBoxMaxPrice.Text = "";
            textBoxMinDate.Text = "";
            textBoxMaxDate.Text = "";

            LoadProductsData();

            labelFilteredRecords.Text = "0";
        }
    }
}
