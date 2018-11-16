using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreDomain.Entites.Base
{
    public class Section : OrderedEntity
    {
        public int? ParentId { get; set; }
    }
}
