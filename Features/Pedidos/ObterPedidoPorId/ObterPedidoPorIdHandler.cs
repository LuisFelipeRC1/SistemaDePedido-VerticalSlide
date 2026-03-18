public class ObterPedidoPorIdHandler : IRequestHandler<ObterPedidoPorIdQuery, Pedido>
{
    private readonly AppDbContext _context;
    public ObterPedidoPorIdHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Pedido> Handle(ObterPedidoPorIdQuery request, CancellationToken cancellationToken)
    {
        var pedido = await _context.Pedidos
            .AsNoTracking()
            .Include(p => p.Cliente)
            .Include(p => p.Produtos)
            .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
        if (pedido == null)
        {
            throw new KeyNotFoundException($"Pedido com ID {request.Id} não encontrado.");
        }
        return pedido;
    }
}