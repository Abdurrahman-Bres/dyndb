using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_DB
{
    static class DataUtil
    {


        static public bool Test()
        {
            SqliteConnection s = new SqliteConnection("Data Source = hello.db");
            s.Open();

            return true;
        }
    }
}
