using MediatR;

namespace Application.Features.CriarPedido
{
    public record CriarPedidoCommand(string Cliente) : IRequest<PedidoResponse>;
}
