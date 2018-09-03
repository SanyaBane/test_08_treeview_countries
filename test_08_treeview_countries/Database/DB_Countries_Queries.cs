using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries.Database
{
    class DB_Countries_Queries
    {
        public static List<Country> SelectAllCountries()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT countries.ID, countries.NAME, countries.SHORT_NAME, countries.FLAG_IMAGE FROM countries");

            DataTable result = DBConnect.Instance.Select(cmd);

            if (result == null)
                return null;

            var countriesList = new List<Country>();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                int countryID = Convert.ToInt32(result.Rows[i].ItemArray[0]);
                string countryName = result.Rows[i].ItemArray[1].ToString();
                string countryShortName = result.Rows[i].ItemArray[2].ToString();
                object countryFlagImage = result.Rows[i].ItemArray[3];

                var country = new Country(countryID, countryName, countryShortName, countryFlagImage);
                countriesList.Add(country);
            }

            return countriesList;
        }

        public static List<City> SelectAllCitiesByCountryID(int _countryID)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT cities.ID, cities.NAME, cities.AMOUNT_OF_PEOPLES FROM cities WHERE COUNTRY_ID=@country_id");
            cmd.Parameters.AddWithValue("@country_id", _countryID);

            DataTable result = DBConnect.Instance.Select(cmd);

            if (result == null)
                return null;

            var citiesList = new List<City>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                int cityID = Int32.Parse(result.Rows[i].ItemArray[0].ToString());
                string cityName = result.Rows[i].ItemArray[1].ToString();
                int cityAmountOfPeople = Int32.Parse(result.Rows[i].ItemArray[2].ToString());

                City city = new City(cityID, cityName, cityAmountOfPeople);
                citiesList.Add(city);
            }

            return citiesList;
        }

        public static List<StreetType> SelectAllStreetTypes()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT street_types.ID, street_types.NAME FROM street_types");

            DataTable result = DBConnect.Instance.Select(cmd);

            if (result == null)
                return null;

            var streetTypesList = new List<StreetType>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                int streetTypeID = Int32.Parse(result.Rows[i].ItemArray[0].ToString());
                string streetTypeName = result.Rows[i].ItemArray[1].ToString();

                StreetType streetType = new StreetType(streetTypeID, streetTypeName);
                streetTypesList.Add(streetType);
            }

            return streetTypesList;
        }

        //public static StreetType SelectStreetTypeById(int _streetTypeID)
        //{
        //    MySqlCommand cmd = new MySqlCommand("SELECT street_types.ID, street_types.NAME FROM street_types WHERE street_types.ID = @ID");
        //    cmd.Parameters.AddWithValue("@ID", _streetTypeID);

        //    DataTable result = DBConnect.Instance.Select(cmd);

        //    if (result == null)
        //        return null;

        //    int streetTypeID = Int32.Parse(result.Rows[0].ItemArray[0].ToString());
        //    string streetTypeName = result.Rows[0].ItemArray[1].ToString();

        //    StreetType streetType = new StreetType(streetTypeID, streetTypeName);
        //    return streetType;
        //}
    }
}
