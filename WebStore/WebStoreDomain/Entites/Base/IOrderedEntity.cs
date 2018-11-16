using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreDomain.Entites.Base
{
    public interface IOrderedEntity : INamedEntity
    {
        int Order { get; set; }
    }
}
