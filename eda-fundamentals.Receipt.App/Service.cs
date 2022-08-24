namespace eda_fundamentals.Receipt.App
{
    public class Service
    {
        public Task RunAsync()
        {
            return Task.Run(() => Console.WriteLine("Running Service..."));
        }
    }
}
