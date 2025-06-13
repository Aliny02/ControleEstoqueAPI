using ControleEstoqueAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoqueAPI.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options ) { }
        public DbSet<Produto> Produtos => Set<Produto>();
        public DbSet<Movimentacao> movimentacaos => Set<Movimentacao>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
               .HasIndex(p => p.CodigoBarras)
               .IsUnique();
            modelBuilder.Entity<Movimentacao>()
                .HasOne(m => m.Produto)
                .WithMany()
                .WasForeignKey(movimentacaos => movimentacaos.ProdutoId)
                .enDelete(DeleteBehavier.Cascado);


        }

    }
}
