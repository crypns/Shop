using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;
using ShopLibrary; 

namespace UnitTestShopLibrary
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";

        [TestMethod]
        public void TestExecuteNonQuery()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string updateQuery = "UPDATE PRODUCTS SET Quantity = @NewQuantity WHERE ProductCode = @ProductCode";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@NewQuantity", 10),
            new SqlParameter("@ProductCode", 1)
            };

            int rowsAffected = databaseController.ExecuteNonQuery(updateQuery, parameters);

            Assert.IsTrue(rowsAffected >= 0);
        }

        [TestMethod]
        public void TestExecuteScalar()
        {
            // Arrange
            DatabaseController databaseController = new DatabaseController(connectionString);
            string scalarQuery = "SELECT COUNT(*) FROM PRODUCTS";

            // Act
            object result = databaseController.ExecuteScalar(scalarQuery);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestExecuteQuery()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string selectQuery = "SELECT * FROM PRODUCTS";

            var table = databaseController.ExecuteQuery(selectQuery);

            Assert.IsNotNull(table);
            Assert.IsTrue(table.Rows.Count > 0);
        }

        [TestMethod]
        public void TestInsertProduct()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string insertQuery = "INSERT INTO PRODUCTS (ProductName, ArrivalDate, Quantity, PurchasePrice) VALUES (@ProductName, @ArrivalDate, @Quantity, @PurchasePrice)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ProductName", "Test Product"),
            new SqlParameter("@ArrivalDate", DateTime.Now),
            new SqlParameter("@Quantity", 10),
            new SqlParameter("@PurchasePrice", 50.00M)
            };

            int rowsAffected = databaseController.ExecuteNonQuery(insertQuery, parameters);

            Assert.IsTrue(rowsAffected > 0);
        }

        [TestMethod]
        public void TestInsertSupplier()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string insertQuery = "INSERT INTO SUPPLIERS (SupplierName, Address, Phone, ContactPerson) VALUES (@SupplierName, @Address, @Phone, @ContactPerson)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@SupplierName", "Test Supplier"),
            new SqlParameter("@Address", "Test Address"),
            new SqlParameter("@Phone", "1234567890"),
            new SqlParameter("@ContactPerson", "Test Contact")
            };

            int rowsAffected = databaseController.ExecuteNonQuery(insertQuery, parameters);

            Assert.IsTrue(rowsAffected > 0);
        }

        [TestMethod]
        public void TestInsertUser()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string insertQuery = "INSERT INTO USERS (Role, Username, Password, Fullname) VALUES (@Role, @Username, @Password, @Fullname)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Role", "role"),
            new SqlParameter("@Username", "user"),
            new SqlParameter("@Password", "password"),
            new SqlParameter("@Fullname", "fullname")
            };

            int rowsAffected = databaseController.ExecuteNonQuery(insertQuery, parameters);

            Assert.IsTrue(rowsAffected > 0);
        }

        [TestMethod]
        public void TestSelectProducts()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string selectQuery = "SELECT * FROM PRODUCTS";

            DataTable table = databaseController.ExecuteQuery(selectQuery);

            Assert.IsNotNull(table);
            Assert.IsTrue(table.Rows.Count > 0);
        }

        [TestMethod]
        public void TestSelectSuppliers()
        {
            // Arrange
            DatabaseController databaseController = new DatabaseController(connectionString);
            string selectQuery = "SELECT * FROM SUPPLIERS";

            // Act
            DataTable table = databaseController.ExecuteQuery(selectQuery);

            // Assert
            Assert.IsNotNull(table);
            Assert.IsTrue(table.Rows.Count > 0);
        }

        [TestMethod]
        public void TestSelectUsers()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string selectQuery = "SELECT * FROM USERS";

            DataTable table = databaseController.ExecuteQuery(selectQuery);

            Assert.IsNotNull(table);
            Assert.IsTrue(table.Rows.Count > 0);
        }

        [TestMethod]
        public void TestInsertSale()
        {
            DatabaseController databaseController = new DatabaseController(connectionString);
            string insertQuery = "INSERT INTO SALES (ProductCode, SaleDate, SoldQuantity, RetailPrice) VALUES (@ProductCode, @SaleDate, @SoldQuantity, @RetailPrice)";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@ProductCode", 50),
        new SqlParameter("@SaleDate", DateTime.Now),
        new SqlParameter("@SoldQuantity", 5),
        new SqlParameter("@RetailPrice", 100.00M)
            };

            int rowsAffected = databaseController.ExecuteNonQuery(insertQuery, parameters);

            Assert.IsTrue(rowsAffected > 0);
        }

    }
}
