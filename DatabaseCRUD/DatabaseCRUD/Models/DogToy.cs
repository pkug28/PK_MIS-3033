﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatabaseCRUD.Models
{
    public partial class DogToy
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public int ToyId { get; set; }

        public virtual Dog Dog { get; set; }
        public virtual Toy Toy { get; set; }
    }
}