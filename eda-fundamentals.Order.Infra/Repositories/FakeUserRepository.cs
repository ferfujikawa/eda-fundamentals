using eda_fundamentals.Order.Domain.Entities;
using eda_fundamentals.Order.Domain.Repositories;

namespace eda_fundamentals.Order.Infra.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private List<User> _users = Enumerable.Range(1, 10).Select(x => new User($"user{x}@edafundamentals.com")).ToList();

        public async Task CreateAsync(User entity)
        {
            await Task.FromResult(true);
        }

        public async Task DeleteAsync(User entity)
        {
            await Task.FromResult(true);
        }

        public async Task DeleteAsync(Guid id)
        {
            await Task.FromResult(true);
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = new User("usuario_fake@edafundamentals.com");
            await Task.Run(() => _users.Add(user));
            
            return user;
        }
    }
}
