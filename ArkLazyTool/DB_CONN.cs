using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace ArkLazyTool;

public class DB_CONN
{
     private SQLiteConnection sqlite;

        public DataClass()
        {
              //This part killed me in the beginning.  I was specifying "DataSource"
              //instead of "Data Source"
              sqlite = new SQLiteConnection("Data Source=/path/to/file.db");

        }
}
