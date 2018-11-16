using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreDomain.Entites.Base
{
    public class OrderedEntity : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
