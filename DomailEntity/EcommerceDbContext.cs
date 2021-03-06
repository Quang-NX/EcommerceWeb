﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomailEntity.Entities;

namespace DomailEntity
{
    public class EcommerceDbContext :DbContext
    {
        public EcommerceDbContext() : base("EcommerceDbContext")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<EcommerceDbContext>());
           // Database.SetInitializer(new EcommerceDbContextSeed());            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
	}
}
