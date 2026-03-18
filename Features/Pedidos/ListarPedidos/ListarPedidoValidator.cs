public class ListarPedidoValidator : AbstractValidator<ListarPedidosQuery>
{
    public ListarPedidoValidator()
    {
        RuleFor(x => x).NotNull().WithMessage("O comando não pode ser nulo.");
    }
}