using eda_fundamentals.Order.Domain.Repositories;

namespace eda_fundamentals.Order.Infra.Repositories
{
    public class FakeOrderRepository : IOrderRepository
    {
        private List<Domain.Entities.Order> _orders = new List<Domain.Entities.Order>();

        public async Task CreateAsync(Domain.Entities.Order entity)
        {   
            _orders.Add(entity);
        }

        public async Task DeleteAsync(Domain.Entities.Order entity)
        {
            _orders.Remove(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = _orders.FirstOrDefault(x => x.Id == id);
            if (user != null)
                await DeleteAsync(user);
        }

        public async Task<Domain.Entities.Order?> GetByIdAsync(Guid id)
        {
            return _orders.FirstOrDefault(x => x.Id == id);
        }
    }
}
