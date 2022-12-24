using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace LP
{
    public class Connection
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vasil\OneDrive\Desktop\Документы\VS\PriceList\LP\LP\Database.mdf");
        
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
