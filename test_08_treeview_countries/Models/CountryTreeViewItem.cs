using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries.Models
{
    public class CountryTreeViewItem : TreeViewItem, INotifyPropertyChanged
    {
        public Country _Country;
        public Country Country
        {
            get
            {
                return _Country;
            }
            set
            {
                _Country = value;
                OnPropertyChanged("Country");
            }
        }

        public CountryTreeViewItem() : base() { }

        public void Rewrite()
        {
            if (Country == null)
            {
                Header = "Country name is null";
                return;
            }

            Header = Country.NAME;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            Console.WriteLine("OnPropertyChanged");
            //Rewrite();

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
