using Avaliacao1ProvaPratica.Models;
using Avaliacao1ProvaPratica.Services;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao1ProvaPratica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VotoController : ControllerBase
    {
        private readonly IVotoService _votoService;

        public VotoController(IVotoService votoService)
        {
            _votoService = votoService;
        }

        [HttpPost("voto")]
        public ActionResult AdicionarVoto([FromBody] Voto voto)
        {
            _votoService.adicionarVoto(voto);
            return Ok("Voto adicionado");
        }

        [HttpGet("ObterPorNumero/{numeroVoto}")]
        public ActionResult<Voto> ObterPorNumeroCandidato(int numeroVoto)
        {
            var resultado = _votoService.ObterPorNumeroCandidato(numeroVoto);
            if (resultado == null)
                return NotFound("Voto não encontrado.");
            return Ok(resultado);
        }
    }
}
