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
using System.Windows.Shapes;

namespace PuppyCafeApp
{
    /// <summary>
    /// Interaction logic for ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        public ProductsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PuppyCafeApp.DatabaseDataSet databaseDataSet = ((PuppyCafeApp.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Load data into the table products. You can modify this code as needed.
            PuppyCafeApp.DatabaseDataSetTableAdapters.productsTableAdapter databaseDataSetproductsTableAdapter = new PuppyCafeApp.DatabaseDataSetTableAdapters.productsTableAdapter();
            databaseDataSetproductsTableAdapter.Fill(databaseDataSet.products);
            System.Windows.Data.CollectionViewSource productsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productsViewSource")));
            productsViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
