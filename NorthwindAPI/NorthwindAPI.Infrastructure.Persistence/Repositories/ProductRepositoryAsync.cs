using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Application.Interfaces.Repositories;
using NorthwindAPI.Domain.Entities;
using NorthwindAPI.Infrastructure.Persistence.Contexts;
using NorthwindAPI.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Infrastructure.Persistence.Repositories
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Orders>, IProductRepositoryAsync
    {
        private readonly DbSet<Orders> _products;

        public ProductRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<Orders>();
        }

        public Task<bool> IsUniqueBarcodeAsync(string barcode)
        {
            return _products
                .AllAsync(p => p.Barcode != barcode);
        }
    }
}
