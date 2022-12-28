using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для просмотра позиций типа кресло в прайс-листе
    /// </summary>
    public partial class Armchairs : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Armchairs() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, запускающийся при загрузке формы Armchairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Armchairs_Load(object sender, EventArgs e) 
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
