using ControleEstoqueAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoqueAPI.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options ) { }
        public DbSet<Produto> Produtos  { get; set; }
        public DbSet<Movimentacao> Movimentacoes  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
               .HasIndex(p => p.CodigoBarras)
               .IsUnique();
            modelBuilder.Entity<Movimentacao>()
                .HasOne(m => m.Produto)
                .WithMany()
                .HasForeignKey(movimentacaos => movimentacaos.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
