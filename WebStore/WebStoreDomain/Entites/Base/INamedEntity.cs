using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreDomain.Entites.Base
{
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
