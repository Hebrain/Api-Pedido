using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPedidoRepository
    {
        Task Criar(Pedido pedido);
        Task<List<Pedido>> ObterTodos();
    }
}
