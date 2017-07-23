using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Accounts
{
    class DBOperate
    {
        private static string connString = "Data source=123.206.193.114;Initial Catalog=Accounts;User Id=root;Password=zhumeng0.0";
        public static MySqlConnection connection = new MySqlConnection(connString);
    }
}
