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
            usuarioDto.Email = usuarioModel.Email;

            return usuarioDto;
        }

        public async Task<List<UsuarioDto>> Listar()
        {
            List<UsuarioModel> usuarios = await _db.Usuarios.ToListAsync();

            List<UsuarioDto> dtos = new List<UsuarioDto>();

            foreach (UsuarioModel usuario in usuarios)
            {
                UsuarioDto dto = new UsuarioDto();
                dto.Id = usuario.Id;
                dto.Nome = usuario.Nome;
                dto.Telefone = usuario.Telefone;
                dto.Cpf = usuario.Cpf;
                dto.Email = usuario.Email;

                dtos.Add(dto);
            }

            return dtos;

        }

        public async Task<UsuarioDto> Consultar(int id)
        {

            UsuarioModel usuario = _db.Usuarios.Find(id);
            UsuarioDto dto = new UsuarioDto();
            dto.Id = usuario.Id;
            dto.Nome = usuario.Nome;
            dto.Telefone = usuario.Telefone;
            dto.Cpf = usuario.Cpf;
            dto.Email = usuario.Email;

            return dto;

        }

        public async Task Atualizar(UsuarioRequestDto dto, int id)
        {

            UsuarioModel usuario = _db.Usuarios.Find(id);
            usuario.Nome = dto.Nome;
            usuario.Telefone = dto.Telefone;
            usuario.Cpf = dto.Cpf;
            usuario.Email = dto.Email;

            await _db.SaveChangesAsync();

        }

        public async Task Remover(int id)
        {
            UsuarioModel usuario = _db.Usuarios.Find(id);
            _db.Usuarios.Remove(usuario);

            await _db.SaveChangesAsync();
        }

    }
}