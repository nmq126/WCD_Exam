namespace ExamWCD.Migrations
{
    using ExamWCD.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamWCD.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExamWCD.Data.Context context)
        {
            var products = new List<Product>
            {
                new Product { ProductName = "Vans slipon checkerboard",   SupplierId = 1, CategoryId=1, QuantityPerUnit=1, UnitPrice=900000, UnitslnStock=100,UnitsOnOrder=20, ReorderLevel=1,Discontinued=1  },
                new Product { ProductName = "Regular Tshirt", SupplierId =5, CategoryId=2 , QuantityPerUnit=1, UnitPrice=250000, UnitslnStock=200,UnitsOnOrder=100, ReorderLevel=2,Discontinued=1},
                new Product { ProductName = "Sweatpant",   SupplierId = 5, CategoryId=3 , QuantityPerUnit=1, UnitPrice=300000, UnitslnStock=50,UnitsOnOrder=10, ReorderLevel=1,Discontinued=1},
                new Product { ProductName = "Gucci Ring",    SupplierId = 2, CategoryId=4, QuantityPerUnit=1, UnitPrice=20000000, UnitslnStock=5,UnitsOnOrder=3, ReorderLevel=1,Discontinued=0},
            };
            products.ForEach(s => context.Products.AddOrUpdate(s));

            var categories = new List<Category>
            {
                new Category { CategoryName = "Shoes", Description="Giay", Picture="Anh_1" },
                new Category { CategoryName = "Top", Description="Ao", Picture="Anh_2"},
                new Category { CategoryName = "Bottom", Description="Quan", Picture="Anh_3"},
                new Category { CategoryName = "Accessories", Description="Phu kien", Picture="Anh_4"},
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
