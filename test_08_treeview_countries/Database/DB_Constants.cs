using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Database
{
    public static class DB_Constants
    {
        static string server = "localhost";
        static string database = "test_08_treeview_countries";
        static string uid = "root";
        static string password = "1113";

        public static string ConnectionString { get; private set; }

        static DB_Constants()
        {
            ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }

    }
}
