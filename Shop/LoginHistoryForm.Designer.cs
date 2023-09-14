namespace Shop
{
    partial class LoginHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginHistoryForm));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewLoginHistory = new System.Windows.Forms.DataGridView();
            this.groupBoxHistoryManag = new System.Windows.Forms.GroupBox();
            this.txtUsernameFilter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginHistory)).BeginInit();
            this.groupBoxHistoryManag.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewLoginHistory, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxHistoryManag, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridViewLoginHistory
            // 
            this.dataGridViewLoginHistory.AllowUserToAddRows = false;
            this.dataGridViewLoginHistory.AllowUserToDeleteRows = false;
            this.dataGridViewLoginHistory.AllowUserToResizeColumns = false;
            this.dataGridViewLoginHistory.AllowUserToResizeRows = false;
            this.dataGridViewLoginHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoginHistory.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLoginHistory.MultiSelect = false;
            this.dataGridViewLoginHistory.Name = "dataGridViewLoginHistory";
            this.dataGridViewLoginHistory.ReadOnly = true;
            this.dataGridViewLoginHistory.Size = new System.Drawing.Size(594, 444);
            this.dataGridViewLoginHistory.TabIndex = 0;
            // 
            // groupBoxHistoryManag
            // 
            this.groupBoxHistoryManag.Controls.Add(this.txtUsernameFilter);
            this.groupBoxHistoryManag.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHistoryManag.Location = new System.Drawing.Point(603, 3);
            this.groupBoxHistoryManag.Name = "groupBoxHistoryManag";
            this.groupBoxHistoryManag.Size = new System.Drawing.Size(194, 47);
            this.groupBoxHistoryManag.TabIndex = 2;
            this.groupBoxHistoryManag.TabStop = false;
            this.groupBoxHistoryManag.Text = "Поиск данных по логину";
            // 
            // txtUsernameFilter
            // 
            this.txtUsernameFilter.Location = new System.Drawing.Point(6, 19);
            this.txtUsernameFilter.Name = "txtUsernameFilter";
            this.txtUsernameFilter.Size = new System.Drawing.Size(181, 20);
            this.txtUsernameFilter.TabIndex = 0;
            this.txtUsernameFilter.TextChanged += new System.EventHandler(this.txtUsernameFilter_TextChanged);
            // 
            // LoginHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginHistoryForm";
            this.Text = "История авторизаций";
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginHistory)).EndInit();
            this.groupBoxHistoryManag.ResumeLayout(false);
            this.groupBoxHistoryManag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridViewLoginHistory;
        private System.Windows.Forms.GroupBox groupBoxHistoryManag;
        private System.Windows.Forms.TextBox txtUsernameFilter;
    }
}