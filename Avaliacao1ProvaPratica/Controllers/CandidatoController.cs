using Avaliacao1ProvaPratica.Models;
using Avaliacao1ProvaPratica.Repository;
using Avaliacao1ProvaPratica.Services;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao1ProvaPratica.Controllers
{
    [ApiController()]
    [Route("api / [controller]")]
    public class CandidatoController : ControllerBase
    {
        private ICandidadtoService _candidatoService;

        public CandidatoController(ICandidadtoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        [HttpGet("candidatos")]
        public ActionResult<List<Candidato>> ObterCandidatoNumero()
        {

            return Ok(_candidatoService.ObiterCandidadtoNumero);
             

        }
        [HttpPost("candidato")]
        public ActionResult<Candidato>> Adicionar ([FromBody] Candidato novocandidato)
        {
            _candidatoService.Adicionar(novocandidato);

            return Ok("Candidato adicionado");
        }
        {

        }
    }
}
