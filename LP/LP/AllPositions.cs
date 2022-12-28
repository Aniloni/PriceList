using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для просмотра всех позиций в прайс-листе
    /// </summary>
    public partial class AllPositions : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public AllPositions() 
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Метод, запускающийся при загрузке формы AllPositions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AllPositions_Load(object sender, EventArgs e) 
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