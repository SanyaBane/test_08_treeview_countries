using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using test_08_treeview_countries.Database;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries
{
    class MainViewModel : INotifyPropertyChanged
    {
        public List<Country> Countries { get; set; }

        public ICommand ExpandingCommand { get; set; }

        public MainViewModel()
        {
            Console.WriteLine("MainViewModel()");

            ExpandingCommand = new RelayCommand(ExecuteExpandingCommand, CanExecuteExpandingCommand);


            Countries = new List<Country>(DBQueries.SelectAllCountries());

            //Countries.Add(new Country(25, "aeqwwe", "DS"));


            foreach (var country in Countries)
            {
                country.CITIES.Add(new City());
            }

            //var newStreet = Street.GenerateNewRandomStreet();
        }

        private void ExecuteExpandingCommand(object obj)
        {
            Console.WriteLine("Expanded.");
        }

        private bool CanExecuteExpandingCommand(object obj)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            var handler = System.Threading.Interlocked.CompareExchange(ref PropertyChanged, null, null);
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
