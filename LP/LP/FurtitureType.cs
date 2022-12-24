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

        private void button9_Click(object sender, EventArgs e)
        {
            Beds f = new Beds();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Chair f = new Chair();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tables f = new Tables();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wardrobes f = new Wardrobes();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Armchairs f = new Armchairs();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sofas f = new Sofas();
            f.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Shelves f = new Shelves();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AllPositions f = new AllPositions();
            f.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeletePosition f = new DeletePosition();
            f.Show();
            this.Hide();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            ChangePosition f = new ChangePosition();
            f.Show();
            this.Hide();
        }
    }
}