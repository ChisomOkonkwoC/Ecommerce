using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class CategoryRepository
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string UserFile = "Category.Json";
        public CategoryRepository(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Category>> GetAllCategories()
        {
            return(List<Category>) await _dbContext.ReadJson<Category>(UserFile);
        }
    }
}
