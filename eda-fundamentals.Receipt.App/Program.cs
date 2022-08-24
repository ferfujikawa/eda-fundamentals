using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eda_fundamentals.Receipt.App;

class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        var configuration = builder.Build();

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddServices();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        Console.WriteLine(configuration.GetValue<string>("mensagem"));
    }
}