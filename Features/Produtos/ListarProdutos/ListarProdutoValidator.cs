public class ListarProdutoValidator : AbstractValidator<ListarProdutosQuery>
{
    public ListarProdutoValidator()
    {
        RuleFor(x => x).NotNull().WithMessage("O comando não pode ser nulo.");
    }
}