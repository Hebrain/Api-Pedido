using Application.Interfaces;
using MediatR;

namespace Application.Features.ObterPedidos
{
    public class ObterPedidosHandler(IPedidoRepository pedidoRepository) : IRequestHandler<ObterPedidosQuery, List<PedidoDTO>>
    {
        private readonly IPedidoRepository _pedidoRepository = pedidoRepository;

        public async Task<List<PedidoDTO>> Handle(ObterPedidosQuery request, CancellationToken cancellationToken)
        {
            var pedidos = await _pedidoRepository.ObterTodos();
            return pedidos.Select(p => new PedidoDTO(p.Cliente, p.DataCriacao)).ToList();
        }
    }
}