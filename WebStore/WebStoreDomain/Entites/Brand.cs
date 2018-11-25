using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreDomain.Entites.Base
{
    public class Brand : OrderedEntity
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
