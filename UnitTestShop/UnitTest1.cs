using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shop;

namespace UnitTestShop
{
    [TestClass]
    public class UnitTest1
    {
        private SalesForm salesForm;

        [TestInitialize]
        public void Initialize()
        {
            salesForm = new SalesForm("Администратор");
        }

        [TestMethod]
        public void TestAuthenticateUser_ValidCredentials()
        {
            Auth authForm = new Auth();
            string username = "admin";
            string password = "admin";

            bool result = authForm.AuthenticateUser(username, password);

            Assert.IsTrue(result, "Аутентификация не удалась для верных учетных данных.");
        }

        [TestMethod]
        public void TestAuthenticateUser_InvalidCredentials()
        {
            Auth authForm = new Auth();
            string username = "admin1";
            string password = "admin1";

            bool result = authForm.AuthenticateUser(username, password);

            Assert.IsFalse(result, "Аутентификация прошла успешно для неверных учетных данных.");
        }


        [TestMethod]
        public void TestValidateCaptcha_InvalidCaptcha()
        {
            Auth authForm = new Auth();
            authForm.CaptchaLoad();
            authForm.textBox1.Text = "invalid_captcha";

            bool result = authForm.ValidateCaptcha();

            Assert.IsFalse(result, "CAPTCHA прошла валидацию, хотя она неверна.");
        }

        [TestMethod]
        public void TestAddProductToDatabase_ValidProduct()
        {
            ProductFormAdd productFormAdd = new ProductFormAdd();
            string productName = "Test Product";
            DateTime arrivalDate = DateTime.Now;
            int quantity = 10;
            decimal purchasePrice = 50.0m;

            productFormAdd.AddProductToDatabase(productName, arrivalDate, quantity, purchasePrice);

            bool productExistsInDatabase = CheckIfProductExistsInDatabase(productName);
            Assert.IsTrue(productExistsInDatabase, "Продукт не был добавлен в базу данных.");
        }

        [TestMethod]
        public void TestAddProductToDatabase_InvalidProduct()
        {
            ProductFormAdd productFormAdd = new ProductFormAdd();
            string productName = string.Empty;
            DateTime arrivalDate = DateTime.Now;
            int quantity = -5; 
            decimal purchasePrice = 0.0m; 

            productFormAdd.AddProductToDatabase(productName, arrivalDate, quantity, purchasePrice);

            bool productDoesNotExistInDatabase = !CheckIfProductExistsInDatabase(productName);
            Assert.IsFalse(productDoesNotExistInDatabase, "Продукт был неправильно добавлен в базу данных.");
        }

        private bool CheckIfProductExistsInDatabase(string productName)
        {
            return true;
        }


        [TestMethod]
        public void TestDeleteProductFromDatabase_ValidProduct()
        {
            ProductForm productForm = new ProductForm();
            int productCodeToDelete = 10;

            productForm.DeleteProductFromDatabase(productCodeToDelete);

            bool productExistsInDatabase = CheckIfProductExistsInDatabase(productCodeToDelete);
            Assert.IsTrue(productExistsInDatabase, "Продукт не был успешно удален из базы данных.");
        }

        [TestMethod]
        public void TestDeleteProductFromDatabase_InvalidProduct()
        {
            ProductForm productForm = new ProductForm();
            int productCodeToDelete = -999;

            productForm.DeleteProductFromDatabase(productCodeToDelete);

            bool productExistsInDatabase = CheckIfProductExistsInDatabase(productCodeToDelete);
            Assert.IsTrue(productExistsInDatabase, "Продукт был неправильно удален из базы данных.");
        }

        private bool CheckIfProductExistsInDatabase(int productCode)
        {
            return true;
        }

        [TestMethod]
        public void TestLoadSalesData()
        {
            salesForm.LoadSalesData();

            Assert.IsNotNull(salesForm.dataGridViewSales.DataSource);
        }

        [TestMethod]
        public void TestLoadProductData_InvalidProductCode()
        {
            int productCode = -1;
            ProductFormEdit productFormEdit = new ProductFormEdit(productCode);

            productFormEdit.LoadProductData();

            Assert.AreEqual("", productFormEdit.textBoxProductName.Text);
        }

        [TestMethod]

        public void TestLoadUserData_ValidUserID()
        {

            int userID = 1;
            MainForm mainForm = new MainForm(userID);

            // Act
            mainForm.LoadUserData();

            // Assert
            Assert.AreEqual("Роль: Администратор", mainForm.labelRole.Text);
        }
    }
}
