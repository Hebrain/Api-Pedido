using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Context
{
    public class PedidoContext(DbContextOptions<PedidoContext> options) : DbContext(options)
    {
        public DbSet<Pedido> Pedido => Set<Pedido>();
    }
}