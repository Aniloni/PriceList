using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class Wardrobes : Form // Класс формы для добавления новой позиции типа "Шкаф" в прайс-лист
    {
        public Wardrobes() //Конструктор класса
        {
            InitializeComponent();
        }

        private void Wardrobes_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке страницы
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist] WHERE [Тип мебели] = N'Шкаф'", con.connection);

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
