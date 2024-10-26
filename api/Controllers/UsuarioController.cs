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
        [ProducesResponseType(typeof(UsuarioDto),201)]
        public async Task<IActionResult> Criar([FromBody] UsuarioRequestDto usuario)
        {
            var resposta = await _usuarioService.Criar(usuario);

            return Ok(resposta);
        }
    }
}