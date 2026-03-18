[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase {
    private readonly IMediator _mediator;

    public ProdutosController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarProdutoCommand command) {
        var id = await _mediator.Send(command);
        return Ok(id);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(Guid id) {
        var produto = await _mediator.Send(new ObterProdutoPorId(id));
        return Ok(produto);
    }

    [HttpGet]
    public async Task<IActionResult> Listar() {
        var produtos = await _mediator.Send(new ListarProdutosQuery());
        return Ok(produtos);
    }
}