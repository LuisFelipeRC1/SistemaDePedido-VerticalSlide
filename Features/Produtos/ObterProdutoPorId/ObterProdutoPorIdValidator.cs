public class ObterProdutoPorIdValidator : AbstractValidator<ObterProdutoPorId> {
    public ObterProdutoPorIdValidator() {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("O ID do produto é obrigatório.");
    }
}
