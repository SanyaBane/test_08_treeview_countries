using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace test_08_treeview_countries.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SHORT_NAME { get; set; }
        public ObservableCollection<City> CITIES { get; set; }

        //public ICommand ExpandingCommand { get; set; }

        public Country()
        {
            CITIES = new ObservableCollection<City>();
        }

        public Country(int id, string name, string short_name) : this()
        {
            ID = id;
            NAME = name;
            SHORT_NAME = short_name;
        }

    }
}
