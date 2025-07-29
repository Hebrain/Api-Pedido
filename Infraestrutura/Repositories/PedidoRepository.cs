using Application.Interfaces;
using Domain.Entities;
using Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Repositories
{
    public class PedidoRepository(PedidoContext context) : IPedidoRepository
    {
        private readonly PedidoContext _context = context;

        // TODO: Transformar método em asyncrono ao conetectar com base
        public async Task Criar(Pedido pedido)
        {
            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();
        }

        // TODO: Transformar método em asyncrono ao conetectar com base
        public async Task<List<Pedido>> ObterTodos() => await _context.Pedido.ToListAsync();
    }
}
