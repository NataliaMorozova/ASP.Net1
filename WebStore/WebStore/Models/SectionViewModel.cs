using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreDomain.Entites.Base;

namespace WebStore.Models
{
    public class SectionViewModel : OrderedEntity
    {
        public List<SectionViewModel> ChildSections { get; set; }

        public List<SectionViewModel> ParentSection { get; set; }

        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }
    }


}
