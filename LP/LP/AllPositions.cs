using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class AllPositions : Form //Класс формы для просмотра всех позиций в прайс-листе
    {
        public AllPositions() //Конструктор класса
        {
            InitializeComponent();
        }

        private void AllPositions_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке формы AllPositions
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist]", con.connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            con.CloseConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        {
            FurnitureType f = new FurnitureType();
            f.Show();
            this.Hide();
        }
    }
}