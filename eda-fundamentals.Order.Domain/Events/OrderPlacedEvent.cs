using eda_fundamentals.Shared.Events;

namespace eda_fundamentals.Order.Domain.Events
{
    public class OrderPlacedEvent : IDomainEvent
    {
        public OrderPlacedEvent(Entities.Order order)
        {
            Id = Guid.NewGuid();
            Order = order;
            OccuredAt = DateTime.Now;
        }

        public Guid Id { get; }
        public Entities.Order Order { get; }
        public DateTime OccuredAt { get; }
    }
}
