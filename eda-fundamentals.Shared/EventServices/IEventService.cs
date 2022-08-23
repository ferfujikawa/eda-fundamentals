using eda_fundamentals.Shared.Events;

namespace eda_fundamentals.Shared.EventServices
{
    public interface IEventService
    {
        public Task QueueAsync(IDomainEvent evt);
    }
}
