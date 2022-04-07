using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class ProductRepository : IProductRepository
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string userFile = "Product.json";
        public ProductRepository(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return (List<Product>)await _dbContext.ReadJson<Product>(userFile);

        }
    }
}
