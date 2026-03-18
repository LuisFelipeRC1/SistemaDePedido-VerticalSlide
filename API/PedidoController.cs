[ApiController]
[Route("api/[controller]")]
public class PedidosController : ControllerBase {
    private readonly IMediator _mediator;

    public PedidosController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarPedidoCommand command) {
        var id = await _mediator.Send(command);
        return Ok(id);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(Guid id) {
        var pedido = await _mediator.Send(new ObterPedidoPorIdQuery(id));
        return Ok(pedido);
    }

    [HttpGet]
    public async Task<IActionResult> Listar() {
        var pedidos = await _mediator.Send(new ListarPedidosQuery());
        return Ok(pedidos);
    }

    
}
