using eda_fundamentals.Order.Domain.Entities;
using eda_fundamentals.Order.Domain.Repositories;

namespace eda_fundamentals.Order.Infra.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products = Enumerable.Range(1, 10).Select(x => new Product($"Produto {x}", x * 50.10M)).ToList();

        public async Task CreateAsync(Product entity)
        {
            await Task.FromResult(true);
        }

        public async Task DeleteAsync(Product entity)
        {
            await Task.FromResult(true);
        }

        public async Task DeleteAsync(Guid id)
        {
            await Task.FromResult(true);
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            var product = new Product("Produto fake", 10);
            await Task.Run(() => _products.Add(product));
            return product;
        }
    }
}
