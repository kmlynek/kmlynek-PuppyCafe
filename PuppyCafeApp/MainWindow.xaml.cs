using System;
using System.Collections.Generic;
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

namespace PuppyCafeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPets_Click(object sender, RoutedEventArgs e)
        {
            PetsWindow petsWindow = new PetsWindow();
            petsWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.Show();
        }

        private void ButtonEmployees_Click(object sender, RoutedEventArgs e)
        {
            EmployeesWindow employeesWindow = new EmployeesWindow();
            employeesWindow.Show();
        }

        private void ButtonDeparments_Click(object sender, RoutedEventArgs e)
        {
            DeparmentsWindow deparmentsWindow = new DeparmentsWindow();
            deparmentsWindow.Show();
        }
    }
}
