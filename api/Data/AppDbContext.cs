using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<FornecedorModel> Fornecedores { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        // public DbSet<Cadastro> Cadastros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
