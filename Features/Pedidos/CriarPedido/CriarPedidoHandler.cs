public class CriarPedidoHandler : IRequestHandler<CriarPedidoCommand, Guid> {
    private readonly AppDbContext _context;

    public CriarPedidoHandler(AppDbContext context) {
        _context = context;
    }

    public async Task<Guid> Handle(CriarPedidoCommand request, CancellationToken cancellationToken) {
        var cliente = await _context.Clientes.FindAsync(new object[] { request.ClienteId }, cancellationToken);
        if (cliente == null) {
            throw new KeyNotFoundException("Cliente não encontrado");
        }

        var produtos = await _context.Produtos
            .Where(p => request.ProdutoIds.Contains(p.Id))
            .ToListAsync(cancellationToken);

        if (produtos.Count != request.ProdutoIds.Count) {
            throw new KeyNotFoundException("Um ou mais produtos não encontrados");
        }

        var pedido = new Pedido(request.Id, request.Descricao, request.Valor, cliente, produtos);
        _context.Pedidos.Add(pedido);
        await _context.SaveChangesAsync(cancellationToken);

        return pedido.Id;
    }
}