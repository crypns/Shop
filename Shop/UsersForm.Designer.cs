namespace Shop
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.buttonUserSearch = new System.Windows.Forms.Button();
            this.textBoxFullnameFilter = new System.Windows.Forms.TextBox();
            this.textBoxUsernameFilter = new System.Windows.Forms.TextBox();
            this.textBoxRoleFilter = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.AddButtonUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.Controls.Add(this.dataGridViewUsers, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox17, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(594, 444);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.groupBox19);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(603, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(194, 444);
            this.groupBox17.TabIndex = 2;
            this.groupBox17.TabStop = false;
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.label31);
            this.groupBox18.Controls.Add(this.label32);
            this.groupBox18.Controls.Add(this.label33);
            this.groupBox18.Controls.Add(this.buttonUserSearch);
            this.groupBox18.Controls.Add(this.textBoxFullnameFilter);
            this.groupBox18.Controls.Add(this.textBoxUsernameFilter);
            this.groupBox18.Controls.Add(this.textBoxRoleFilter);
            this.groupBox18.Location = new System.Drawing.Point(4, 8);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(184, 128);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Фильтрация данных";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 74);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "ФИО:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 48);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "Логин:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Роль:";
            // 
            // buttonUserSearch
            // 
            this.buttonUserSearch.Location = new System.Drawing.Point(9, 97);
            this.buttonUserSearch.Name = "buttonUserSearch";
            this.buttonUserSearch.Size = new System.Drawing.Size(169, 23);
            this.buttonUserSearch.TabIndex = 7;
            this.buttonUserSearch.Text = "Поиск";
            this.buttonUserSearch.UseVisualStyleBackColor = true;
            this.buttonUserSearch.Click += new System.EventHandler(this.buttonUserSearch_Click);
            // 
            // textBoxFullnameFilter
            // 
            this.textBoxFullnameFilter.Location = new System.Drawing.Point(72, 71);
            this.textBoxFullnameFilter.Name = "textBoxFullnameFilter";
            this.textBoxFullnameFilter.Size = new System.Drawing.Size(106, 20);
            this.textBoxFullnameFilter.TabIndex = 4;
            // 
            // textBoxUsernameFilter
            // 
            this.textBoxUsernameFilter.Location = new System.Drawing.Point(72, 45);
            this.textBoxUsernameFilter.Name = "textBoxUsernameFilter";
            this.textBoxUsernameFilter.Size = new System.Drawing.Size(106, 20);
            this.textBoxUsernameFilter.TabIndex = 3;
            // 
            // textBoxRoleFilter
            // 
            this.textBoxRoleFilter.Location = new System.Drawing.Point(72, 19);
            this.textBoxRoleFilter.Name = "textBoxRoleFilter";
            this.textBoxRoleFilter.Size = new System.Drawing.Size(106, 20);
            this.textBoxRoleFilter.TabIndex = 2;
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox19.Controls.Add(this.buttonEditUser);
            this.groupBox19.Controls.Add(this.buttonDeleteUser);
            this.groupBox19.Controls.Add(this.AddButtonUser);
            this.groupBox19.Location = new System.Drawing.Point(4, 143);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(184, 299);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Добавление/Редактирование";
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(9, 50);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(169, 23);
            this.buttonEditUser.TabIndex = 18;
            this.buttonEditUser.Text = "Редактировать запись";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(9, 79);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(169, 23);
            this.buttonDeleteUser.TabIndex = 17;
            this.buttonDeleteUser.Text = "Удалить запись";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // AddButtonUser
            // 
            this.AddButtonUser.Location = new System.Drawing.Point(10, 21);
            this.AddButtonUser.Name = "AddButtonUser";
            this.AddButtonUser.Size = new System.Drawing.Size(168, 23);
            this.AddButtonUser.TabIndex = 19;
            this.AddButtonUser.Text = "Добавить пользователя";
            this.AddButtonUser.Click += new System.EventHandler(this.AddButtonUser_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button buttonUserSearch;
        private System.Windows.Forms.TextBox textBoxFullnameFilter;
        private System.Windows.Forms.TextBox textBoxUsernameFilter;
        private System.Windows.Forms.TextBox textBoxRoleFilter;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button AddButtonUser;
    }
}