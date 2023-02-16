using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }

        public Pokemon()
        {
            name = string.Empty;
            url = string.Empty;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }

    public class Attributes
    {
        public int height { get; set; }
        public Sprite sprites { get; set; }
        public int weight { get; set; }

        public Attributes()
        {
            height = 0;
            sprites = new Sprite();
            weight = 0;
        }

    }

    public class Sprite
    {
        public string back_default { get; set; }
        public string front_default { get; set; }

        public Sprite()
        {
            back_default = string.Empty;
            front_default = string.Empty;
        }
    }
}
