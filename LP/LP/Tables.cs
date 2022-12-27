using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class Tables : Form // Класс формы для добавления новой позиции типа "Стол" в прайс-лист
    {
        public Tables() //Конструктор класса
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке страницы
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist] WHERE [Тип мебели] = N'Стол'", con.connection);

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
