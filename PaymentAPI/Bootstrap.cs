using Microsoft.EntityFrameworkCore;
using PaymentAPI.Application;
using PaymentAPI.Application.Order.Commands.v1.Create;
using PaymentAPI.Application.Order.Queries.v1.List;
using PaymentAPI.Application.Payment.Commands.v1.Create;
using PaymentAPI.Application.Payment.Queries.v1.List;
using PaymentAPI.Application.Strategies;
using PaymentAPI.Domain.Contracts;
using PaymentAPI.Infra.Repository;
//using PaymentAPI.Infra.Repository.Context;
using PaymentAPI.Infra.Repository.Repositories;

namespace PaymentAPI
{
    public static class Bootstrap
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCommands();
            services.AddQueries();
            services.AddStrategies();
            services.AddContexts();
            services.AddMappers();
            services.AddFactories();
            services.AddUnitOfWork();
            services.AddRepositoriesContexts();
            services.AddRepositories(configuration);
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateOrderCommandHandler>());
            return services;
        }

        private static void AddCommands(this IServiceCollection services)
        {
            services.AddScoped<CreatePaymentCommandHandler>();
            services.AddScoped<CreateOrderCommandHandler>();
        }

        private static void AddQueries(this IServiceCollection services)
        {
            services.AddScoped<ListPaymentQueryHandler>();
            services.AddScoped<ListOrderQueryHandler>();
        }

        private static void AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(CreatePaymentCommandProfile),
                typeof(CreateOrderCommandProfile),
            typeof(ListPaymentQueryProfile),
                typeof(ListOrderQueryProfile));
        }

        private static void AddStrategies(this IServiceCollection services)
        {
            services.AddScoped<IStrategy, PixStrategy>();
            services.AddScoped<IStrategy, DebtStrategy>();
            services.AddScoped<IStrategy, CreditStrategy>();
            services.AddScoped<IStrategy, TicketStrategy>();
        }

        private static void AddContexts(this IServiceCollection services)
        {
            services.AddScoped<IPaymentFactory, PaymentFactory>();
            services.AddScoped<StrategyImpl>();
        }

        private static void AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        private static void AddFactories(this IServiceCollection services)
        {
            services.AddScoped<IPaymentFactory, PaymentFactory>();
        }

        private static void AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<DbContext, PaymentAPIContext>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(SqlRepository<>));
        }

        private static void AddRepositoriesContexts(this IServiceCollection services)
        {
            //services.AddSingleton<IMongoContext, MongoContext>();
        }
    }
}
