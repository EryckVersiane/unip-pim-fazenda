using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Services;

namespace UnipPimFazenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly FuncionarioService _funcionarioService;

        public FuncionarioController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cadastro de novo funcionario")]
        [ProducesResponseType(typeof(FuncionarioDto), 201)]
        public async Task<IActionResult> Criar([FromBody] FuncionarioRequestDto funcionario)
        {
            var resposta = await _funcionarioService.Criar(funcionario);

            return Ok(resposta);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lista de funcionarios")]
        [ProducesResponseType(typeof(List<FuncionarioDto>), 200)]
        public async Task<IActionResult> Listar()
        {
            List<FuncionarioDto> resposta = await _funcionarioService.Listar();

            return Ok(resposta);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Detalha funcionario")]
        [ProducesResponseType(typeof(FuncionarioDto), 200)]
        public async Task<IActionResult> Consultar(int id)
        {
            FuncionarioDto resposta = await _funcionarioService.Consultar(id);

            return Ok(resposta);
        }

        [HttpPut("{id}")]
    }
}