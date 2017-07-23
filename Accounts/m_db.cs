using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Accounts
{
    class m_db
    {
        public static SQLiteConnection Connection = new SQLiteConnection("DataSource=myDataBase.sqlite;");
    }
}
