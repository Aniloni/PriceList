﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPosition));
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.TextBox();
            this.Articule = new System.Windows.Forms.TextBox();
            this.Nalichie = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.PriceO = new System.Windows.Forms.TextBox();
            this.NameP = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit2
            // 
            this.buttonExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.buttonExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit2.FlatAppearance.BorderSize = 0;
            this.buttonExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit2.Font = new System.Drawing.Font("Dubai", 10F);
            this.buttonExit2.ForeColor = System.Drawing.Color.Azure;
            this.buttonExit2.Location = new System.Drawing.Point(943, 78);
            this.buttonExit2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(136, 31);
            this.buttonExit2.TabIndex = 15;
            this.buttonExit2.Text = "Выход";
            this.buttonExit2.UseVisualStyleBackColor = false;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Dubai", 10F);
            this.buttonBack.ForeColor = System.Drawing.Color.Azure;
            this.buttonBack.Location = new System.Drawing.Point(502, 487);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(136, 31);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1106, 61);
            this.panel10.TabIndex = 27;
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.Type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Type.ForeColor = System.Drawing.Color.Azure;
            this.Type.Location = new System.Drawing.Point(0, 9);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(397, 24);
            this.Type.TabIndex = 28;
            this.Type.Text = "Тип мебели";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.TextChanged += new System.EventHandler(this.Type_TextChanged);
            this.Type.Enter += new System.EventHandler(this.Type_Enter);
            this.Type.Leave += new System.EventHandler(this.Type_Leave);
            // 
            // Articule
            // 
            this.Articule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.Articule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Articule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Articule.ForeColor = System.Drawing.Color.Azure;
            this.Articule.Location = new System.Drawing.Point(0, 7);
            this.Articule.Name = "Articule";
            this.Articule.Size = new System.Drawing.Size(397, 24);
            this.Articule.TabIndex = 29;
            this.Articule.Text = "Артикул";
            this.Articule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Articule.TextChanged += new System.EventHandler(this.Articule_TextChanged);
            this.Articule.Enter += new System.EventHandler(this.Articule_Enter);
            this.Articule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Articule_KeyPress);
            this.Articule.Leave += new System.EventHandler(this.Articule_Leave);
            // 
            // Nalichie
            // 
            this.Nalichie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.Nalichie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nalichie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Nalichie.ForeColor = System.Drawing.Color.Azure;
            this.Nalichie.Location = new System.Drawing.Point(0, 12);
            this.Nalichie.Name = "Nalichie";
            this.Nalichie.Size = new System.Drawing.Size(397, 24);
            this.Nalichie.TabIndex = 31;
            this.Nalichie.Text = "Количество позиций";
            this.Nalichie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nalichie.TextChanged += new System.EventHandler(this.Nalichie_TextChanged);
            this.Nalichie.Enter += new System.EventHandler(this.Nalichie_Enter);
            this.Nalichie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nalichie_KeyPress);
            this.Nalichie.Leave += new System.EventHandler(this.Nalichie_Leave);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Price.ForeColor = System.Drawing.Color.Azure;
            this.Price.Location = new System.Drawing.Point(0, 12);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(397, 24);
            this.Price.TabIndex = 32;
            this.Price.Text = "Цена в розницу";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Enter += new System.EventHandler(this.Price_Enter);
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            this.Price.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // PriceO
            // 
            this.PriceO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.PriceO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.PriceO.ForeColor = System.Drawing.Color.Azure;
            this.PriceO.Location = new System.Drawing.Point(0, 12);
            this.PriceO.Name = "PriceO";
            this.PriceO.Size = new System.Drawing.Size(397, 24);
            this.PriceO.TabIndex = 33;
            this.PriceO.Text = "Цена оптом";
            this.PriceO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceO.Enter += new System.EventHandler(this.PriceO_Enter);
            this.PriceO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceO_KeyPress);
            this.PriceO.Leave += new System.EventHandler(this.PriceO_Leave);
            // 
            // NameP
            // 
            this.NameP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.NameP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameP.ForeColor = System.Drawing.Color.Azure;
            this.NameP.Location = new System.Drawing.Point(373, 251);
            this.NameP.Name = "NameP";
            this.NameP.Size = new System.Drawing.Size(397, 24);
            this.NameP.TabIndex = 34;
            this.NameP.Text = "Название";
            this.NameP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameP.Enter += new System.EventHandler(this.NameP_Enter);
            this.NameP.Leave += new System.EventHandler(this.NameP_Leave);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Dubai", 10F);
            this.Add.ForeColor = System.Drawing.Color.Azure;
            this.Add.Location = new System.Drawing.Point(502, 451);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(136, 31);
            this.Add.TabIndex = 35;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 144);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.Type);
            this.panel2.Location = new System.Drawing.Point(373, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 44);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.panel3.Controls.Add(this.Articule);
            this.panel3.Location = new System.Drawing.Point(373, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 44);
            this.panel3.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.panel4.Location = new System.Drawing.Point(373, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 44);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.panel5.Controls.Add(this.Nalichie);
            this.panel5.Location = new System.Drawing.Point(373, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 44);
            this.panel5.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.panel6.Controls.Add(this.Price);
            this.panel6.Location = new System.Drawing.Point(373, 341);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 44);
            this.panel6.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
            this.panel7.Controls.Add(this.PriceO);
            this.panel7.Location = new System.Drawing.Point(373, 391);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 44);
            this.panel7.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(347, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 38);
            this.label1.TabIndex = 40;
            this.label1.Text = "Введите данные о позиции";
            // 
            // NewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(249)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameP);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewPosition";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.NewPosition_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Articule;
        private System.Windows.Forms.TextBox Nalichie;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox PriceO;
        private System.Windows.Forms.TextBox NameP;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}