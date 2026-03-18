using MediatR;

public record CriarPedidoCommand(Guid Id, string Descricao, decimal Valor, Guid ClienteId, List<Guid> ProdutoIds) : IRequest<Guid>;
