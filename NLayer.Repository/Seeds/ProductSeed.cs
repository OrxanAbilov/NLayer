using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Samsung Galaxy A32", Price = 560, Stock = 30 },
                new Product { Id = 2, CategoryId = 1, Name = "Honor X9", Price = 600, Stock = 20 },
                new Product { Id = 3, CategoryId = 2, Name = "IPad", Price = 900, Stock = 10 },
                new Product { Id = 4, CategoryId = 2, Name = "Samsung Tab", Price = 400, Stock = 20 },
                new Product { Id = 5, CategoryId = 3, Name = "Hp Pavilion 15", Price = 750, Stock = 10 },
                new Product { Id = 5, CategoryId = 3, Name = "Lenovo ThinkPad", Price = 1500, Stock = 10 }
                );
        }
    }
}
