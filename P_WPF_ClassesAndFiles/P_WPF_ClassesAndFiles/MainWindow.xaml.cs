using System;
using System.Collections.Generic;
using System.IO;
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

namespace P_WPF_ClassesAndFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var toys = File.ReadAllLines("Toys.csv").Skip(1);;

            // Manufacturer (0), Name (1), Price (2), Image (3)
            foreach (var item in toys)
            {
                Toy t = new Toy();
                string[] toyData = item.Split(',');
                t.Manufacturer = toyData[0];
                t.Name = toyData[1];
                t.Price = Convert.ToDouble(toyData[2]);
                t.Image = toyData[3];
                listToys.Items.Add(t);
            }
        }

        private void listToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)listToys.SelectedItem;

            string url = selectedToy.Image;

            var uri = new Uri(url);
            var img = new BitmapImage(uri);
            toyImage.Source = img;

            MessageBox.Show($"Your selected Toy is in Aisle: {selectedToy.GetAisle()}");

        }

        private void manuBox_GotFocus(object sender, RoutedEventArgs e)
        {
            manuBox.Text = "";
        }

        private void nameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            nameBox.Text = "";
        }

        private void priceBox_GotFocus(object sender, RoutedEventArgs e)
        {
            priceBox.Text = "";
        }

        private void imageBox_GotFocus(object sender, RoutedEventArgs e)
        {
            imageBox.Text = "";
        }

        private void newToyButton_Click(object sender, RoutedEventArgs e)
        {
            var newToy = new Toy();

            newToy.Manufacturer = manuBox.Text;
            newToy.Name = nameBox.Text;
            newToy.Price = double.Parse(priceBox.Text);
            newToy.Image = imageBox.Text;

            listToys.Items.Add(newToy);
        }
    }
}
