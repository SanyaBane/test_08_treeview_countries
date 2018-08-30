using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Models
{
    public class City
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int AMOUNT_OF_PEOPLES { get; set; }
        public List<Street> STREETS { get; set; }

        public City() { }

        public City(int id, string name, int amount_of_peoples)
        {
            ID = id;
            NAME = name;
            AMOUNT_OF_PEOPLES = amount_of_peoples;
            STREETS = new List<Street>();
        }
    }
}
