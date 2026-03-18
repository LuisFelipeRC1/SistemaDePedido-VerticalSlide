public class ObterPedidoValidator : AbstractValidator<ObterPedidoPorIdQuery>
{
    public ObterPedidoValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("O Id do pedido é obrigatório.");
    }
}