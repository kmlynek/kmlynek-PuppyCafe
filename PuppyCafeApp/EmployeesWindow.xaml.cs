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
    /// Interaction logic for EmployeesWindow.xaml
    /// </summary>
    public partial class EmployeesWindow : Window
    {
        public EmployeesWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PuppyCafeApp.DatabaseDataSet databaseDataSet = ((PuppyCafeApp.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Load data into the table employees. You can modify this code as needed.
            PuppyCafeApp.DatabaseDataSetTableAdapters.employeesTableAdapter databaseDataSetemployeesTableAdapter = new PuppyCafeApp.DatabaseDataSetTableAdapters.employeesTableAdapter();
            databaseDataSetemployeesTableAdapter.Fill(databaseDataSet.employees);
            System.Windows.Data.CollectionViewSource employeesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeesViewSource")));
            employeesViewSource.View.MoveCurrentToFirst();
        }
    }
}
