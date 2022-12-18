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
    public partial class NewPosition : Form
    {
        public NewPosition()
        {
            InitializeComponent();
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из программы
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FurtitureType back = new FurtitureType();
            back.Show(); //Кнопка назад
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void NewPosition_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Pricelist". При необходимости она может быть перемещена или удалена.
            this.pricelistTableAdapter.Fill(this.databaseDataSet.Pricelist);

        }
    }
}
