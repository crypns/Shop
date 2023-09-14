namespace Shop
{
    partial class SupplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyForm));
            this.buttonEditSupply = new System.Windows.Forms.Button();
            this.AddButtonSupply = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteSupply = new System.Windows.Forms.Button();
            this.dataGridViewSupply = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFilteredRecords = new System.Windows.Forms.Label();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductFilter = new System.Windows.Forms.TextBox();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxSupplierFilter = new System.Windows.Forms.TextBox();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditSupply
            // 
            this.buttonEditSupply.Location = new System.Drawing.Point(5, 50);
            this.buttonEditSupply.Name = "buttonEditSupply";
            this.buttonEditSupply.Size = new System.Drawing.Size(169, 23);
            this.buttonEditSupply.TabIndex = 18;
            this.buttonEditSupply.Text = "Редактировать запись";
            this.buttonEditSupply.UseVisualStyleBackColor = true;
            this.buttonEditSupply.Click += new System.EventHandler(this.buttonEditSupply_Click);
            // 
            // AddButtonSupply
            // 
            this.AddButtonSupply.Location = new System.Drawing.Point(5, 21);
            this.AddButtonSupply.Name = "AddButtonSupply";
            this.AddButtonSupply.Size = new System.Drawing.Size(169, 23);
            this.AddButtonSupply.TabIndex = 19;
            this.AddButtonSupply.Text = "Добавить поставку";
            this.AddButtonSupply.Click += new System.EventHandler(this.AddButtonSupply_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox19.Controls.Add(this.buttonEditSupply);
            this.groupBox19.Controls.Add(this.buttonDeleteSupply);
            this.groupBox19.Controls.Add(this.AddButtonSupply);
            this.groupBox19.Location = new System.Drawing.Point(4, 198);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(184, 112);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Управление данными";
            // 
            // buttonDeleteSupply
            // 
            this.buttonDeleteSupply.Location = new System.Drawing.Point(5, 79);
            this.buttonDeleteSupply.Name = "buttonDeleteSupply";
            this.buttonDeleteSupply.Size = new System.Drawing.Size(169, 23);
            this.buttonDeleteSupply.TabIndex = 17;
            this.buttonDeleteSupply.Text = "Удалить запись";
            this.buttonDeleteSupply.UseVisualStyleBackColor = true;
            this.buttonDeleteSupply.Click += new System.EventHandler(this.buttonDeleteSupply_Click);
            // 
            // dataGridViewSupply
            // 
            this.dataGridViewSupply.AllowUserToAddRows = false;
            this.dataGridViewSupply.AllowUserToDeleteRows = false;
            this.dataGridViewSupply.AllowUserToResizeColumns = false;
            this.dataGridViewSupply.AllowUserToResizeRows = false;
            this.dataGridViewSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSupply.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSupply.MultiSelect = false;
            this.dataGridViewSupply.Name = "dataGridViewSupply";
            this.dataGridViewSupply.ReadOnly = true;
            this.dataGridViewSupply.Size = new System.Drawing.Size(594, 444);
            this.dataGridViewSupply.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.Controls.Add(this.dataGridViewSupply, 0, 0);
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
            this.groupBox18.Controls.Add(this.label1);
            this.groupBox18.Controls.Add(this.textBoxProductFilter);
            this.groupBox18.Controls.Add(this.buttonResetSearch);
            this.groupBox18.Controls.Add(this.buttonProductSearch);
            this.groupBox18.Controls.Add(this.label33);
            this.groupBox18.Controls.Add(this.textBoxSupplierFilter);
            this.groupBox18.Location = new System.Drawing.Point(4, 66);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(184, 126);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Фильтрация данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Товар:";
            // 
            // textBoxProductFilter
            // 
            this.textBoxProductFilter.Location = new System.Drawing.Point(10, 71);
            this.textBoxProductFilter.Name = "textBoxProductFilter";
            this.textBoxProductFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxProductFilter.TabIndex = 28;
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(99, 97);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonResetSearch.TabIndex = 27;
            this.buttonResetSearch.Text = "Сбросить";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(9, 97);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonProductSearch.TabIndex = 11;
            this.buttonProductSearch.Text = "Поиск";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonSupplySearch_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Поставщик:";
            // 
            // textBoxSupplierFilter
            // 
            this.textBoxSupplierFilter.Location = new System.Drawing.Point(10, 32);
            this.textBoxSupplierFilter.Name = "textBoxSupplierFilter";
            this.textBoxSupplierFilter.Size = new System.Drawing.Size(164, 20);
            this.textBoxSupplierFilter.TabIndex = 2;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditSupply;
        private System.Windows.Forms.Button AddButtonSupply;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button buttonDeleteSupply;
        private System.Windows.Forms.DataGridView dataGridViewSupply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFilteredRecords;
        private System.Windows.Forms.Label labelTotalRecords;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxSupplierFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductFilter;
        private System.Windows.Forms.Button buttonResetSearch;
    }
}