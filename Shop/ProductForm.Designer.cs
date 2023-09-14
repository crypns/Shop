namespace Shop
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFilteredRecords = new System.Windows.Forms.Label();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMinQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxDate = new System.Windows.Forms.TextBox();
            this.textBoxMinDate = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxQuantity = new System.Windows.Forms.TextBox();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxProductNameFilter = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.AddButtonProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.Controls.Add(this.dataGridViewProducts, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox17, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(951, 566);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(745, 560);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox1);
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.groupBox19);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(754, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(194, 560);
            this.groupBox17.TabIndex = 2;
            this.groupBox17.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labelFilteredRecords);
            this.groupBox1.Controls.Add(this.labelTotalRecords);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 51);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Найдено записей: ";
            // 
            // labelFilteredRecords
            // 
            this.labelFilteredRecords.AutoSize = true;
            this.labelFilteredRecords.Location = new System.Drawing.Point(106, 31);
            this.labelFilteredRecords.Name = "labelFilteredRecords";
            this.labelFilteredRecords.Size = new System.Drawing.Size(13, 13);
            this.labelFilteredRecords.TabIndex = 22;
            this.labelFilteredRecords.Text = "0";
            // 
            // labelTotalRecords
            // 
            this.labelTotalRecords.AutoSize = true;
            this.labelTotalRecords.Location = new System.Drawing.Point(6, 16);
            this.labelTotalRecords.Name = "labelTotalRecords";
            this.labelTotalRecords.Size = new System.Drawing.Size(117, 13);
            this.labelTotalRecords.TabIndex = 21;
            this.labelTotalRecords.Text = "Количество записей: ";
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.buttonResetSearch);
            this.groupBox18.Controls.Add(this.label9);
            this.groupBox18.Controls.Add(this.label8);
            this.groupBox18.Controls.Add(this.label7);
            this.groupBox18.Controls.Add(this.label6);
            this.groupBox18.Controls.Add(this.label5);
            this.groupBox18.Controls.Add(this.label4);
            this.groupBox18.Controls.Add(this.label3);
            this.groupBox18.Controls.Add(this.textBoxMinQuantity);
            this.groupBox18.Controls.Add(this.label2);
            this.groupBox18.Controls.Add(this.label1);
            this.groupBox18.Controls.Add(this.textBoxMaxDate);
            this.groupBox18.Controls.Add(this.textBoxMinDate);
            this.groupBox18.Controls.Add(this.textBoxMaxPrice);
            this.groupBox18.Controls.Add(this.textBoxMinPrice);
            this.groupBox18.Controls.Add(this.textBoxMaxQuantity);
            this.groupBox18.Controls.Add(this.buttonProductSearch);
            this.groupBox18.Controls.Add(this.label33);
            this.groupBox18.Controls.Add(this.textBoxProductNameFilter);
            this.groupBox18.Location = new System.Drawing.Point(4, 66);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(184, 207);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Фильтрация данных";
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(100, 175);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonResetSearch.TabIndex = 27;
            this.buttonResetSearch.Text = "Сбросить";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "По:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "С:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Стоимость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "До:";
            // 
            // textBoxMinQuantity
            // 
            this.textBoxMinQuantity.Location = new System.Drawing.Point(36, 71);
            this.textBoxMinQuantity.Name = "textBoxMinQuantity";
            this.textBoxMinQuantity.Size = new System.Drawing.Size(54, 20);
            this.textBoxMinQuantity.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "От:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Количество:";
            // 
            // textBoxMaxDate
            // 
            this.textBoxMaxDate.Location = new System.Drawing.Point(120, 149);
            this.textBoxMaxDate.Name = "textBoxMaxDate";
            this.textBoxMaxDate.Size = new System.Drawing.Size(54, 20);
            this.textBoxMaxDate.TabIndex = 17;
            // 
            // textBoxMinDate
            // 
            this.textBoxMinDate.Location = new System.Drawing.Point(36, 149);
            this.textBoxMinDate.Name = "textBoxMinDate";
            this.textBoxMinDate.Size = new System.Drawing.Size(54, 20);
            this.textBoxMinDate.TabIndex = 16;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(120, 110);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(54, 20);
            this.textBoxMaxPrice.TabIndex = 15;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(36, 110);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(54, 20);
            this.textBoxMinPrice.TabIndex = 14;
            // 
            // textBoxMaxQuantity
            // 
            this.textBoxMaxQuantity.Location = new System.Drawing.Point(120, 71);
            this.textBoxMaxQuantity.Name = "textBoxMaxQuantity";
            this.textBoxMaxQuantity.Size = new System.Drawing.Size(54, 20);
            this.textBoxMaxQuantity.TabIndex = 13;
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(15, 175);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonProductSearch.TabIndex = 11;
            this.buttonProductSearch.Text = "Поиск";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Название:";
            // 
            // textBoxProductNameFilter
            // 
            this.textBoxProductNameFilter.Location = new System.Drawing.Point(10, 32);
            this.textBoxProductNameFilter.Name = "textBoxProductNameFilter";
            this.textBoxProductNameFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxProductNameFilter.TabIndex = 2;
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox19.Controls.Add(this.buttonEditProduct);
            this.groupBox19.Controls.Add(this.buttonDeleteProduct);
            this.groupBox19.Controls.Add(this.AddButtonProduct);
            this.groupBox19.Location = new System.Drawing.Point(4, 279);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(184, 112);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Управление данными";
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(5, 50);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(169, 23);
            this.buttonEditProduct.TabIndex = 18;
            this.buttonEditProduct.Text = "Редактировать запись";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(5, 79);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(169, 23);
            this.buttonDeleteProduct.TabIndex = 17;
            this.buttonDeleteProduct.Text = "Удалить запись";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // AddButtonProduct
            // 
            this.AddButtonProduct.Location = new System.Drawing.Point(5, 21);
            this.AddButtonProduct.Name = "AddButtonProduct";
            this.AddButtonProduct.Size = new System.Drawing.Size(169, 23);
            this.AddButtonProduct.TabIndex = 19;
            this.AddButtonProduct.Text = "Добавить товар";
            this.AddButtonProduct.Click += new System.EventHandler(this.AddButtonProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 566);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxProductNameFilter;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button AddButtonProduct;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.TextBox textBoxMaxDate;
        private System.Windows.Forms.TextBox textBoxMinDate;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxQuantity;
        private System.Windows.Forms.TextBox textBoxMinQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalRecords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFilteredRecords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonResetSearch;
        public System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}