using eda_fundamentals.Receipt.App.Configurations;
using eda_fundamentals.Receipt.App.Services;
using eda_fundamentals.Receipt.Infra.ExternalServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eda_fundamentals.Receipt.App.Extensions
{
    public static class DependenciesExtension
    {
        public static void LoadConfiguration(this ConfigurationBuilder builder)
        {
            builder
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }

        public static void AddKafkaConsumerConfig(this ServiceCollection services, IConfigurationRoot configurationRoot)
        {
            var kafkaConfiguration = new KafkaConfiguration();
            configurationRoot.GetSection("KafkaServer").Bind(kafkaConfiguration);

            services.AddTransient(x => new KafkaConsumerConfig(kafkaConfiguration));
        }

        public static void AddServices(this ServiceCollection services)
        {
            services.AddTransient<Service>();
            services.AddTransient<IConfigurationRoot, ConfigurationRoot>();
        }
    }
}
