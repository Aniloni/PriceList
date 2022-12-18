
namespace LP
{
    partial class NewPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPosition));
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new LP.DatabaseDataSet();
            this.pricelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricelistTableAdapter = new LP.DatabaseDataSetTableAdapters.PricelistTableAdapter();
            this.типМебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаВРозницуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаОптомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(466, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Введите данные о новой позиции";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonExit2
            // 
            this.buttonExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.buttonExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit2.FlatAppearance.BorderSize = 0;
            this.buttonExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit2.ForeColor = System.Drawing.Color.Azure;
            this.buttonExit2.Location = new System.Drawing.Point(1267, 135);
            this.buttonExit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(135, 46);
            this.buttonExit2.TabIndex = 15;
            this.buttonExit2.Text = "Выход";
            this.buttonExit2.UseVisualStyleBackColor = false;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(63, 135);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(728, 74);
            this.panel8.TabIndex = 19;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Azure;
            this.buttonBack.Location = new System.Drawing.Point(1267, 634);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(135, 46);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 697);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1469, 158);
            this.panel9.TabIndex = 26;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1469, 74);
            this.panel10.TabIndex = 27;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(75, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pricelistBindingSource
            // 
            this.pricelistBindingSource.DataMember = "Pricelist";
            this.pricelistBindingSource.DataSource = this.databaseDataSet;
            // 
            // pricelistTableAdapter
            // 
            this.pricelistTableAdapter.ClearBeforeFill = true;
            // 
            // типМебелиDataGridViewTextBoxColumn
            // 
            this.типМебелиDataGridViewTextBoxColumn.DataPropertyName = "Тип мебели";
            this.типМебелиDataGridViewTextBoxColumn.HeaderText = "Тип мебели";
            this.типМебелиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типМебелиDataGridViewTextBoxColumn.Name = "типМебелиDataGridViewTextBoxColumn";
            this.типМебелиDataGridViewTextBoxColumn.Width = 125;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            this.артикулDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // наличиеDataGridViewTextBoxColumn
            // 
            this.наличиеDataGridViewTextBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewTextBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наличиеDataGridViewTextBoxColumn.Name = "наличиеDataGridViewTextBoxColumn";
            this.наличиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаВРозницуDataGridViewTextBoxColumn
            // 
            this.ценаВРозницуDataGridViewTextBoxColumn.DataPropertyName = "Цена в розницу";
            this.ценаВРозницуDataGridViewTextBoxColumn.HeaderText = "Цена в розницу";
            this.ценаВРозницуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаВРозницуDataGridViewTextBoxColumn.Name = "ценаВРозницуDataGridViewTextBoxColumn";
            this.ценаВРозницуDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаОптомDataGridViewTextBoxColumn
            // 
            this.ценаОптомDataGridViewTextBoxColumn.DataPropertyName = "Цена оптом";
            this.ценаОптомDataGridViewTextBoxColumn.HeaderText = "Цена оптом";
            this.ценаОптомDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаОптомDataGridViewTextBoxColumn.Name = "ценаОптомDataGridViewTextBoxColumn";
            this.ценаОптомDataGridViewTextBoxColumn.Width = 125;
            // 
            // NewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(161)))), ((int)(((byte)(201)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1469, 855);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit2);
            this.Controls.Add(this.panel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewPosition";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.NewPosition_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
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