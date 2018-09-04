using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Database.Mappers
{
    public class MapperSingleton
    {
        private static MapperSingleton _instance;
        public static MapperSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new MapperSingleton());
            }
        }

        private CountryMapper countryMapper;
        public CountryMapper CountryMapper
        {
            get { return countryMapper ?? (countryMapper = new CountryMapper()); }
        }

        private CityMapper cityMapper;
        public CityMapper CityMapper
        {
            get { return cityMapper ?? (cityMapper = new CityMapper()); }
        }

        private HouseMapper houseMapper;
        public HouseMapper HouseMapper
        {
            get { return houseMapper ?? (houseMapper = new HouseMapper()); }
        }

        private StreetMapper streetMapper;
        public StreetMapper StreetMapper
        {
            get { return streetMapper ?? (streetMapper = new StreetMapper()); }
        }

        private StreetTypeMapper streetTypeMapper;
        public StreetTypeMapper StreetTypeMapper
        {
            get { return streetTypeMapper ?? (streetTypeMapper = new StreetTypeMapper()); }
        }



    }
}
