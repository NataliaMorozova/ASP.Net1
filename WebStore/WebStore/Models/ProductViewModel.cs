﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreDomain.Entites.Base;

namespace WebStore.Models
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}