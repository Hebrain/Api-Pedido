using Application.Features.CriarPedido;
using Application.Features.ObterPedidos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api_Pedido.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PedidoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Criar")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PedidoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Criar([FromBody] CriarPedidoCommand criarPedidoCommand)
        {
            try
            {
                var response = await _mediator.Send(criarPedidoCommand);
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Obter")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PedidoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Obter()
        {
            try
            {
                var pedidos = await _mediator.Send(new ObterPedidosQuery());
                if(pedidos == null)
                    return NoContent();

                return Ok(pedidos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }
    }
}
