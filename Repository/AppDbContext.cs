public class AppDbContext : DbContext {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
    }

    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Cliente)
            .WithMany()
            .HasForeignKey("ClienteId");

        modelBuilder.Entity<Pedido>()
            .HasMany(p => p.Produtos)
            .WithMany();
        
        modelBuilder.Entity<Produto>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Cliente>()
            .HasKey(c => c.Id);
        

        base.OnModelCreating(modelBuilder);
    }
}