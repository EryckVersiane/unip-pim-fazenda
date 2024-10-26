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

        // public async Task<List<Cadastro>> ListarCadastros() {
        //     var Cadastros = await _db.Cadastros.ToListAsync();
        //     return Cadastros;
        // }

        // public async Task<Cadastro?> Salvar(Cadastro? Cadastro) {
        //     if (Cadastro == null) {
        //         return null;
        //     }
        //     await _db.Cadastros.AddAsync(Cadastro);
        //     await _db.SaveChangesAsync();
        //     return await _db.Cadastros.FirstOrDefaultAsync( p => p.Id == Cadastro.Id);

        // }
    }
}