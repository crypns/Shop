using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplyForm : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public SupplyForm()
        {
            InitializeComponent();
            LoadSupplyData();
            RenameDataGridViewColumns();
        }

        private void LoadSupplyData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT S.SupplierCode, S.ProductCode, Su.SupplierName, Pr.ProductName " +
                                   "FROM SUPPLY S " +
                                   "INNER JOIN Suppliers Su ON S.SupplierCode = Su.SupplierCode " +
                                   "INNER JOIN Products Pr ON S.ProductCode = Pr.ProductCode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable supplyTable = new DataTable();
                        adapter.Fill(supplyTable);

                        dataGridViewSupply.DataSource = supplyTable;

                        labelTotalRecords.Text = "Всего записей: " + supplyTable.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных из таблицы SUPPLY: " + ex.Message);
            }
        }



        private void RenameDataGridViewColumns()
        {
            dataGridViewSupply.Columns["SupplierCode"].HeaderText = "Код поставщика";
            dataGridViewSupply.Columns["ProductCode"].HeaderText = "Код продукта";
            dataGridViewSupply.Columns["SupplierName"].HeaderText = "Поставщик";
            dataGridViewSupply.Columns["ProductName"].HeaderText = "Продукт";
            dataGridViewSupply.Columns["SupplierCode"].Visible = false;
            dataGridViewSupply.Columns["ProductCode"].Visible = false;
        }


        private void AddButtonSupply_Click(object sender, EventArgs e)
        {
            SupplyFormAdd addSupplyForm = new SupplyFormAdd();
            addSupplyForm.ShowDialog();

            LoadSupplyData();
        }


        private void buttonEditSupply_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupply.SelectedRows.Count > 0)
            {
                int supplierCode = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells["SupplierCode"].Value);
                int productCode = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells["ProductCode"].Value);

                SupplyFormEdit supplyFormEdit = new SupplyFormEdit(supplierCode, productCode);
                supplyFormEdit.ShowDialog();

                LoadSupplyData();
            }
            else
            {
                MessageBox.Show("Выберите поставку для редактирования.");
            }
        }


        private void buttonDeleteSupply_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupply.SelectedRows.Count > 0)
            {
                int supplierCode = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells["SupplierCode"].Value);
                int productCode = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells["ProductCode"].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту поставку?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteSupplyFromDatabase(supplierCode, productCode);
                }
            }
            else
            {
                MessageBox.Show("Выберите поставку для удаления.");
            }
        }

        private void DeleteSupplyFromDatabase(int supplierCode, int productCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM SUPPLY WHERE SupplierCode = @supplierCode AND ProductCode = @productCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierCode", supplierCode);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Поставка успешно удалена.");
                            LoadSupplyData();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при удалении поставки.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении поставки: " + ex.Message);
            }
        }

        private void buttonSupplySearch_Click(object sender, EventArgs e)
        {
            string supplierFilter = textBoxSupplierFilter.Text.Trim();
            string productFilter = textBoxProductFilter.Text.Trim();

            LoadSupplyDataWithFilters(supplierFilter, productFilter);
        }

        private void LoadSupplyDataWithFilters(string supplierFilter, string productFilter)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT S.SupplierCode, S.ProductCode, Su.SupplierName, Pr.ProductName " +
                                   "FROM SUPPLY S " +
                                   "INNER JOIN Suppliers Su ON S.SupplierCode = Su.SupplierCode " +
                                   "INNER JOIN Products Pr ON S.ProductCode = Pr.ProductCode " +
                                   "WHERE Su.SupplierName LIKE @supplierFilter AND Pr.ProductName LIKE @productFilter";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierFilter", "%" + supplierFilter + "%");
                        command.Parameters.AddWithValue("@productFilter", "%" + productFilter + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable supplyTable = new DataTable();
                        adapter.Fill(supplyTable);

                        dataGridViewSupply.DataSource = supplyTable;

                        labelFilteredRecords.Text = supplyTable.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных из таблицы SUPPLY: " + ex.Message);
            }
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        { 
            textBoxSupplierFilter.Clear();
            textBoxProductFilter.Clear();

            LoadSupplyData();

            labelFilteredRecords.Text = "0";
        }
    }
}
