using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder ) {
        }
    }
}
