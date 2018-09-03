using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_08_treeview_countries.Database;

namespace test_08_treeview_countries.Models
{
    public class Street
    {
        private static int idCounter = 1;

        private static List<string> listStreetNames;

        public int ID { get; set; }
        public string NAME { get; set; }
        public StreetType STREET_TYPE { get; set; }
        public List<House> HOUSES { get; set; }

        public Street()
        {
            HOUSES = new List<House>();
        }

        public Street(int id, string name, StreetType streetType) : this()
        {
            ID = id;
            NAME = name;
            STREET_TYPE = streetType;
        }

        static Street()
        {
            listStreetNames = new List<string>(streetNames.Trim().Split('\n'));
        }

        public static Street GenerateNewRandomStreet(Random rand)
        {
            //List<StreetType> listOfStreetTypes = Helper.Instance.ListOfAllStreetTypes;

            string genStreetName = listStreetNames[rand.Next(listStreetNames.Count)].Trim();
            StreetType genStreetStreetType = Helper.Instance.ListOfAllStreetTypes[rand.Next(1, Helper.Instance.ListOfAllStreetTypes.Count)];

            Street generatedStreet = new Street(idCounter++, genStreetName, genStreetStreetType);
            return generatedStreet;
        }

        

        private static string streetNames = @"
Earl
Water
Heirloom
Vista
Wright
Archer
Bay
Cherry
Gold
Cavern
Penrose
Bloomfield
Flint
Coastline
Ironwood
Canal
Wharf
Flint
Crimson
Union
Cherry
Hill
Hawthorn
Clearanc
Berry
Penrose
Beachside
Colonel
Apollo
Royalty
Marble
Circus
Jewel
Flax
Innovation
Archer
Lowland
Vale
Terrace
Seacoast
";

    }
}
