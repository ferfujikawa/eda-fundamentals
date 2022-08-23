namespace eda_fundamentals.Shared.Commands.Handlers
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
