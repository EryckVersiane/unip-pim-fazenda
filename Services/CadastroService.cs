using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Services 
{
    public class CadastroService {

        private readonly ILogger<CadastroService> _log;
        private readonly AppDbContext _db;

        public CadastroService(AppDbContext db, ILogger<CadastroService> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<List<cadastro>> Listarcadastros() {
            var cadastros = await _db.cadastros.ToListAsync();
            return cadastros;
        }

        public async Task<cadastro?> Salvar(cadastro? cadastro) {
            if (cadastro == null) {
                return null;
            }
            await _db.cadastros.AddAsync(cadastro);
            await _db.SaveChangesAsync();
            return await _db.cadastros.FirstOrDefaultAsync( p => p.Id == cadastro.Id);

        }
    }
}