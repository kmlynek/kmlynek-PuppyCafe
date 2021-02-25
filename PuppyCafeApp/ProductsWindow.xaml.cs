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
using System.Data.Entity;

namespace PuppyCafeApp
{
    /// <summary>
    /// Interaction logic for ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        DatabaseEntities productsContext = new DatabaseEntities();
        CollectionViewSource productsView;

        public ProductsWindow()
        {
            InitializeComponent();
            productsView = ((CollectionViewSource)(FindResource("productsViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            productsContext.products.Load();
            productsView.Source = productsContext.products.Local;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            productsView.View.Refresh();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                products createProduct = new products();

                createProduct.departmen_id = int.Parse(departmen_idTextBox.Text);
                createProduct.product_name = product_nameTextBox.Text;
                createProduct.type_of_product = type_of_productTextBox.Text;

                productsContext.products.Add(createProduct);
                productsContext.SaveChanges();
                productsView.View.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Check data or select item", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = productsView.View.CurrentItem as products;

                var selectedItemDelete = (from c in productsContext.products
                                          where c.products_id == selectedItem.products_id
                                          select c).FirstOrDefault();

                productsContext.products.Remove(selectedItemDelete);
                productsContext.SaveChanges();
                productsView.View.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Check data or select item", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
        }
    }
}
