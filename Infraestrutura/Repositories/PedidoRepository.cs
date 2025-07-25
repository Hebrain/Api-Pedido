using Application.Interfaces;
using Domain.Entities;

namespace Infraestrutura.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private static readonly List<Pedido> _db = new();

        // TODO: Transformar método em asyncrono ao conetectar com base
        public Task Criar(Pedido pedido)
        {
            _db.Add(pedido);
            return Task.CompletedTask;
        }

        // TODO: Transformar método em asyncrono ao conetectar com base
        public Task<List<Pedido>> ObterTodos() => Task.FromResult(_db);
    }
}
