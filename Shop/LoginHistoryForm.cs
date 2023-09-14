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
    public partial class LoginHistoryForm : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        private int userID;
        private BindingSource loginHistoryBindingSource = new BindingSource();

        public LoginHistoryForm()
        {
            InitializeComponent();
            LoadLoginHistory();
            RenameDataGridViewColumns();
        }

        private void RenameDataGridViewColumns()
        {
            dataGridViewLoginHistory.Columns["Username"].HeaderText = "Имя пользователя";
            dataGridViewLoginHistory.Columns["LoginTime"].HeaderText = "Время входа";
            dataGridViewLoginHistory.Columns["login_success"].HeaderText = "Успешный вход";
        }

        private void LoadLoginHistory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT lh.LoginHistoryID, u.Username, lh.LoginTime, lh.login_success " +
                               "FROM login_history lh " +
                               "INNER JOIN users u ON lh.UserID = u.UserID ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable loginHistoryTable = new DataTable();
                    adapter.Fill(loginHistoryTable);

                    loginHistoryTable.Columns.Remove("LoginHistoryID");

                    loginHistoryBindingSource.DataSource = loginHistoryTable;

                    dataGridViewLoginHistory.DataSource = loginHistoryBindingSource;

                    loginHistoryTable.DefaultView.Sort = "LoginTime DESC";
                }
            }
        }

        private void txtUsernameFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = string.Format("Username LIKE '%{0}%'", txtUsernameFilter.Text);
            loginHistoryBindingSource.Filter = filter;
        }
    }
}
