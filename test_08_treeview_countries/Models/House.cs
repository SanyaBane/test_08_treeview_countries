using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Models
{
    public class House
    {
        public int ID { get; set; }
        public string NAME { get; set; }

        public House(int id, string name)
        {
            ID = id;
            NAME = name;
        }
    }
}
