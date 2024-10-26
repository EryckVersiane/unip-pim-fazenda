using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Models;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Util;

namespace UnipPimFazenda.Services
{
    public class UsuarioService
    {

        private readonly ILogger<UsuarioService> _log;
        private readonly AppDbContext _db;

        public UsuarioService(AppDbContext db, ILogger<UsuarioService> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<UsuarioDto> Criar(UsuarioRequestDto usuario)
        {
            var usuarioModel = new UsuarioModel();
            usuarioModel.Nome = usuario.Nome;
            usuarioModel.Telefone = usuario.Telefone;
            usuarioModel.Cpf = usuario.Cpf;
            usuarioModel.Email = usuario.Email;
            usuarioModel.Senha = StringUtil.HashPassword(usuario.Senha);

            _db.Usuarios.Add(usuarioModel);
            await _db.SaveChangesAsync();

            var usuarioDto = new UsuarioDto();
            usuarioDto.Id = usuarioModel.Id;
            usuarioDto.Nome = usuarioModel.Nome;
            usuarioDto.Telefone = usuarioModel.Telefone;
            usuarioDto.Cpf = usuarioModel.Cpf;
            usuarioDto.Email= usuarioModel.Email;    

            return usuarioDto;  
        } 

    }
}