namespace eda_fundamentals.Shared.Events
{
    public interface IDomainEvent
    {
        Guid Id { get; }
        DateTime OccuredAt { get; }
    }
}
