using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_WPF_ClassesAndFiles
{
    public class Toy
    {
        public string Name { get; set; }

        public Toy()
        {
            Name = string.Empty;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
