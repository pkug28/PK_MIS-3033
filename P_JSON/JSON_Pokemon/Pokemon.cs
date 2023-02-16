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
        public string height { get; set; }
        public Sprite sprites { get; set; }
        public string weight { get; set; }

        public Attributes()
        {
            height = string.Empty;
            sprites = new Sprite();
            weight = string.Empty;
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
