using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class Armchairs : Form //Класс формы для просмотра позиций типа кресло в прайс-листе
    {
        public Armchairs() //Конструктор класса
        {
            InitializeComponent();
        }

        private void Armchairs_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке формы Armchairs
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist] WHERE [Тип мебели] = N'Кресло'", con.connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            con.CloseConnection();

        }

        private void button1_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        {   
            FurnitureType f = new FurnitureType();
            f.Show();
            this.Hide();
        }
    }
}
