
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Services;

namespace UnipPimFazenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly FornecedorService _fornecedorService;

        public FornecedorController(FornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cadastro de novo fornecedor")]
        [ProducesResponseType(typeof(FornecedorDto), 201)]
        public async Task<IActionResult> Criar([FromBody] FornecedorRequestDto fornecedor)
        {
            var resposta = await _fornecedorService.Criar(fornecedor);

            return Ok(resposta);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lista de fornecedores")]
        [ProducesResponseType(typeof(List<FornecedorDto>), 200)]
        public async Task<IActionResult> Listar()
        {
            List<FornecedorDto> resposta = await _fornecedorService.Listar();

            return Ok(resposta);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Detalha fornecedor")]
        [ProducesResponseType(typeof(FornecedorDto), 200)]
        public async Task<IActionResult> Consultar(int id)
        {
            FornecedorDto resposta = await _fornecedorService.Consultar(id);

            return Ok(resposta);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atulizar fornecedor")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Atualizar([FromBody] FornecedorRequestDto fornecedor, int id)
        {
            await _fornecedorService.Atualizar(fornecedor, id);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Deletar fornecedor")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Remover(int id)
        {
            await _fornecedorService.Remover(id);

            return NoContent();
        }

    }
}