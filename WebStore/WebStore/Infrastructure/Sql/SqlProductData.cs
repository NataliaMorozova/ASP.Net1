using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStore.Infrastructure.Interfaces;
using WebStoreDomain.Entites.Base;

namespace WebStore.Infrastructure.Sql
{
    public class SqlProductData : IProductData
    {
        private readonly WebStoreContext _context;

        public SqlProductData(WebStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

 

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }

        public int GetBrandProductCount(int brandid)
        {
            return _context.Products.Count(c => c.BrandId == brandid);
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.Include("Brand").Include("Section").AsQueryable();
            if (filter.BrandId.HasValue)
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(filter.BrandId.Value));
            if (filter.SectionId.HasValue)
                query = query.Where(c => c.SectionId.Equals(filter.SectionId.Value));
            return query.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("Brand").Include("Section").FirstOrDefault(p => p.id.Equals(id));
        }


    }
}
