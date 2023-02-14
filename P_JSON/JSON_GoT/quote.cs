using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_GoT
{
    public class Quote
    {
        public string Sentence { get; set; }
        public Character;

        public House;

        public Quote()
        {
            Sentence = string.Empty;
            Character character = new Character();
            House house = new House()
        }
        

        /*{
  "sentence": "The night is dark and full of terrors.",
  "character": {
    "name": "Melisandre",
    "slug": "melisandre",
    "house": {
      "name": null,
      "slug": null
    }*/
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
