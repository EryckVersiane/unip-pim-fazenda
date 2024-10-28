using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using UnipPimFazenda.Dtos;
using UnipPimFazenda.Services;

namespace UnipPimFazenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cadastro de novo usuário")]
        [ProducesResponseType(typeof(UsuarioDto), 201)]
        public async Task<IActionResult> Criar([FromBody] UsuarioRequestDto usuario)
        {
            var resposta = await _usuarioService.Criar(usuario);

            return Ok(resposta);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lista de usuários")]
        [ProducesResponseType(typeof(List<UsuarioDto>), 200)]
        public async Task<IActionResult> Listar()
        {
            List<UsuarioDto> resposta = await _usuarioService.Listar();

            return Ok(resposta);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Detalha usuário")]
        [ProducesResponseType(typeof(UsuarioDto), 200)]
        public async Task<IActionResult> Consultar(int id)
        {
            UsuarioDto resposta = await _usuarioService.Consultar(id);

            return Ok(resposta);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atulizar usuário")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Atualizar([FromBody] UsuarioRequestDto usuario, int id)
        {
            await _usuarioService.Atualizar(usuario, id);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Deletar usuário")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Remover(int id)
        {
            await _usuarioService.Remover(id);

            return NoContent();
        }

    }
}