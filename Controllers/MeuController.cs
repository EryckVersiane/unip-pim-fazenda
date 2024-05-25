using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuAppRestful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeuController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "valor1", "valor2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "valor " + id;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

