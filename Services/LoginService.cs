using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Services 
{
    public class LoginService {

        private readonly ILogger<LoginService> _log;
        private readonly AppDbContext _db;

        public LoginService(AppDbContext db, ILogger<LoginService> log)
        {
            _db = db;
            _log = log;
        }

        // Método para listar todos os logins
        public async Task<List<Login>> ListarLogins() {
            _log.LogInformation("Listando todos os logins.");
            return await _db.Logins.ToListAsync();
        }

        // Método para salvar um login
        public async Task<Login> Salvar(Login login) {
            if (login == null) {
                _log.LogWarning("Tentativa de salvar um login nulo.");
                throw new ArgumentNullException(nameof(login), "O login não pode ser nulo.");
            }

            _log.LogInformation($"Salvando o login para o usuário ID: {login.UsuarioId}");

            await _db.Logins.AddAsync(login);
            await _db.SaveChangesAsync();

            _log.LogInformation($"Login salvo com sucesso para o usuário ID: {login.UsuarioId}, Login ID: {login.Id}");

            // Retorna o login que acabou de ser salvo
            return login;
        }
    }
}
