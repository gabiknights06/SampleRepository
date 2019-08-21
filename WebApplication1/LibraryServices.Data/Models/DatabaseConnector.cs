using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryServices.Data.Models
{
    public class DatabaseConnector
    {
        public DatabaseConnector()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=Niconang17;database=dbcity");
        public MySqlCommand query_cmd;
        public MySqlDataReader query_fetch;
    }
}
