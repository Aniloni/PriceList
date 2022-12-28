using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для добавления новой позиции типа "Полка" в прайс-лист
    /// </summary>
    public partial class Shelves : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Shelves() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, запускающийся при загрузке страницы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Shelves_Load(object sender, EventArgs e) 
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist] WHERE [Тип мебели] = N'Полка'", con.connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            con.CloseConnection();

        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e) 
        {
            FurnitureType f = new FurnitureType();
            f.Show();
            this.Hide();
        }
    }
}
