namespace LP
{
    partial class DeletePosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePosition));
            this.Articule = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Articule
            // 
            this.Articule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.Articule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Articule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Articule.ForeColor = System.Drawing.Color.Azure;
            this.Articule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Articule.Location = new System.Drawing.Point(0, 13);
            this.Articule.Name = "Articule";
            this.Articule.Size = new System.Drawing.Size(584, 24);
            this.Articule.TabIndex = 0;
            this.Articule.Text = "Введите артикул удаляемой позиции";
            this.Articule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Articule.Enter += new System.EventHandler(this.Articule_Enter);
            this.Articule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Articule_KeyPress);
            this.Articule.Leave += new System.EventHandler(this.Articule_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 10F);
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(488, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Dubai", 10F);
            this.delete.ForeColor = System.Drawing.Color.Azure;
            this.delete.Location = new System.Drawing.Point(488, 341);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(136, 31);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 211);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 81);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel3.Controls.Add(this.Articule);
            this.panel3.Location = new System.Drawing.Point(274, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 58);
            this.panel3.TabIndex = 35;
            // 
            // buttonExit2
            // 
            this.buttonExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.buttonExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit2.FlatAppearance.BorderSize = 0;
            this.buttonExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit2.Font = new System.Drawing.Font("Dubai", 10F);
            this.buttonExit2.ForeColor = System.Drawing.Color.Azure;
            this.buttonExit2.Location = new System.Drawing.Point(488, 377);
            this.buttonExit2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(136, 31);
            this.buttonExit2.TabIndex = 36;
            this.buttonExit2.Text = "Выход";
            this.buttonExit2.UseVisualStyleBackColor = false;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // DeletePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 695);
            this.Controls.Add(this.buttonExit2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletePosition";
            this.Text = "DeletePosition";
            this.Load += new System.EventHandler(this.DeletePosition_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Articule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit2;
    }
}