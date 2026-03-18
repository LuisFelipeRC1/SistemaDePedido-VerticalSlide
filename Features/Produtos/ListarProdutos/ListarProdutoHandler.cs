public class ListarProdutoHandler : IRequestHandler<ListarProdutosQuery, List<Produto>> {
    private readonly AppDbContext _context;

     public ListarProdutoHandler(AppDbContext context) {
        _context = context;
    }

     public async Task<List<Produto>> Handle(ListarProdutosQuery request, CancellationToken cancellationToken) {
         var produtos = await _context.Produtos.AsNoTracking().ToListAsync(cancellationToken);

        return produtos;
    }
}