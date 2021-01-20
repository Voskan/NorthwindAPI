using NorthwindAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync : IGenericRepositoryAsync<Orders>
    {
        Task<bool> IsUniqueBarcodeAsync(string barcode);
    }
}
