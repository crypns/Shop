namespace Shop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelExit = new System.Windows.Forms.LinkLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonSupply = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonLoginHistory = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(138, 34);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(35, 13);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "label1";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(138, 47);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "label2";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Location = new System.Drawing.Point(138, 60);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(35, 13);
            this.labelFullname.TabIndex = 2;
            this.labelFullname.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.AutoSize = true;
            this.labelExit.Location = new System.Drawing.Point(288, 19);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(39, 13);
            this.labelExit.TabIndex = 0;
            this.labelExit.TabStop = true;
            this.labelExit.Text = "Выход";
            this.labelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelExit_LinkClicked);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelExit);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.labelUsername);
            this.groupBox6.Controls.Add(this.labelRole);
            this.groupBox6.Controls.Add(this.labelFullname);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 154);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Данные пользователя";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSales, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonSupply, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSuppliers, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonProduct, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoginHistory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonUsers, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 400);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonSales
            // 
            this.buttonSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSales.Location = new System.Drawing.Point(3, 363);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(333, 34);
            this.buttonSales.TabIndex = 12;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonSupply
            // 
            this.buttonSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSupply.Location = new System.Drawing.Point(3, 323);
            this.buttonSupply.Name = "buttonSupply";
            this.buttonSupply.Size = new System.Drawing.Size(333, 34);
            this.buttonSupply.TabIndex = 11;
            this.buttonSupply.Text = "Поставки";
            this.buttonSupply.UseVisualStyleBackColor = true;
            this.buttonSupply.Click += new System.EventHandler(this.buttonSupply_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSuppliers.Location = new System.Drawing.Point(3, 283);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(333, 34);
            this.buttonSuppliers.TabIndex = 10;
            this.buttonSuppliers.Text = "Поставщики";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProduct.Location = new System.Drawing.Point(3, 243);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(333, 34);
            this.buttonProduct.TabIndex = 9;
            this.buttonProduct.Text = "Товары";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonLoginHistory
            // 
            this.buttonLoginHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoginHistory.Location = new System.Drawing.Point(3, 163);
            this.buttonLoginHistory.Name = "buttonLoginHistory";
            this.buttonLoginHistory.Size = new System.Drawing.Size(333, 34);
            this.buttonLoginHistory.TabIndex = 7;
            this.buttonLoginHistory.Text = "История авторизаций";
            this.buttonLoginHistory.UseVisualStyleBackColor = true;
            this.buttonLoginHistory.Click += new System.EventHandler(this.buttonLoginHistory_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUsers.Location = new System.Drawing.Point(3, 203);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(333, 34);
            this.buttonUsers.TabIndex = 8;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розничная торговля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel labelExit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonLoginHistory;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonSupply;
        private System.Windows.Forms.Button buttonSales;
        public System.Windows.Forms.Label labelRole;
    }
}