using eda_fundamentals.Shared.Entities;

namespace eda_fundamentals.Order.Domain.Entities
{
    public class Order : Entity
    {
        private readonly IList<OrderItem> _items;
        public Order(User user) : base()
        {
            User = user;
            _items = new List<OrderItem>();
        }

        public User User { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();

        public void AddItem(Product product, decimal quantity)
        {
            var item = new OrderItem(product, quantity);
            _items.Add(item);
        }
    }
}
