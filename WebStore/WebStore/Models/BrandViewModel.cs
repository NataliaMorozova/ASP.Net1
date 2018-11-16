using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreDomain.Entites.Base;

namespace WebStore.Models
{
    public class BrandViewModel : INamedEntity, IOrderedEntity

    {
        public int id { get; set; }

        public string Name { get; set; }

        public int ProductsCount { get; set; }

        public int Order { get; set; }

    }
}
