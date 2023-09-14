using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplierForm : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliersData();
            RenameDataGridViewColumns();
        }

        private void LoadSuppliersData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SupplierCode, SupplierName, Address, Phone, ContactPerson FROM Suppliers";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable suppliersTable = new DataTable();
                        adapter.Fill(suppliersTable);

                        dataGridViewSuppliers.DataSource = suppliersTable;

                        labelTotalRecords.Text = "Всего записей: " + suppliersTable.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных из таблицы Suppliers: " + ex.Message);
            }
        }

        private void RenameDataGridViewColumns()
        {
            dataGridViewSuppliers.Columns["SupplierCode"].HeaderText = "Код поставщика";
            dataGridViewSuppliers.Columns["SupplierName"].HeaderText = "Наименование поставщика";
            dataGridViewSuppliers.Columns["Address"].HeaderText = "Адрес";
            dataGridViewSuppliers.Columns["Phone"].HeaderText = "Телефон";
            dataGridViewSuppliers.Columns["ContactPerson"].HeaderText = "Контактное лицо";
            dataGridViewSuppliers.Columns["SupplierCode"].Visible = false;
        }

        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                int supplierCode = Convert.ToInt32(dataGridViewSuppliers.SelectedRows[0].Cells["SupplierCode"].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого поставщика?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteSupplierFromDatabase(supplierCode);
                }
            }
            else
            {
                MessageBox.Show("Выберите поставщика для удаления.");
            }
        }

        private void DeleteSupplierFromDatabase(int supplierCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Suppliers WHERE SupplierCode = @supplierCode";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierCode", supplierCode);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Поставщик успешно удален.");
                            LoadSuppliersData();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при удалении поставщика.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении поставщика: " + ex.Message);
            }
        }

        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                int supplierCode = Convert.ToInt32(dataGridViewSuppliers.SelectedRows[0].Cells["SupplierCode"].Value);

                SupplierFormEdit suppliersFormEdit = new SupplierFormEdit(supplierCode);
                suppliersFormEdit.ShowDialog();

                LoadSuppliersData();
            }
            else
            {
                MessageBox.Show("Выберите поставщика для редактирования.");
            }
        }

        private void AddButtonSupplier_Click(object sender, EventArgs e)
        {
            SupplierFormAdd addSuppliersForm = new SupplierFormAdd();
            addSuppliersForm.ShowDialog();

            LoadSuppliersData();
        }

        private void LoadSuppliersDataWithFilters(string supplierNameFilter, string addressFilter, string phoneFilter, string contactPersonFilter)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SupplierCode, SupplierName, Address, Phone, ContactPerson FROM Suppliers WHERE 1=1";

                if (!string.IsNullOrEmpty(supplierNameFilter))
                {
                    query += " AND SupplierName LIKE @supplierNameFilter";
                }

                if (!string.IsNullOrEmpty(addressFilter))
                {
                    query += " AND Address LIKE @addressFilter";
                }

                if (!string.IsNullOrEmpty(phoneFilter))
                {
                    query += " AND Phone LIKE @phoneFilter";
                }

                if (!string.IsNullOrEmpty(contactPersonFilter))
                {
                    query += " AND ContactPerson LIKE @contactPersonFilter";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(supplierNameFilter))
                    {
                        command.Parameters.AddWithValue("@supplierNameFilter", "%" + supplierNameFilter + "%");
                    }

                    if (!string.IsNullOrEmpty(addressFilter))
                    {
                        command.Parameters.AddWithValue("@addressFilter", "%" + addressFilter + "%");
                    }

                    if (!string.IsNullOrEmpty(phoneFilter))
                    {
                        command.Parameters.AddWithValue("@phoneFilter", "%" + phoneFilter + "%");
                    }

                    if (!string.IsNullOrEmpty(contactPersonFilter))
                    {
                        command.Parameters.AddWithValue("@contactPersonFilter", "%" + contactPersonFilter + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable suppliersTable = new DataTable();
                    adapter.Fill(suppliersTable);

                    dataGridViewSuppliers.DataSource = suppliersTable;
                }
            }
        }

        private void buttonSupplierSearch_Click(object sender, EventArgs e)
        {
            string supplierNameFilter = textBoxSupplierNameFilter.Text;
            string addressFilter = textBoxAddressFilter.Text;
            string phoneFilter = textBoxPhoneFilter.Text;
            string contactPersonFilter = textBoxContactPersonFilter.Text;

            LoadSuppliersDataWithFilters(supplierNameFilter, addressFilter, phoneFilter, contactPersonFilter);

            labelFilteredRecords.Text = dataGridViewSuppliers.Rows.Count.ToString();
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            textBoxSupplierNameFilter.Text = "";
            textBoxAddressFilter.Text = "";
            textBoxPhoneFilter.Text = "";
            textBoxContactPersonFilter.Text = "";

            labelFilteredRecords.Text = "0";

            LoadSuppliersData();
        }
    }
}
