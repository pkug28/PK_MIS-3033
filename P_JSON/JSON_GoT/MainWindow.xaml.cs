using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_GoT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string json = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://api.gameofthronesquotes.xyz/v1/random").Result;                
            }
            

        }

        private void btnQuote_Click(object sender, RoutedEventArgs e)
        {
            string json = string.Empty;
            quotebox.Clear();

            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://api.gameofthronesquotes.xyz/v1/random").Result;
            }

            string quote = JsonConvert.DeserializeObject<string>(json);
            var quotePieces = quote.Split(',');

            Quote gotQuote = new Quote();

            quotePieces[0] = gotQuote.sentence;
            quotebox.Text = gotQuote.sentence;
        }
    }
}
