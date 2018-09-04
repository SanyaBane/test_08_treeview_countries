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

        public MainViewModel()
        {
            Console.WriteLine("MainViewModel()");

            Random rand = new Random();

            // -------------

            Countries = new ObservableCollection<Country>(DB_Countries_Queries.SelectAllCountries());

            foreach (var country in Countries)
            {
                List<City> citiesForCountry = DB_Countries_Queries.SelectAllCitiesByCountryID(country.ID);

                foreach (var city in citiesForCountry)
                {
                    List<Street> streetsForCity = new List<Street>();

                    for (int i = 0; i < 6; i++)
                    {
                        Street genStreet = Street.GenerateNewRandomStreet(rand);
                        streetsForCity.Add(genStreet);

                        List<House> housesForStreet = new List<House>();

                        int jStart = rand.Next(1, 50);
                        int jMaxHouses = jStart + rand.Next(6, 20);
                        for (; jStart <= jMaxHouses; jStart++)
                        {
                            House house = House.GenerateNewHouse("House №" + jStart.ToString());

                            housesForStreet.Add(house);
                        }

                        genStreet.HOUSES = housesForStreet;
                    }

                    city.STREETS = streetsForCity;
                }

                country.CITIES = citiesForCountry;
            }
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
