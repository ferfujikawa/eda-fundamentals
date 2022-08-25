using eda_fundamentals.Receipt.App.Configurations;
using eda_fundamentals.Receipt.App.Services;
using eda_fundamentals.Receipt.Domain.EventServices;
using eda_fundamentals.Receipt.Infra.EventServices;
using eda_fundamentals.Receipt.Infra.ExternalServices;
using eda_fundamentals.Shared.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eda_fundamentals.Receipt.App.Extensions
{
    public static class AppExtension
    {
        public static void LoadConfiguration(this ConfigurationBuilder builder)
        {
            builder
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }

        public static void AddKafkaConsumerConfig(this ServiceCollection services, IConfigurationRoot configurationRoot)
        {
            var kafkaConfiguration = new KafkaConsumerConfiguration();
            configurationRoot.GetSection("KafkaConsumerSettings").Bind(kafkaConfiguration);
            services.AddSingleton<IKafkaConsumerConfiguration>(x => kafkaConfiguration);

            services.AddSingleton<KafkaConsumerConfig>();
        }

        public static void AddServices(this ServiceCollection services)
        {
            services.AddTransient<Service>();
            services.AddTransient<IConfigurationRoot, ConfigurationRoot>();
        }

        public static void AddConsumers(this ServiceCollection services)
        {
            services.AddTransient<IKafkaReceiptEventService, KafkaReceiptEventService>();
        }
    }
}
