using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            House house = new House();
        }
  }

    public class Character
    {
       public string Name { get; set; }
       public string Slug { get; set; }
    }

    public class House
    {
       public string Name { get; set; }
       public string Slug { get; set; }
    }


}
}
}
