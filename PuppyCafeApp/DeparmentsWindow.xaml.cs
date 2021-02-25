using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for DeparmentsWindow.xaml
    /// </summary>
    public partial class DeparmentsWindow : Window
    {
        DatabaseEntities deparmentsContext = new DatabaseEntities();
        CollectionViewSource deparmentView;


        public DeparmentsWindow()
        {
            InitializeComponent();
            deparmentView = ((CollectionViewSource)(FindResource("departmentsViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            deparmentsContext.departments.Load();
            deparmentView.Source = deparmentsContext.departments.Local;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                departments createDeparment = new departments();

                createDeparment.department_name = department_nameTextBox.Text;
                createDeparment.employee_id = int.Parse(employee_idTextBox.Text);

                deparmentsContext.departments.Add(createDeparment);
                deparmentsContext.SaveChanges();
                deparmentView.View.Refresh();
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
                var selectedItem = deparmentView.View.CurrentItem as departments;

                var selectedItemDelete = (from c in deparmentsContext.departments
                                          where c.departmen_id == selectedItem.departmen_id
                                          select c).FirstOrDefault();

                deparmentsContext.departments.Remove(selectedItemDelete);
                deparmentsContext.SaveChanges();
                deparmentView.View.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Check data or select item", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            deparmentView.View.Refresh();
        }
    }
}
