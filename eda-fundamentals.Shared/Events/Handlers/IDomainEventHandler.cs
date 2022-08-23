namespace eda_fundamentals.Shared.Events.Handlers
{
    public interface IDomainEventHandler<T> where T : IDomainEvent
    {
        Task HandleAsync(T evt);
    }
}
