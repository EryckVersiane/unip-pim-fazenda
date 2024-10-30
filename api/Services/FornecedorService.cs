using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Models;

namespace UnipPimFazenda.Services
{
    public class FornecedorService
    {
        private readonly ILogger<FornecedorService> _log;
        private readonly AppDbContext _db;

        public FornecedorService(AppDbContext db, ILogger<FornecedorService> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<FornecedorDto> Criar(FornecedorRequestDto fornecedor)
        {
            var fornecedorModel = new FornecedorModel();
            fornecedorModel.Nome = fornecedor.Nome;
            fornecedorModel.Cnpj = fornecedor.Cnpj;
            fornecedorModel.Telefone = fornecedor.Telefone;
            fornecedorModel.Email = fornecedor.Email;
            fornecedorModel.Endereco = fornecedor.Endereco;

            _db.Fornecedores.Add(fornecedorModel);
            await _db.SaveChangesAsync();

            var fornecedorDto = new FornecedorDto();
            fornecedorDto.Id = fornecedorModel.Id;
            fornecedorDto.Nome = fornecedorModel.Nome;
            fornecedorDto.Telefone = fornecedorModel.Telefone;
            fornecedorDto.Cnpj = fornecedorModel.Cnpj;
            fornecedorDto.Email = fornecedorModel.Email;
            fornecedorModel.Endereco = fornecedor.Endereco;

            return fornecedorDto;
        }


        public async Task<List<FornecedorDto>> Listar()
        {
            List<FornecedorModel> fornecedores = await _db.Fornecedores.ToListAsync();

            List<FornecedorDto> dtos = new List<FornecedorDto>();

            foreach (FornecedorModel fornecedor in fornecedores)
            {
                FornecedorDto dto = new FornecedorDto();
                dto.Id = fornecedor.Id;
                dto.Nome = fornecedor.Nome;
                dto.Telefone = fornecedor.Telefone;
                dto.Cnpj = fornecedor.Cnpj;
                dto.Email = fornecedor.Email;
                dto.Endereco = fornecedor.Endereco;

                dtos.Add(dto);
            }

            return dtos;

        }

        public async Task<FornecedorDto> Consultar(int id)
        {

            FornecedorModel fornecedor = _db.Fornecedores.Find(id);
            FornecedorDto dto = new FornecedorDto();
            dto.Id = fornecedor.Id;
            dto.Nome = fornecedor.Nome;
            dto.Telefone = fornecedor.Telefone;
            dto.Cnpj = fornecedor.Cnpj;
            dto.Email = fornecedor.Email;
            dto.Endereco = fornecedor.Endereco;

            return dto;

        }

        public async Task Atualizar(FornecedorRequestDto dto, int id)
        {

            FornecedorModel fornecedor = _db.Fornecedores.Find(id);
            fornecedor.Nome = dto.Nome;
            fornecedor.Telefone = dto.Telefone;
            fornecedor.Cnpj = dto.Cnpj;
            fornecedor.Email = dto.Email;
            fornecedor.Endereco = dto.Endereco;

            await _db.SaveChangesAsync();

        }

        public async Task Remover(int id)
        {
            FornecedorModel fornecedor = _db.Fornecedores.Find(id);
            _db.Fornecedores.Remove(fornecedor);

            await _db.SaveChangesAsync();
        }

    }
}