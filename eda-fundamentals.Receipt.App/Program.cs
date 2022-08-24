using eda_fundamentals.Receipt.App.Extensions;
using eda_fundamentals.Receipt.App.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eda_fundamentals.Receipt.App;

class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.LoadConfiguration();

        var configuration = builder.Build();

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddKafkaConsumerConfig(configuration);
        serviceCollection.AddServices();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        serviceProvider.GetService<Service>().RunAsync().Wait();

        Console.WriteLine(configuration.GetValue<string>("mensagem"));
    }
}