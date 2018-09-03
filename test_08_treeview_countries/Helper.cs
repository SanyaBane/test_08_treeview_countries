using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
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

        public List<StreetType> ListOfAllStreetTypes;

        private void Init()
        {
            Console.WriteLine("Helper.Init()");

            ListOfAllStreetTypes = DB_Countries_Queries.SelectAllStreetTypes();
        }

        public static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }


    }
}
