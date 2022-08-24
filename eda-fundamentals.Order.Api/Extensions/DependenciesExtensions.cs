using eda_fundamentals.Order.Domain.Commands;
using eda_fundamentals.Order.Domain.EventServices;
using eda_fundamentals.Order.Domain.Handlers;
using eda_fundamentals.Order.Domain.Repositories;
using eda_fundamentals.Order.Infra.EventServices;
using eda_fundamentals.Order.Infra.ExternalServices;
using eda_fundamentals.Order.Infra.Repositories;

namespace eda_fundamentals.Order.Api.Extensions
{
    public static class DependenciesExtensions
    {
        public static void AddProducerConfig(this IServiceCollection services, string bootStrapServers)
        {
            services.AddTransient(x => new KafkaProducerConfig(bootStrapServers));
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
