﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebStoreDomain.Entites;
using WebStoreDomain.Entites.Base;

namespace WebStore.DAL.Context
{
    public class WebStoreContext : IdentityDbContext<User>
    {
        public WebStoreContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Brand> Brands { get; set; }

    }
}
