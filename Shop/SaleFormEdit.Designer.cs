namespace Shop
{
    partial class SaleFormEdit
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
            this.buttonSaveSale = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.numericUpDownSoldQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoldQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetailPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveSale
            // 
            this.buttonSaveSale.Location = new System.Drawing.Point(15, 168);
            this.buttonSaveSale.Name = "buttonSaveSale";
            this.buttonSaveSale.Size = new System.Drawing.Size(169, 23);
            this.buttonSaveSale.TabIndex = 40;
            this.buttonSaveSale.Text = "Сохранить изменения";
            this.buttonSaveSale.UseVisualStyleBackColor = true;
            this.buttonSaveSale.Click += new System.EventHandler(this.buttonSaveSale_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 87);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 13);
            this.label40.TabIndex = 39;
            this.label40.Text = "Стоимость:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 48);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 13);
            this.label41.TabIndex = 38;
            this.label41.Text = "Количество:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(12, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 13);
            this.label42.TabIndex = 37;
            this.label42.Text = "Товар:";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(15, 25);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(169, 21);
            this.comboBoxProducts.TabIndex = 41;
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
            this.numericUpDownSoldQuantity.TabIndex = 42;
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
            this.numericUpDownRetailPrice.TabIndex = 43;
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(15, 142);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerSaleDate.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Дата:";
            // 
            // SaleFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.numericUpDownRetailPrice);
            this.Controls.Add(this.numericUpDownSoldQuantity);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.buttonSaveSale);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoldQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetailPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveSale;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.NumericUpDown numericUpDownSoldQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownRetailPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.Label label1;
    }
}