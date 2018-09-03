using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries
{
    [ValueConversion(typeof(StreetType), typeof(string))]
    class StreetTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, 
            CultureInfo culture)
        {
            StreetType streetType = (StreetType)value;

            return streetType.NAME;
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, 
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
