using Microsoft.EntityFrameworkCore;
using MeuAppRestful.Models;

namespace MeuAppRestful.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder ) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>(entity => {
                entity.ToTable("produtos", "dbo");
                entity.HasKey(e => e.Codigo);
            });
        }
    }
}
