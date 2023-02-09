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

namespace P_JSON_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> games = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            string[] file = File.ReadAllLines("all_games.csv");
            

            for(int i = 1; i < file.Length; i++)
            {
                var line = file[i];
                var pieces = line.Split(',');
                Game game = new Game();
                game.Name = pieces[0];
                game.Platform = pieces[1];
                game.ReleaseDate = pieces[2];
                game.Summary = pieces[3];
                game.MetaScore = Convert.ToDouble(pieces[4]);
                game.UserReview = pieces[5];
                games.Add(game);
            }

            foreach (var game in games)
            {
                if (cboPlatform.Items.Contains(game.Platform) == false)
                {
                    cboPlatform.Items.Add(game.Platform);
                }

            }
        }
    }
}
