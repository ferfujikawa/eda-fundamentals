using eda_fundamentals.Order.Domain.Events;
using eda_fundamentals.Shared.EventServices;

namespace eda_fundamentals.Order.Domain.EventServices
{
    public interface IOrderEventService : IEventService<OrderPlacedEvent>
    {
    }
}
