using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryServices.Data.Models
{
    class DatabaseConnector
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=Niconang17;database=world");
        public MySqlCommand query_cmd;
        public MySqlDataReader query_fetch;
    }
}
