﻿namespace Shop
{
    partial class SupplyFormAdd
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
            this.comboBoxSupplierCode = new System.Windows.Forms.ComboBox();
            this.comboBoxProductCode = new System.Windows.Forms.ComboBox();
            this.buttonAddSupply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSupplierCode
            // 
            this.comboBoxSupplierCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplierCode.FormattingEnabled = true;
            this.comboBoxSupplierCode.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSupplierCode.Name = "comboBoxSupplierCode";
            this.comboBoxSupplierCode.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSupplierCode.TabIndex = 0;
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.Location = new System.Drawing.Point(12, 39);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.Size = new System.Drawing.Size(169, 21);
            this.comboBoxProductCode.TabIndex = 1;
            // 
            // buttonAddSupply
            // 
            this.buttonAddSupply.Location = new System.Drawing.Point(12, 66);
            this.buttonAddSupply.Name = "buttonAddSupply";
            this.buttonAddSupply.Size = new System.Drawing.Size(169, 23);
            this.buttonAddSupply.TabIndex = 2;
            this.buttonAddSupply.Text = "Добавить";
            this.buttonAddSupply.UseVisualStyleBackColor = true;
            this.buttonAddSupply.Click += new System.EventHandler(this.buttonAddSupply_Click);
            // 
            // SupplyFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 100);
            this.Controls.Add(this.buttonAddSupply);
            this.Controls.Add(this.comboBoxProductCode);
            this.Controls.Add(this.comboBoxSupplierCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SupplyFormAdd";
            this.Text = "Добавление";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupplierCode;
        private System.Windows.Forms.ComboBox comboBoxProductCode;
        private System.Windows.Forms.Button buttonAddSupply;
    }
}