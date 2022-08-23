using eda_fundamentals.Shared.Entities;

namespace eda_fundamentals.Order.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, decimal quantity) : base()
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
