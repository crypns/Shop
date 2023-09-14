namespace Shop
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.buttonEditSupplier = new System.Windows.Forms.Button();
            this.AddButtonSupplier = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteSupplier = new System.Windows.Forms.Button();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFilteredRecords = new System.Windows.Forms.Label();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.textBoxAddressFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContactPersonFilter = new System.Windows.Forms.TextBox();
            this.textBoxPhoneFilter = new System.Windows.Forms.TextBox();
            this.buttonSupplierSearch = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxSupplierNameFilter = new System.Windows.Forms.TextBox();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Location = new System.Drawing.Point(5, 50);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(169, 23);
            this.buttonEditSupplier.TabIndex = 18;
            this.buttonEditSupplier.Text = "Редактировать запись";
            this.buttonEditSupplier.UseVisualStyleBackColor = true;
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // AddButtonSupplier
            // 
            this.AddButtonSupplier.Location = new System.Drawing.Point(5, 21);
            this.AddButtonSupplier.Name = "AddButtonSupplier";
            this.AddButtonSupplier.Size = new System.Drawing.Size(169, 23);
            this.AddButtonSupplier.TabIndex = 19;
            this.AddButtonSupplier.Text = "Добавить поставщика";
            this.AddButtonSupplier.Click += new System.EventHandler(this.AddButtonSupplier_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox19.Controls.Add(this.buttonEditSupplier);
            this.groupBox19.Controls.Add(this.buttonDeleteSupplier);
            this.groupBox19.Controls.Add(this.AddButtonSupplier);
            this.groupBox19.Location = new System.Drawing.Point(4, 279);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(184, 112);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Управление данными";
            // 
            // buttonDeleteSupplier
            // 
            this.buttonDeleteSupplier.Location = new System.Drawing.Point(5, 79);
            this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            this.buttonDeleteSupplier.Size = new System.Drawing.Size(169, 23);
            this.buttonDeleteSupplier.TabIndex = 17;
            this.buttonDeleteSupplier.Text = "Удалить запись";
            this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(99, 175);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonResetSearch.TabIndex = 27;
            this.buttonResetSearch.Text = "Сбросить";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Контактные данные:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Телефон:";
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.AllowUserToResizeColumns = false;
            this.dataGridViewSuppliers.AllowUserToResizeRows = false;
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSuppliers.MultiSelect = false;
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(594, 444);
            this.dataGridViewSuppliers.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.Controls.Add(this.dataGridViewSuppliers, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox17, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox1);
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.groupBox19);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(603, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(194, 444);
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
            this.groupBox18.Controls.Add(this.label7);
            this.groupBox18.Controls.Add(this.label6);
            this.groupBox18.Controls.Add(this.textBoxAddressFilter);
            this.groupBox18.Controls.Add(this.label1);
            this.groupBox18.Controls.Add(this.textBoxContactPersonFilter);
            this.groupBox18.Controls.Add(this.textBoxPhoneFilter);
            this.groupBox18.Controls.Add(this.buttonSupplierSearch);
            this.groupBox18.Controls.Add(this.label33);
            this.groupBox18.Controls.Add(this.textBoxSupplierNameFilter);
            this.groupBox18.Location = new System.Drawing.Point(4, 66);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(184, 207);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Фильтрация данных";
            // 
            // textBoxAddressFilter
            // 
            this.textBoxAddressFilter.Location = new System.Drawing.Point(10, 71);
            this.textBoxAddressFilter.Name = "textBoxAddressFilter";
            this.textBoxAddressFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxAddressFilter.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Адрес:";
            // 
            // textBoxContactPersonFilter
            // 
            this.textBoxContactPersonFilter.Location = new System.Drawing.Point(10, 149);
            this.textBoxContactPersonFilter.Name = "textBoxContactPersonFilter";
            this.textBoxContactPersonFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxContactPersonFilter.TabIndex = 14;
            // 
            // textBoxPhoneFilter
            // 
            this.textBoxPhoneFilter.Location = new System.Drawing.Point(10, 110);
            this.textBoxPhoneFilter.Name = "textBoxPhoneFilter";
            this.textBoxPhoneFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxPhoneFilter.TabIndex = 13;
            // 
            // buttonSupplierSearch
            // 
            this.buttonSupplierSearch.Location = new System.Drawing.Point(10, 175);
            this.buttonSupplierSearch.Name = "buttonSupplierSearch";
            this.buttonSupplierSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSupplierSearch.TabIndex = 11;
            this.buttonSupplierSearch.Text = "Поиск";
            this.buttonSupplierSearch.UseVisualStyleBackColor = true;
            this.buttonSupplierSearch.Click += new System.EventHandler(this.buttonSupplierSearch_Click);
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
            // textBoxSupplierNameFilter
            // 
            this.textBoxSupplierNameFilter.Location = new System.Drawing.Point(10, 32);
            this.textBoxSupplierNameFilter.Name = "textBoxSupplierNameFilter";
            this.textBoxSupplierNameFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxSupplierNameFilter.TabIndex = 2;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierForm";
            this.Text = "Поставщики";
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditSupplier;
        private System.Windows.Forms.Button AddButtonSupplier;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button buttonDeleteSupplier;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFilteredRecords;
        private System.Windows.Forms.Label labelTotalRecords;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox textBoxAddressFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContactPersonFilter;
        private System.Windows.Forms.TextBox textBoxPhoneFilter;
        private System.Windows.Forms.Button buttonSupplierSearch;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxSupplierNameFilter;
    }
}