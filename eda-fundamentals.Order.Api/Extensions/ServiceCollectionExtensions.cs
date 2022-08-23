﻿using eda_fundamentals.Order.Domain.Commands;
using eda_fundamentals.Order.Domain.Handler;
using eda_fundamentals.Order.Domain.Repositories;
using eda_fundamentals.Order.Infra.Repositories;

namespace eda_fundamentals.Order.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<PlaceOrderHandler>();
            services.AddTransient<PlaceOrderCommand>();
            services.AddTransient<IUserRepository, FakeUserRepository>();
            services.AddTransient<IProductRepository, FakeProductRepository>();
            services.AddTransient<IOrderRepository, FakeOrderRepository>();
        }
    }
}