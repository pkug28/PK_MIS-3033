﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCRUD
{
    internal class ToyInput
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string HasSqueeker { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
