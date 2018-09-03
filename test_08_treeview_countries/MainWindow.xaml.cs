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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(treeView1);
            //var mainViewModel = DataContext as MainViewModel;

            //Country newCountry = new Country();
            //newCountry.NAME = "SOLO";

            //mainViewModel.Countries.Add(newCountry);
        }
    }
}
