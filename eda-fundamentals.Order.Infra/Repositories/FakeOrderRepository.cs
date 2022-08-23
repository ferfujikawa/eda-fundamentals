using eda_fundamentals.Order.Domain.Repositories;

namespace eda_fundamentals.Order.Infra.Repositories
{
    public class FakeOrderRepository : IOrderRepository
    {
        private List<Domain.Entities.Order> _orders = new List<Domain.Entities.Order>();

        public async Task CreateAsync(Domain.Entities.Order entity)
        {
            await Task.FromResult(true);
        }

        public async Task DeleteAsync(Domain.Entities.Order entity)
        {
            await Task.FromResult(true);
        }

        public async Task DeleteAsync(Guid id)
        {
            await Task.FromResult(true);
        }

        public async Task<Domain.Entities.Order?> GetByIdAsync(Guid id)
        {
            return await Task.FromResult(_orders.FirstOrDefault(x => x.Id == id));
        }
    }
}
