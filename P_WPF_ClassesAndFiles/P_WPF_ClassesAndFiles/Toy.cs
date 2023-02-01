﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_WPF_ClassesAndFiles
{
    public class Toy
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle;


        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
            Aisle = string.Empty;
        }

        public override string ToString()
        {
            return Manufacturer + " - " + Name;
        }

        public string GetAisle()
        {
            string toyAisle = Manufacturer.ToUpper()[0] + Price.ToString().Replace(".","");

            return toyAisle;
        }
    }
}
