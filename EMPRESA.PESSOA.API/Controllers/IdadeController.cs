

using Empresa.Pessoa.Service;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.Pessoa.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdadeController : ControllerBase
    {
        [HttpGet(), Route("ObterIdade")]

        public IActionResult ObterIdade(DateTime dataNascimento)
        {
            int idade = new IdadeService().BuscarIdade(dataNascimento);
            return Ok(idade);
        }
    }
}
