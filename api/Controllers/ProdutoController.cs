using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Services;

namespace UnipPimFazenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cadastro de novo produto")]
        [ProducesResponseType(typeof(ProdutoDto), 201)]
        public async Task<IActionResult> Criar([FromBody] ProdutoRequestDto produto)
        {
            var resposta = await _produtoService.Criar(produto);

            return Ok(resposta);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lista de produtos")]
        [ProducesResponseType(typeof(List<ProdutoDto>), 200)]
        public async Task<IActionResult> Listar()
        {
            List<ProdutoDto> resposta = await _produtoService.Listar();

            return Ok(resposta);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Detalha produto")]
        [ProducesResponseType(typeof(ProdutoDto), 200)]
        public async Task<IActionResult> Consultar(int id)
        {
            ProdutoDto resposta = await _produtoService.Consultar(id);

            return Ok(resposta);
        }
    }
}