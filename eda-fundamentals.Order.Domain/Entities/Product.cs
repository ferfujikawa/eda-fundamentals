using eda_fundamentals.Shared.Entities;

namespace eda_fundamentals.Order.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string name, decimal price) : base()
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}
