using eda_fundamentals.Order.Domain.Entities;
using eda_fundamentals.Order.Domain.Repositories;

namespace eda_fundamentals.Order.Infra.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products = Enumerable.Range(1, 10).Select(x => new Product($"Produto {x}", x * 50.10M)).ToList();

        public async Task CreateAsync(Product entity)
        {   
            _products.Add(entity);
        }

        public async Task DeleteAsync(Product entity)
        {
            _products.Remove(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = _products.FirstOrDefault(x => x.Id == id);
            if (user != null)
                await DeleteAsync(user);
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }
    }
}
