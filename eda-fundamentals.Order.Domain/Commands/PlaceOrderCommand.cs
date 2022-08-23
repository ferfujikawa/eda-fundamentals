using eda_fundamentals.Shared.Commands;

namespace eda_fundamentals.Order.Domain.Commands
{
    public class PlaceOrderCommand : ICommand
    {
        public PlaceOrderCommand()
        {
            Items = new List<OrderItemCommand>();
        }

        public Guid User { get; set; }
        public IList<OrderItemCommand> Items { get; set; }
    }

    public class OrderItemCommand
    {
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }
    }
}
