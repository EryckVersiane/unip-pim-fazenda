using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using UnipPimFazenda.Models;
using UnipPimFazenda.Services;

namespace UnipPimFazenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaService _pessoaService;

        public PessoaController(PessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lista pessoas")]
        [ProducesResponseType(typeof(List<Pessoa>), 200)]
        public async Task<IActionResult> Listar() {
            return Ok(await _pessoaService.ListarPessoas());
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Salva uma nova pessoa")]
        [ProducesResponseType(typeof(Pessoa), 201)]
        public async Task<IActionResult> Salvar(Pessoa pessoa) {
            var pessoaSalva = await _pessoaService.Salvar(pessoa);
            return Ok(pessoaSalva);
        }
    }
}