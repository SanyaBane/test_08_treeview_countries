using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Models
{
    public class StreetType
    {
        public int ID { get; set; }
        public string NAME { get; set; }

        public StreetType(int id, string name)
        {
            ID = id;
            NAME = name;
        }
    }
}
