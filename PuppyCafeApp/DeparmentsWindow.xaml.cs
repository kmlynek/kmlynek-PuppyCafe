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
    /// Interaction logic for DeparmentsWindow.xaml
    /// </summary>
    public partial class DeparmentsWindow : Window
    {
        public DeparmentsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PuppyCafeApp.DatabaseDataSet databaseDataSet = ((PuppyCafeApp.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Load data into the table departments. You can modify this code as needed.
            PuppyCafeApp.DatabaseDataSetTableAdapters.departmentsTableAdapter databaseDataSetdepartmentsTableAdapter = new PuppyCafeApp.DatabaseDataSetTableAdapters.departmentsTableAdapter();
            databaseDataSetdepartmentsTableAdapter.Fill(databaseDataSet.departments);
            System.Windows.Data.CollectionViewSource departmentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("departmentsViewSource")));
            departmentsViewSource.View.MoveCurrentToFirst();
        }

        private void ButtonRead_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
