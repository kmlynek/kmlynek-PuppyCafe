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
    /// Interaction logic for EmployeesWindow.xaml
    /// </summary>
    public partial class EmployeesWindow : Window
    {

        DatabaseEntities employeesContext = new DatabaseEntities();
        CollectionViewSource employeesView;


        public EmployeesWindow()
        {
            InitializeComponent();
            employeesView = ((CollectionViewSource)(FindResource("employeesViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employeesContext.employees.Load();
            employeesView.Source = employeesContext.employees.Local;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                employees createEmployee = new employees();

                createEmployee.name = nameTextBox.Text;
                createEmployee.surname = surnameTextBox.Text;
                createEmployee.pesel = peselTextBox.Text;

                employeesContext.employees.Add(createEmployee);
                employeesContext.SaveChanges();
                employeesView.View.Refresh();
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
                var selectedItem = employeesView.View.CurrentItem as employees;

                var selectedItemDelete = (from c in employeesContext.employees
                                          where c.employee_id == selectedItem.employee_id
                                          select c).FirstOrDefault();

                employeesContext.employees.Remove(selectedItemDelete);
                employeesContext.SaveChanges();
                employeesView.View.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Check data or select item", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employeesView.View.Refresh();
        }
    }
}
