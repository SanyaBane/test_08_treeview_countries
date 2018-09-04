using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries.Database.Mappers
{
    public class StreetTypeMapper : AbstractMapper<StreetType>
    {
        public IList<StreetType> SelectAllStreetTypes()
        {
            string query = "SELECT * FROM street_types";

            MySqlCommand command = new MySqlCommand(query);

            return base.abstractFindMany(command);
        }

        protected override void DoLoad(StreetType obj, IDataReader reader)
        {
            obj.ID = Convert.ToInt32(reader["ID"]);
            obj.NAME = reader["NAME"].ToString();
        }
    }
}
