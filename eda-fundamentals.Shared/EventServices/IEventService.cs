using eda_fundamentals.Shared.Events;

namespace eda_fundamentals.Shared.EventServices
{
    public interface IEventService<T> where T : IDomainEvent
    {
        Task QueueAsync(T domainEvent);
    }
}
