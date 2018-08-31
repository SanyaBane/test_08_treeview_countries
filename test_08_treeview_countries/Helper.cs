using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_08_treeview_countries.Database;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries
{
    class Helper
    {
        private static readonly Helper instance = new Helper();
        static Helper() { }

        private Helper()
        {
            Init();
        }

        public static Helper Instance
        {
            get
            {
                return instance;
            }
        }

        //public List<Street> ListOfStreets;

        private void Init()
        {
            Console.WriteLine("Helper.Init()");

            //int howManyGenerateStreets = 300;
            //ListOfStreets = new List<Street>();

            //for (int i = 0; i < howManyGenerateStreets; i++)
            //{
            //    ListOfStreets.Add(Street.GenerateNewRandomStreet());
            //}
        }
    }
}
