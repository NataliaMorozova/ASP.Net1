using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreDomain.Entites.Base
{
    public class ProductFilter
    {
        public int? SectionId { get; set; }

        public int? BrandId { get; set; }

        public List<int> Ids { get; set; }
    }
}
