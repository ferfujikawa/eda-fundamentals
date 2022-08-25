using eda_fundamentals.Shared.Events;

namespace eda_fundamentals.Receipt.Domain.Events
{
    public class OrderPlacedEvent : IDomainEvent
    {
        public Guid Id { get;  set; }
        public Entities.Order Order { get; set; }
        public DateTime OccuredAt { get; set; }
    }
}
