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
    /// Interaction logic for PetsWindow.xaml
    /// </summary>
    public partial class PetsWindow : Window
    {
        DatabaseEntities petsContext = new DatabaseEntities();
        CollectionViewSource petView;

        public PetsWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PuppyCafeApp.DatabaseDataSet databaseDataSet = ((PuppyCafeApp.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Load data into the table pets. You can modify this code as needed.
            PuppyCafeApp.DatabaseDataSetTableAdapters.petsTableAdapter databaseDataSetpetsTableAdapter = new PuppyCafeApp.DatabaseDataSetTableAdapters.petsTableAdapter();
            databaseDataSetpetsTableAdapter.Fill(databaseDataSet.pets);
            System.Windows.Data.CollectionViewSource petsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("petsViewSource")));
            petsViewSource.View.MoveCurrentToFirst();
        }

        private void ButtonRead_Click(object sender, RoutedEventArgs e)
        {
            //petView = ((CollectionViewSource)(FindResource("petView")));
            //DataContext = this;
            //petsContext.pets.Load();
            //petView.Source = petsContext.pets.Local;
        }
    }
}
