using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using test_08_treeview_countries.Database;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries
{
    class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Country> Countries { get; set; }
        public ObservableCollection<CountryTreeViewItem> Countries_tvitem { get; set; }

        public ICommand ExpandingCommand { get; set; }

        public MainViewModel()
        {
            Console.WriteLine("MainViewModel()");

            ExpandingCommand = new RelayCommand(ExecuteExpandingCommand, CanExecuteExpandingCommand);

            // -------------

            Countries = new ObservableCollection<Country>(DB_Countries_Queries.SelectAllCountries());
            Countries_tvitem = new ObservableCollection<CountryTreeViewItem>();

            foreach (var country in Countries)
            {   
                CountryTreeViewItem ctvi = new CountryTreeViewItem();

                City newCity = new City();
                newCity.STREETS.Add(new Street());

                country.CITIES.Add(newCity);

                ctvi.Country = country;
                Countries_tvitem.Add(ctvi);
            }

            

            //var newStreet = Street.GenerateNewRandomStreet();
        }

        private void ExecuteExpandingCommand(object obj)
        {
            //    RoutedEventArgs rea = (RoutedEventArgs)obj;
            //    TreeViewItem tvi = (TreeViewItem)rea.OriginalSource;
            //    TreeView tv = (TreeView)tvi.Parent;
            Console.WriteLine("Expanded.");
        }

        private bool CanExecuteExpandingCommand(object obj)
        {
            return true;
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            var handler = System.Threading.Interlocked.CompareExchange(ref PropertyChanged, null, null);
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

    }
}
