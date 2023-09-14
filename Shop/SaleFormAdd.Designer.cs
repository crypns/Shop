namespace Shop
{
    partial class SaleFormAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSoldQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.buttonAddSale = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoldQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Дата:";
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(15, 142);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerSaleDate.TabIndex = 53;
            // 
            // numericUpDownRetailPrice
            // 
            this.numericUpDownRetailPrice.DecimalPlaces = 2;
            this.numericUpDownRetailPrice.Location = new System.Drawing.Point(15, 103);
            this.numericUpDownRetailPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownRetailPrice.Name = "numericUpDownRetailPrice";
            this.numericUpDownRetailPrice.Size = new System.Drawing.Size(169, 20);
            this.numericUpDownRetailPrice.TabIndex = 52;
            // 
            // numericUpDownSoldQuantity
            // 
            this.numericUpDownSoldQuantity.Location = new System.Drawing.Point(15, 64);
            this.numericUpDownSoldQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSoldQuantity.Name = "numericUpDownSoldQuantity";
            this.numericUpDownSoldQuantity.Size = new System.Drawing.Size(169, 20);
            this.numericUpDownSoldQuantity.TabIndex = 51;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(15, 25);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(169, 21);
            this.comboBoxProducts.TabIndex = 50;
            // 
            // buttonAddSale
            // 
            this.buttonAddSale.Location = new System.Drawing.Point(15, 168);
            this.buttonAddSale.Name = "buttonAddSale";
            this.buttonAddSale.Size = new System.Drawing.Size(169, 23);
            this.buttonAddSale.TabIndex = 49;
            this.buttonAddSale.Text = "Добавить";
            this.buttonAddSale.UseVisualStyleBackColor = true;
            this.buttonAddSale.Click += new System.EventHandler(this.buttonAddSale_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 87);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 13);
            this.label40.TabIndex = 48;
            this.label40.Text = "Стоимость:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 48);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 13);
            this.label41.TabIndex = 47;
            this.label41.Text = "Количество:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(12, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 13);
            this.label42.TabIndex = 46;
            this.label42.Text = "Товар:";
            // 
            // SaleFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.numericUpDownRetailPrice);
            this.Controls.Add(this.numericUpDownSoldQuantity);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.buttonAddSale);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleFormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoldQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.NumericUpDown numericUpDownRetailPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownSoldQuantity;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button buttonAddSale;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
    }
}