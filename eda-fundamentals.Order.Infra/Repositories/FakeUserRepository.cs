using eda_fundamentals.Order.Domain.Entities;
using eda_fundamentals.Order.Domain.Repositories;

namespace eda_fundamentals.Order.Infra.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private List<User> _users = Enumerable.Range(1, 10).Select(x => new User($"user{x}@edafundamentals.com")).ToList();

        public async Task CreateAsync(User entity)
        {   
            _users.Add(entity);
        }

        public async Task DeleteAsync(User entity)
        {
            _users.Remove(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            if (user != null)
                await DeleteAsync(user);
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
