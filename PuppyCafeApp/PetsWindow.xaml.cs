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
            petView = ((CollectionViewSource)(FindResource("petsViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            petsContext.pets.Load();
            petView.Source = petsContext.pets.Local;
        }


        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pets createPets = new pets();

                createPets.employee_id = int.Parse(employee_idTextBox.Text);
                createPets.pet_name = pet_nameTextBox.Text;
                createPets.age = int.Parse(ageTextBox.Text);

                petsContext.pets.Add(createPets);
                petsContext.SaveChanges();
                petView.View.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Check data or select item", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            petView.View.Refresh();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = petView.View.CurrentItem as pets;

                var selectedItemDelete = (from c in petsContext.pets
                                          where c.pets_id == selectedItem.pets_id
                                          select c).FirstOrDefault();

                petsContext.pets.Remove(selectedItemDelete);
                petsContext.SaveChanges();
                petView.View.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Check data or select item", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
        }
    }
}
