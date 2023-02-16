using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JSON_GoT
{
    public class Quote
    {
        public string sentence { get; set; }
        public Character character { get; set; }

        public House house { get; set; }

        public Quote()
        {
            sentence = string.Empty;
            Character character = new Character();
        }

        public override string ToString()
        {
            return $"{sentence}";
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        House house = new House();

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    public class House
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }

    
}


