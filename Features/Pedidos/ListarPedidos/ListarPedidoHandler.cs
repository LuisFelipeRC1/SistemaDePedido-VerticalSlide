public class ListarPedidoHandler : IRequestHandler<ListarPedidosQuery, List<Pedido>> {
    private readonly AppDbContext _context;

     public ListarPedidoHandler(AppDbContext context) {
        _context = context;
    }

    public async Task<List<Pedido>> Handle(ListarPedidosQuery request, CancellationToken cancellationToken) {
        var pedidos = await _context.Pedidos
            .AsNoTracking()
            .Include(p => p.Cliente)
            .Include(p => p.Produtos)
            .ToListAsync(cancellationToken);
        return pedidos;
    }

}