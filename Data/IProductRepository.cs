using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;

namespace aspnetcoregraphql.Data
{
    public interface IProductRepository
    {
         Task<List<Product>> GetProductsAsync();
         Task<List<Product>> GetProductWithByCategoryIdAsync(int categoryId);
         Task<Product> GetProductAsync(int id);
    }
}