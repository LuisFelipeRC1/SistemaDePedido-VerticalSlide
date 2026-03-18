public class ObterProdutoPorIdHandler : IRequestHandler<ObterProdutoPorId, Produto> {
    private readonly AppDbContext _context;

    public ObterProdutoPorIdHandler(AppDbContext context) {
        _context = context;
    }

    public async Task<Produto> Handle(ObterProdutoPorId request, CancellationToken cancellationToken) {
        var produto = await _context.Produtos
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

        if (produto == null) {
            throw new KeyNotFoundException($"Produto com ID {request.Id} não encontrado.");
        }

        return produto;
    }
}
