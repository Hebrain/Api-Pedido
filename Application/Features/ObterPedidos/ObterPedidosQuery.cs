using MediatR;

namespace Application.Features.ObterPedidos
{
    public record ObterPedidosQuery() : IRequest<List<PedidoDTO>>;
}
