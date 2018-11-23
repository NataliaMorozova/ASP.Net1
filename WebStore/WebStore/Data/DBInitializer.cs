using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStoreDomain.Entites.Base;

namespace WebStore.Data
{
    public static class DBInitializer
    {
        public static void Initialize(WebStoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var sections = new List<Section>()
            {
                new Section()
                {
                    id = 1,
                    Name = "Sportswear",
                    Order = 0,
                    ParentId = null
                },
                new Section()
                {
                    id = 2,
                    Name = "Nike",
                    Order = 0,
                    ParentId = 1
                },
                new Section()
                {
                    id = 3,
                    Name = "Under Armour",
                    Order = 1,
                    ParentId = 1
                },
                new Section()
                {
                    id = 4,
                    Name = "Adidas",
                    Order = 2,
                    ParentId = 1
                },
                new Section()
                {
                    id = 5,
                    Name = "Puma",
                    Order = 3,
                    ParentId = 1
                },
                new Section()
                {
                    id = 6,
                    Name = "ASICS",
                    Order = 4,
                    ParentId = 1
                },
                new Section()
                {
                    id = 7,
                    Name = "Mens",
                    Order = 1,
                    ParentId = null
                },
                new Section()
                {
                    id = 8,
                    Name = "Fendi",
                    Order = 0,
                    ParentId = 7
                },
                new Section()
                {
                    id = 9,
                    Name = "Guess",
                    Order = 1,
                    ParentId = 7
                },
                new Section()
                {
                    id = 10,
                    Name = "Valentino",
                    Order = 2,
                    ParentId = 7
                },
                new Section()
                {
                    id = 11,
                    Name = "Dior",
                    Order = 3,
                    ParentId = 7
                },
                new Section()
                {
                    id = 12,
                    Name = "Versace",
                    Order = 4,
                    ParentId = 7
                },
                new Section()
                {
                    id = 13,
                    Name = "Armani",
                    Order = 5,
                    ParentId = 7
                },
                new Section()
                {
                    id = 14,
                    Name = "Prada",
                    Order = 6,
                    ParentId = 7
                },
                new Section()
                {
                    id = 15,
                    Name = "Dolce and Gabbana",
                    Order = 7,
                    ParentId = 7
                },
                new Section()
                {
                    id = 16,
                    Name = "Chanel",
                    Order = 8,
                    ParentId = 7
                },
                new Section()
                {
                    id = 17,
                    Name = "Gucci",
                    Order = 1,
                    ParentId = 7
                },
                new Section()
                {
                    id = 18,
                    Name = "Womens",
                    Order = 2,
                    ParentId = null
                },
                new Section()
                {
                    id = 19,
                    Name = "Fendi",
                    Order = 0,
                    ParentId = 18
                },
                new Section()
                {
                    id = 20,
                    Name = "Guess",
                    Order = 1,
                    ParentId = 18
                },
                new Section()
                {
                    id = 21,
                    Name = "Valentino",
                    Order = 2,
                    ParentId = 18
                },
                new Section()
                {
                    id = 22,
                    Name = "Dior",
                    Order = 3,
                    ParentId = 18
                },
                new Section()
                {
                    id = 23,
                    Name = "Versace",
                    Order = 4,
                    ParentId = 18
                },
                new Section()
                {
                    id = 24,
                    Name = "Kids",
                    Order = 3,
                    ParentId = null
                },
                new Section()
                {
                    id = 25,
                    Name = "Fashion",
                    Order = 4,
                    ParentId = null
                },
                new Section()
                {
                    id = 26,
                    Name = "Households",
                    Order = 5,
                    ParentId = null
                },
                new Section()
                {
                    id = 27,
                    Name = "Interiors",
                    Order = 6,
                    ParentId = null
                },
                new Section()
                {
                    id = 28,
                    Name = "Clothing",
                    Order = 7,
                    ParentId = null
                },
                new Section()
                {
                    id = 29,
                    Name = "Bags",
                    Order = 8,
                    ParentId = null
                },
                new Section()
                {
                    id = 30,
                    Name = "Shoes",
                    Order = 9,
                    ParentId = null
                }
            };
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var section in sections)
                {
                    context.Sections.Add(section);
                }

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Sections] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Sections] OFF");
                trans.Commit();
            }
            var brands = new List<Brand>()
            {
                new Brand()
                {
                    id = 1,
                    Name = "Acne",
                    Order = 0
                },
                new Brand()
                {
                    id = 2,
                    Name = "Grüne Erde",
                    Order = 1
                },
                new Brand()
                {
                    id = 3,
                    Name = "Albiro",
                    Order = 2
                },
                new Brand()
                {
                    id = 4,
                    Name = "Ronhill",
                    Order = 3
                },
                new Brand()
                {
                    id = 5,
                    Name = "Oddmolly",
                    Order = 4
                },
                new Brand()
                {
                    id = 6,
                    Name = "Boudestijn",
                    Order = 5
                },
                new Brand()
                {
                    id = 7,
                    Name = "Rösch creative culture",
                    Order = 6
                }
            };
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var brand in brands)
                {
                    context.Brands.Add(brand);
                }

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Brands] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Brands] OFF");
                trans.Commit();
            }
            var products = new List<Product>()
            {
                new Product()
                {
                    id = 1,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product1.jpg",
                    Order = 0,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    id = 2,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product2.jpg",
                    Order = 1,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    id = 3,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product3.jpg",
                    Order = 2,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    id = 4,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product4.jpg",
                    Order = 3,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    id = 5,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product5.jpg",
                    Order = 4,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    id = 6,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product6.jpg",
                    Order = 5,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    id = 7,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product7.jpg",
                    Order = 6,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    id = 8,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product8.jpg",
                    Order = 7,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    id = 9,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product9.jpg",
                    Order = 8,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    id = 10,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product10.jpg",
                    Order = 9,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    id = 11,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product11.jpg",
                    Order = 10,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    id = 12,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product12.jpg",
                    Order = 11,
                    SectionId = 25,
                    BrandId = 3
                }
            };
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var product in products)
                {
                    context.Products.Add(product);
                }
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Products] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Products] OFF");
                trans.Commit();
            }

        }
    }
}
