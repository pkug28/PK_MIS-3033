using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PokeAPI pokedex = new PokeAPI();
        public MainWindow()
        {
            InitializeComponent();

            string json = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1320").Result;

                pokedex = JsonConvert.DeserializeObject<PokeAPI>(json);

                foreach (var pokemon in pokedex.results)
                {
                    if (cboPokemon.Items.Contains(pokemon.name) == false)
                    {
                        cboPokemon.Items.Add(pokemon.name);
                    }

                }
            }
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            string jsonurl;

            using (HttpClient client = new HttpClient())
            {
                jsonurl = client.GetStringAsync($"{cboPokemon.SelectedItem.ToString()}");
            }
        }
    }
}
