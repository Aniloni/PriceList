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
            this.Articule = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Articule
            // 
            this.Articule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Articule.Location = new System.Drawing.Point(157, 204);
            this.Articule.Name = "Articule";
            this.Articule.Size = new System.Drawing.Size(100, 20);
            this.Articule.TabIndex = 0;
            this.Articule.Text = "Артикул";
            this.Articule.TextChanged += new System.EventHandler(this.Articule_TextChanged);
            this.Articule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Articule_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(632, 199);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // DeletePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Articule);
            this.Name = "DeletePosition";
            this.Text = "DeletePosition";
            this.Load += new System.EventHandler(this.DeletePosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Articule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
    }
}