using Application.Features.CriarPedido;
using Application.Interfaces;
using Infraestrutura.Repositories;

namespace Api_Pedido.Config
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServicesInjection(this IServiceCollection services)
        {
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddMediatR(m => m.RegisterServicesFromAssembly(typeof(CriarPedidoHandler).Assembly));

            return services;
        }
    }
}
