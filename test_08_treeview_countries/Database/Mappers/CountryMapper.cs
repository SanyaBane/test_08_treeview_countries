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
    public class CountryMapper : AbstractMapper<Country>
    {
        public IList<Country> SelectAllCountries()
        {
            string query = "SELECT * FROM countries";

            MySqlCommand command = new MySqlCommand(query);

            return base.abstractFindMany(command);
        }

        protected override void DoLoad(Country obj, IDataReader reader)
        {
            obj.ID = Convert.ToInt32(reader["ID"]);
            obj.NAME = reader["NAME"].ToString();
            obj.SHORT_NAME = reader["SHORT_NAME"].ToString();
            obj.FLAG_IMAGE = reader["FLAG_IMAGE"];

            if(obj.FLAG_IMAGE is DBNull == false)
            {
                obj.BitmapImage = Helper.LoadImage((byte[])obj.FLAG_IMAGE);
            }
            

        }
    }
}
