using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_JSON_Serialization
{
    public class Game
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string ReleaseDate { get; set; }
        public string Summary { get; set; }
        public double MetaScore { get; set; }
        public string UserReview { get; set; }

        public Game()
        {
            Name = string.Empty;
            Platform = string.Empty;   
            ReleaseDate = string.Empty;
            Summary = string.Empty;
            MetaScore = 0;
            UserReview = string.Empty;
        }

        public override string ToString()
        {
            return $"{Name} - {Platform}";
        }
    }
}
