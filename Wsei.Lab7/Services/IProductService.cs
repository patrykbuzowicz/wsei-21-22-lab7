using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab7.Entities;
using Wsei.Lab7.Models;

namespace Wsei.Lab7.Services
{
    public interface IProductService
    {
        Task Add(ProductModel product);

        Task<IEnumerable<ProductEntity>> GetAll(string name);
    }
}
