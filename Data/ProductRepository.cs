using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;

namespace aspnetcoregraphql.Data
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository() {
            _products = new List<Product>{
                new Product{
                    Id = 1,
                    CategoryId = 1,
                    Name = "Product 1",
                    Description = "Pro 1",
                    Price = 5000
                },
                new Product{
                    Id = 2,
                    CategoryId = 1,
                    Name = "Product 2",
                    Description = "Pro 2",
                    Price = 2000
                },
                new Product {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Product 3",
                    Description = "Pro 3",
                    Price = 4000
                }
            };
        }
        public Task<Product> GetProductAsync(int id)
        {
            return Task.FromResult(_products.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(_products);
        }

        public Task<List<Product>> GetProductWithByCategoryIdAsync(int categoryId)
        {
            return Task.FromResult(_products.Where(x => x.CategoryId == categoryId).ToList());
        }
    }
}