namespace LP
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
            this.pricelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LP.DatabaseDataSet();
            this.pricelistTableAdapter = new LP.DatabaseDataSetTableAdapters.PricelistTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pricelistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1816, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1646, 761);
            this.dataGridView1.TabIndex = 2;
            // 
            // pricelistBindingSource1
            // 
            this.pricelistBindingSource1.DataMember = "Pricelist";
            this.pricelistBindingSource1.DataSource = this.databaseDataSet;
            // 
            // AllPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AllPositions";
            this.Text = "AllPositions";
            this.Load += new System.EventHandler(this.AllPositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pricelistBindingSource;
        private DatabaseDataSetTableAdapters.PricelistTableAdapter pricelistTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pricelistBindingSource1;
    }
}