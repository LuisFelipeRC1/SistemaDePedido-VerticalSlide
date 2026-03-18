public class CriarPedidoValidator : AbstractValidator<CriarPedidoCommand> {
    public CriarPedidoValidator() {
        RuleFor(x => x.Descricao)
            .NotEmpty().WithMessage("A descrição do pedido é obrigatória.")
            .MaximumLength(200).WithMessage("A descrição do pedido deve ter no máximo 200 caracteres.");

        RuleFor(x => x.Valor)
            .GreaterThan(0).WithMessage("O valor do pedido deve ser maior que zero.");

        RuleFor(x => x.ClienteId)
            .NotEmpty().WithMessage("O ID do cliente é obrigatório.");

        RuleFor(x => x.ProdutoIds)
            .NotEmpty().WithMessage("A lista de produtos não pode estar vazia.");
    }
}