using ECommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
    }
}