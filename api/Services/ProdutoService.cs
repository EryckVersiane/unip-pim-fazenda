using Microsoft.EntityFrameworkCore;
using UnipPimFazenda.Data;
using UnipPimFazenda.Models;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Util;

namespace UnipPimFazenda.Services
{
    public class ProdutoService
    {

        private readonly ILogger<ProdutoService> _log;
        private readonly AppDbContext _db;

        public ProdutoService(AppDbContext db, ILogger<ProdutoService> log)
        {
            _db = db;
            _log = log;
        }
        public async Task<ProdutoDto> Criar(ProdutoRequestDto produto)
        {
            var produtoModel = new ProdutoModel();
            produtoModel.Nome = produto.Nome;
            produtoModel.Preco = produto.Preco;
            produtoModel.Quantidade = produto.Quantidade;
            produtoModel.Peso = produto.Peso;
            produtoModel.UnidadeMedida = produto.UnidadeMedida;

            _db.Produtos.Add(produtoModel);
            await _db.SaveChangesAsync();

            var produtoDto = new ProdutoDto();
            produtoDto.Id = produtoModel.Id;
            produtoDto.Nome = produtoModel.Nome;
            produtoDto.Preco = produtoModel.Preco;
            produtoDto.Quantidade = produtoModel.Quantidade;
            produtoDto.Peso = produtoModel.Peso;
            produtoDto.UnidadeMedida = produtoModel.UnidadeMedida;

            return produtoDto;
        }

        public async Task<List<ProdutoDto>> Listar()
        {
            List<ProdutoModel> produtos = await _db.Produtos.ToListAsync();

            List<ProdutoDto> dtos = new List<ProdutoDto>();

            foreach (ProdutoModel produto in produtos)
            {
                ProdutoDto dto = new ProdutoDto();
                dto.Id = produto.Id;
                dto.Nome = produto.Nome;
                dto.Preco = produto.Preco;
                dto.Quantidade = produto.Quantidade;
                dto.Peso = produto.Peso;
                dto.UnidadeMedida = produto.UnidadeMedida;

                dtos.Add(dto);
            }

            return dtos;

        }

        public async Task<ProdutoDto> Consultar(int id)
        {

            ProdutoModel produto = _db.Produtos.Find(id);
            ProdutoDto dto = new ProdutoDto();
            dto.Id = produto.Id;
            dto.Nome = produto.Nome;
            dto.Preco = produto.Preco;
            dto.Quantidade = produto.Quantidade;
            dto.Peso = produto.Peso;
            dto.UnidadeMedida = produto.UnidadeMedida;

            return dto;

        }

        public async Task Atualizar(ProdutoRequestDto dto, int id)
        {

            ProdutoModel produto = _db.Produtos.Find(id);
            produto.Nome = dto.Nome;
            produto.Preco = dto.Preco;
            produto.Quantidade = dto.Quantidade;
            produto.Peso = dto.Peso;
            produto.UnidadeMedida = dto.UnidadeMedida;

            await _db.SaveChangesAsync();

        }

        public async Task Remover(int id)
        {
            ProdutoModel produto = _db.Produtos.Find(id);
            _db.Produtos.Remove(produto);

            await _db.SaveChangesAsync();
        }

    }
}
