using eda_fundamentals.Shared.Entities;

namespace eda_fundamentals.Order.Domain.Entities
{
    public class User : Entity
    {
        public User(string email) : base()
        {
            Email = email;
        }

        public string Email { get; private set; }
    }
}
