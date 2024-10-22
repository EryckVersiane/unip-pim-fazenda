using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder ) {
        }
    }
}
