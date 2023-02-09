using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

namespace P_JSON_ParkerKugler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vehicle> carOwners = new List<Vehicle>();
        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("Mock_Data_Car_Owners.json");
                        
            carOwners = JsonConvert.DeserializeObject<List<Vehicle>>(json);

            foreach (var color in carOwners)
            {
                if (cboColors.Items.Contains(color.Color) == false)
                {
                    cboColors.Items.Add(color.Color);
                }
                
            }
        }

        private void resultsBtn_Click(object sender, RoutedEventArgs e)
        {
            resultsList.Items.Clear();            
            
            var selectedColor = cboColors.SelectedItem.ToString();

            for (int i = 0; i < carOwners.Count; i++)
            {
                if (carOwners[i].Color == selectedColor)
                {
                    resultsList.Items.Add(carOwners[i].ToString());
                }
            }


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string dataASJSON = JsonConvert.SerializeObject(resultsList.Items);

            File.WriteAllText($"{cboColors.SelectedItem.ToString()}_Filtered_Car_Owner.json", dataASJSON);

            MessageBox.Show("Saved Successfully!");
        }
    }
}
