﻿namespace LP
{
    partial class AllPositions
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.типМебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаВРозницуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаОптомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LP.DatabaseDataSet();
            this.pricelistTableAdapter = new LP.DatabaseDataSetTableAdapters.PricelistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типМебелиDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.наличиеDataGridViewTextBoxColumn,
            this.ценаВРозницуDataGridViewTextBoxColumn,
            this.ценаОптомDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pricelistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // типМебелиDataGridViewTextBoxColumn
            // 
            this.типМебелиDataGridViewTextBoxColumn.DataPropertyName = "Тип мебели";
            this.типМебелиDataGridViewTextBoxColumn.HeaderText = "Тип мебели";
            this.типМебелиDataGridViewTextBoxColumn.Name = "типМебелиDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // наличиеDataGridViewTextBoxColumn
            // 
            this.наличиеDataGridViewTextBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewTextBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewTextBoxColumn.Name = "наличиеDataGridViewTextBoxColumn";
            // 
            // ценаВРозницуDataGridViewTextBoxColumn
            // 
            this.ценаВРозницуDataGridViewTextBoxColumn.DataPropertyName = "Цена в розницу";
            this.ценаВРозницуDataGridViewTextBoxColumn.HeaderText = "Цена в розницу";
            this.ценаВРозницуDataGridViewTextBoxColumn.Name = "ценаВРозницуDataGridViewTextBoxColumn";
            // 
            // ценаОптомDataGridViewTextBoxColumn
            // 
            this.ценаОптомDataGridViewTextBoxColumn.DataPropertyName = "Цена оптом";
            this.ценаОптомDataGridViewTextBoxColumn.HeaderText = "Цена оптом";
            this.ценаОптомDataGridViewTextBoxColumn.Name = "ценаОптомDataGridViewTextBoxColumn";
            // 
            // pricelistBindingSource
            // 
            this.pricelistBindingSource.DataMember = "Pricelist";
            this.pricelistBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pricelistTableAdapter
            // 
            this.pricelistTableAdapter.ClearBeforeFill = true;
            // 
            // AllPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllPositions";
            this.Text = "AllPositions";
            this.Load += new System.EventHandler(this.AllPositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pricelistBindingSource;
        private DatabaseDataSetTableAdapters.PricelistTableAdapter pricelistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn типМебелиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаВРозницуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаОптомDataGridViewTextBoxColumn;
    }
}