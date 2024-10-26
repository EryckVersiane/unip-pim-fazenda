using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Services 
{
    public class PessoaService {

        private readonly ILogger<PessoaService> _log;
        private readonly AppDbContext _db;

        public PessoaService(AppDbContext db, ILogger<PessoaService> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<List<Pessoa>> ListarPessoas() {
            var pessoas = await _db.Pessoas.ToListAsync();
            return pessoas;
        }

        public async Task<Pessoa?> Salvar(Pessoa? pessoa) {
            if (pessoa == null) {
                return null;
            }
            await _db.Pessoas.AddAsync(pessoa);
            await _db.SaveChangesAsync();
            return await _db.Pessoas.FirstOrDefaultAsync( p => p.Id == pessoa.Id);

        }
    }
}