using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class FurtitureType : Form
    {
        public FurtitureType()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Pricelist". При необходимости она может быть перемещена или удалена.
            //this.pricelistTableAdapter.Fill(this.databaseDataSet.Pricelist);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Pricelist". При необходимости она может быть перемещена или удалена.
            //this.pricelistTableAdapter.Fill(this.databaseDataSet.Pricelist);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Pricelist". При необходимости она может быть перемещена или удалена.
            //this.pricelistTableAdapter.Fill(this.databaseDataSet.Pricelist);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPosition f = new NewPosition();
            f.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
