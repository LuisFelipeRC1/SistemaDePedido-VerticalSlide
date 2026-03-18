public sealed class Cliente {
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public Cliente(Guid id, string nome, string email) {
        Id = id;
        Nome = nome;
        Email = email;
    }
}