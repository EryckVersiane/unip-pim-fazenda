using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Models;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Util;

namespace UnipPimFazenda.Services
{

    public class FuncionarioService
    {

        private readonly ILogger<FuncionarioService> _log;
        private readonly AppDbContext _db;

        public FuncionarioService(AppDbContext db, ILogger<FuncionarioService> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<FuncionarioDto> Criar(FuncionarioRequestDto funcionario)
        {
            var funcionarioModel = new FuncionarioModel();
            funcionarioModel.Nome = funcionario.Nome;
            funcionarioModel.Cpf = funcionario.Cpf;
            funcionarioModel.Endereco = funcionario.Endereco;
            funcionarioModel.Telefone = funcionario.Telefone;
            funcionarioModel.Email = funcionario.Email;
            funcionarioModel.Cargo = funcionario.Cargo;
            funcionarioModel.Jornada = funcionario.Jornada;

            _db.Funcionarios.Add(funcionarioModel);
            await _db.SaveChangesAsync();

            var funcionarioDto = new FuncionarioDto();
            funcionarioDto.Id = funcionarioModel.Id;
            funcionarioDto.Nome = funcionarioModel.Nome;
            funcionarioDto.Cpf = funcionarioModel.Cpf;
            funcionarioDto.Endereco = funcionario.Endereco;
            funcionarioDto.Telefone = funcionario.Telefone;
            funcionarioDto.Email = funcionario.Email;
            funcionarioDto.Cargo = funcionario.Cargo;
            funcionarioDto.Jornada = funcionario.Jornada;

            return funcionarioDto;
            
        }


    }
}