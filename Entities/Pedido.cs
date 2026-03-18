public sealed class Pedido {
    public Guid Id { get; private set; }
    public string Descricao { get; private set; }
    public decimal Valor { get; private set; }
    public Cliente Cliente { get; private set; }
    public List<Produto> Produtos { get; private set; }

    public Pedido(Guid id, string descricao, decimal valor, Cliente cliente, List<Produto> produtos) {
        Validate(descricao, valor, cliente, produtos);
        
        Id = id;
        Descricao = descricao;
        Valor = valor;
        Cliente = cliente;
        Produtos = produtos;
    }

    private static void Validate(string descricao, decimal valor, Cliente cliente, List<Produto> produtos) {
        if (string.IsNullOrWhiteSpace(descricao)) {
            throw new ArgumentException("Descrição é obrigatória.");
        }
        if (valor <= 0) {
            throw new ArgumentException("Valor deve ser maior que zero.");
        }
        if (cliente == null) {
            throw new ArgumentException("Cliente é obrigatório.");
        }
        if (produtos == null || produtos.Count == 0) {
            throw new ArgumentException("Pelo menos um produto é obrigatório.");
        }
    }


    

}