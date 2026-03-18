public class CriarProdutoValidator : AbstractValidator<CriarProdutoCommand> {
    public CriarProdutoValidator() {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do produto é obrigatório.")
            .MaximumLength(120).WithMessage("O nome do produto deve ter no máximo 120 caracteres.");

        RuleFor(x => x.Preco)
            .GreaterThan(0).WithMessage("O preço do produto deve ser maior que zero.");
    }
}
