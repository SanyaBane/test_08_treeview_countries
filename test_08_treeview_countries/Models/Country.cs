using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace test_08_treeview_countries.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SHORT_NAME { get; set; }
        public object FLAG_IMAGE { get; set; }
        public List<City> CITIES { get; set; }
        public BitmapImage bitmapImage { get; set; }

        public Country()
        {
            CITIES = new List<City>();
        }

        public Country(int id, string name, string short_name, object flag_image) : this()
        {
            ID = id;
            NAME = name;
            SHORT_NAME = short_name;
            FLAG_IMAGE = flag_image;

            if (FLAG_IMAGE is DBNull == false)
            {
                byte[] countryFlagImage = (byte[])FLAG_IMAGE;

                bitmapImage = Helper.LoadImage(countryFlagImage);
            }
            
        }

        

    }
}
