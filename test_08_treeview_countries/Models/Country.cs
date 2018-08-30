using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SHORT_NAME { get; set; }
        public List<City> CITIES { get; set; }

        public Country() { }

        public Country(int id, string name, string short_name)
        {
            ID = id;
            NAME = name;
            SHORT_NAME = short_name;
            CITIES = new List<City>();
        }
        
    }
}
