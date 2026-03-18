public sealed class Produto {
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }

    public Produto(Guid id, string nome, decimal preco) {
        Id = id;
        Nome = nome;
        Preco = preco;
    }
}