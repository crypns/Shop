using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Windows.Forms;


namespace Shop
{
    public partial class SalesForm : Form
    {
        public string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        private string userRole;
        public SalesForm(string userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
            LoadSalesData();
            RenameDataGridViewColumns();
        }


        public void LoadSalesData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT S.SaleCode, S.ProductCode, P.ProductName, S.SaleDate, S.SoldQuantity, S.RetailPrice " +
                                   "FROM Sales S " +
                                   "JOIN Products P ON S.ProductCode = P.ProductCode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable salesTable = new DataTable();
                        adapter.Fill(salesTable);

                        dataGridViewSales.DataSource = salesTable;

                        labelTotalRecords.Text = "Всего записей: " + salesTable.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных из таблицы Sales: " + ex.Message);
            }
        }


        private void RenameDataGridViewColumns()
        {
            dataGridViewSales.Columns["SaleCode"].HeaderText = "Код продажи";
            dataGridViewSales.Columns["ProductCode"].HeaderText = "Код продукта";
            dataGridViewSales.Columns["ProductName"].HeaderText = "Товар";
            dataGridViewSales.Columns["SaleDate"].HeaderText = "Дата продажи";
            dataGridViewSales.Columns["SoldQuantity"].HeaderText = "Проданное количество";
            dataGridViewSales.Columns["RetailPrice"].HeaderText = "Розничная цена";
            dataGridViewSales.Columns["ProductCode"].Visible = false;
            dataGridViewSales.Columns["SaleCode"].Visible = false;
        }

        private void buttonDeleteSale_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                int saleCode = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells["SaleCode"].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту продажу?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteSaleFromDatabase(saleCode);
                }
            }
            else
            {
                MessageBox.Show("Выберите продажу для удаления.");
            }
        }

        private void DeleteSaleFromDatabase(int saleCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Sales WHERE SaleCode = @saleCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@saleCode", saleCode);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Продажа успешно удалена.");
                            LoadSalesData();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при удалении продажи.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении продажи: " + ex.Message);
            }
        }

        private void buttonEditSale_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                int saleCode = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells["SaleCode"].Value);

                SaleFormEdit saleFormEdit = new SaleFormEdit(saleCode);
                saleFormEdit.ShowDialog();

                LoadSalesData();
            }
            else
            {
                MessageBox.Show("Выберите продажу для редактирования.");
            }
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            SaleFormAdd addSaleForm = new SaleFormAdd();
            addSaleForm.ShowDialog();

            LoadSalesData();
        }

        private void LoadSalesDataWithFilters(string productNameFilter, DateTime minDate, DateTime maxDate, int minQuantity, int maxQuantity, decimal minPrice, decimal maxPrice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT S.SaleCode, S.ProductCode, P.ProductName, S.SaleDate, S.SoldQuantity, S.RetailPrice " +
                               "FROM Sales S " +
                               "JOIN Products P ON S.ProductCode = P.ProductCode " +
                               "WHERE 1=1";

                if (!string.IsNullOrEmpty(productNameFilter))
                {
                    query += " AND P.ProductName LIKE @productNameFilter";
                }

                if (!DateTime.TryParse(textBoxMinDate.Text, out minDate))
                {
                    minDate = SqlDateTime.MinValue.Value;
                }

                if (!DateTime.TryParse(textBoxMaxDate.Text, out maxDate))
                {
                    maxDate = SqlDateTime.MaxValue.Value;
                }


                if (minQuantity > 0)
                {
                    query += " AND S.SoldQuantity >= @minQuantity";
                }

                if (maxQuantity > 0)
                {
                    query += " AND S.SoldQuantity <= @maxQuantity";
                }

                if (minPrice > 0)
                {
                    query += " AND S.RetailPrice >= @minPrice";
                }

                if (maxPrice > 0)
                {
                    query += " AND S.RetailPrice <= @maxPrice";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(productNameFilter))
                    {
                        command.Parameters.AddWithValue("@productNameFilter", "%" + productNameFilter + "%");
                    }

                    command.Parameters.AddWithValue("@minDate", minDate);
                    command.Parameters.AddWithValue("@maxDate", maxDate);
                    command.Parameters.AddWithValue("@minQuantity", minQuantity);
                    command.Parameters.AddWithValue("@maxQuantity", maxQuantity);
                    command.Parameters.AddWithValue("@minPrice", minPrice);
                    command.Parameters.AddWithValue("@maxPrice", maxPrice);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable salesTable = new DataTable();
                    adapter.Fill(salesTable);

                    dataGridViewSales.DataSource = salesTable;

                    labelFilteredRecords.Text = salesTable.Rows.Count.ToString();
                }
            }
        }

        private void buttonSaleSearch_Click(object sender, EventArgs e)
        {
            string productNameFilter = textBoxProductNameFilter.Text;
            DateTime minDate, maxDate;
            int minQuantity, maxQuantity;
            decimal minPrice, maxPrice;

            if (!DateTime.TryParse(textBoxMinDate.Text, out minDate))
            {
                minDate = DateTime.MinValue;
            }

            if (!DateTime.TryParse(textBoxMaxDate.Text, out maxDate))
            {
                maxDate = DateTime.MaxValue;
            }

            if (!int.TryParse(textBoxMinQuantity.Text, out minQuantity))
            {
                minQuantity = 0;
            }

            if (!int.TryParse(textBoxMaxQuantity.Text, out maxQuantity))
            {
                maxQuantity = int.MaxValue;
            }

            if (!decimal.TryParse(textBoxMinPrice.Text, out minPrice))
            {
                minPrice = 0;
            }

            if (!decimal.TryParse(textBoxMaxPrice.Text, out maxPrice))
            {
                maxPrice = decimal.MaxValue;
            }

            LoadSalesDataWithFilters(productNameFilter, minDate, maxDate, minQuantity, maxQuantity, minPrice, maxPrice);


        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            textBoxProductNameFilter.Text = "";
            textBoxMinDate.Text = "";
            textBoxMaxDate.Text = "";
            textBoxMinQuantity.Text = "";
            textBoxMaxQuantity.Text = "";
            textBoxMinPrice.Text = "";
            textBoxMaxPrice.Text = "";

            LoadSalesData();

            labelFilteredRecords.Text = "0";
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            if (userRole == "Администратор")
            {
                try
                {
                    DateTime startDate = dateTimePickerStartDate.Value;
                    DateTime endDate = dateTimePickerEndDate.Value;

                    GenerateSalesReport(startDate, endDate);
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Выберите дату начала и конца периода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("У вас нет разрешения на выполнение этой операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GenerateSalesReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(S.SoldQuantity) AS TotalQuantity, SUM(S.SoldQuantity * S.RetailPrice) AS TotalAmount " +
                                   "FROM Sales S " +
                                   "WHERE S.SaleDate BETWEEN @startDate AND @endDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read(); // Переходим к первой строке результата (если она есть)
                            int totalQuantity = reader.IsDBNull(reader.GetOrdinal("TotalQuantity")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalQuantity"));
                            decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("TotalAmount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("TotalAmount"));

                            string reportMessage = $"Продано товаров: {totalQuantity}\nОбщая сумма продаж: {totalAmount:C2}";

                            MessageBox.Show(reportMessage, "Отчет о продажах за период", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("За выбранный период не найдено продаж.", "Отчет о продажах за период", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при формировании отчета: " + ex.Message);
            }
        }

    }
}