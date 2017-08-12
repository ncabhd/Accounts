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
        //本地数据库
        public static SQLiteConnection Connection = new SQLiteConnection("DataSource=myDataBase.sqlite;");
    }
}
