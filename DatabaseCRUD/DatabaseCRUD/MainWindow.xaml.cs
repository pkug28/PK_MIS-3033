using DatabaseCRUD.Models;
using Newtonsoft.Json;
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

namespace DatabaseCRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoonerCoContext db = new SoonerCoContext();
        private bool ShouldLoadToys = true;
        private bool ShouldLoadOwners = true;
        private bool ShouldLoadDogs = true;


        public MainWindow()
        {
            InitializeComponent();
            ShouldLoadToys = true;
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
                        
            LoadToys(ShouldLoadToys);
            LoadOwners(ShouldLoadOwners);
            LoadDogs(ShouldLoadDogs);


        }

        private void LoadToys(bool load)
        {
            if (load == false) return;

            string toyInputJson = File.ReadAllText("Toys.json");
            var toys = JsonConvert.DeserializeObject<List<ToyInput>>(toyInputJson);

            foreach (var toy in toys)
            {
                lstToys.Items.Add(toy);
            }
        }

        private void LoadOwners(bool load)
        {
            if (load == false) return;
        }

        private void LoadDogs(bool load)
        {
            if (load == false) return;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
