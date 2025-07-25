using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.CriarPedido
{
    public class CriarPedidoHandler(IPedidoRepository pedidoRepository) : IRequestHandler<CriarPedidoCommand, PedidoResponse>
    {
        private readonly IPedidoRepository _pedidoRepository = pedidoRepository;

        public async Task<PedidoResponse> Handle(CriarPedidoCommand request, CancellationToken cancellationToken)
        {
            var pedido = new Pedido(request.Cliente);
            await _pedidoRepository.Criar(pedido);

            return new PedidoResponse(pedido.Id);
        }
    }
}
