using Application.Features.CriarPedido;
using Application.Interfaces;
using Infraestrutura.Context;
using Infraestrutura.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Api_Pedido.Config
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServicesInjection(this IServiceCollection services)
        {
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddMediatR(m => m.RegisterServicesFromAssembly(typeof(CriarPedidoHandler).Assembly));
            services.AddDbContext<PedidoContext>(o => o.UseInMemoryDatabase("PedidoDB"));

            return services;
        }
    }
}