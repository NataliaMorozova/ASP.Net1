using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreDomain.Entites.Base;


namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter filter);

        int GetBrandProductCount(int brandid);

        Product GetProductById(int id);
    }
}
