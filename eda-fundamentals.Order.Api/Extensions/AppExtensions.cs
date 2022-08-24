using eda_fundamentals.Order.Api.Configurations;
using eda_fundamentals.Order.Domain.Commands;
using eda_fundamentals.Order.Domain.EventServices;
using eda_fundamentals.Order.Domain.Handlers;
using eda_fundamentals.Order.Domain.Repositories;
using eda_fundamentals.Order.Infra.EventServices;
using eda_fundamentals.Order.Infra.ExternalServices;
using eda_fundamentals.Order.Infra.Repositories;

namespace eda_fundamentals.Order.Api.Extensions
{
    public static class AppExtensions
    {
        public static void AddKafkaProducerConfig(this WebApplicationBuilder builder)
        {
            var kafkaConfiguration = new KafkaConfiguration();
            builder.Configuration.GetSection("KafkaServer").Bind(kafkaConfiguration);
            
            builder.Services.AddTransient(x => new KafkaProducerConfig(kafkaConfiguration));
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<PlaceOrderHandler>();
            services.AddTransient<PlaceOrderCommand>();
            services.AddTransient<IUserRepository, FakeUserRepository>();
            services.AddTransient<IProductRepository, FakeProductRepository>();
            services.AddTransient<IOrderRepository, FakeOrderRepository>();
        }

        public static void AddPublishers(this IServiceCollection services)
        {
            services.AddTransient<IOrderEventService, KafkaOrderEventService>();
        }
    }
}
