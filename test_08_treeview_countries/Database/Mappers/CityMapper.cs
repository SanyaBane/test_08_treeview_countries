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
    public class CityMapper : AbstractMapper<City>
    {
        public IList<City> SelectCitiesByCountryID(int countryID)
        {
            string query = "SELECT * FROM cities WHERE COUNTRY_ID=@country_id";

            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@country_id", countryID);

            return base.abstractFindMany(command);
        }

        protected override void DoLoad(City obj, IDataReader reader)
        {
            obj.ID = Convert.ToInt32(reader["ID"]);
            obj.NAME = reader["NAME"].ToString();
            obj.AMOUNT_OF_PEOPLES = Convert.ToInt32(reader["AMOUNT_OF_PEOPLES"]);
        }
    }
}
