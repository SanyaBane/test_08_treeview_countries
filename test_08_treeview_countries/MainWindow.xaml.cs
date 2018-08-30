using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using test_08_treeview_countries.Database;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        //private void treeView1_Expanded(object sender, RoutedEventArgs e)
        //{
        //    Console.WriteLine("treeView1_Expanded");

        //    TreeViewItem item = e.OriginalSource as TreeViewItem;
        //    if (item == null)
        //        return;

        //    var context = item.DataContext;

        //    if(context is Country)
        //    {
        //        Country country = context as Country;

        //        if(country.CITIES.Count == 1)
        //        {
        //            City ct = country.CITIES[0];

        //            if(ct.ID == 0)
        //            {
        //                country.CITIES.Clear();
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }

        //        //country.CITIES = SelectAllCitiesByCountryID(country.ID);

        //    }
        //    else if (context is City)
        //    {
        //        City city = context as City;


        //    }

        //}
    }
}
