using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Login> Usuarios { get; set; }
        public DbSet<Login> Cadastros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder ) {
        }
    }
}
