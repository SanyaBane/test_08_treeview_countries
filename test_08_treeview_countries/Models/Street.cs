﻿using System;
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

        public int ID { get; set; }
        public string NAME { get; set; }
        public List<House> HOUSES { get; set; }
        public StreetType STREET_TYPE { get; set; }

        public Street(int id, string name, StreetType streetType)
        {
            ID = id;
            NAME = name;
            STREET_TYPE = streetType;
            HOUSES = new List<House>();
        }

        static Street()
        {
            listStreetNames = new List<string>(streetNames.Trim().Split('\n'));
        }

        public static Street GenerateNewRandomStreet()
        {
            List<StreetType> listOfStreetTypes = DBQueries.SelectAllStreetTypes();

            Random rand = new Random();
            string genStreetName = listStreetNames[rand.Next(listStreetNames.Count)];
            StreetType genStreetStreetType = listOfStreetTypes[rand.Next(listOfStreetTypes.Count)];

            Street generatedStreet = new Street(idCounter++, genStreetName, genStreetStreetType);
            return generatedStreet;
        }

        private static List<string> listStreetNames;

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