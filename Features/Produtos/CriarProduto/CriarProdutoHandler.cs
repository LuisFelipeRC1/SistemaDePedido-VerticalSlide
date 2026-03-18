public class CriarProdutoHandler : IRequestHandler<CriarProdutoCommand,Guid> {
    private readonly AppDbContext _context;

    public CriarProdutoHandler(AppDbContext context) {
        _context = context;
    }

    public async Task<Guid> Handle(CriarProdutoCommand request, CancellationToken cancellationToken) {
        var produto = new Produto(request.Id, request.Nome, request.Preco);
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync(cancellationToken);
        return produto.Id;
    }
}