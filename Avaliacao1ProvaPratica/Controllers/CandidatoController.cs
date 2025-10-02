using Avaliacao1ProvaPratica.Models;
using Avaliacao1ProvaPratica.Repository;
using Avaliacao1ProvaPratica.Services;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao1ProvaPratica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidadtoService _candidatoService;

        public CandidatoController(ICandidadtoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        [HttpGet("candidatos")]
        public ActionResult<List<Candidato>> ObterTodosCandidatos()
        {
            var candidatos = _candidatoService.ObterTodosCandidatos();
            return Ok(candidatos);
        }

        [HttpGet("candidato/{numero}")]
        public ActionResult<Candidato> ObterCandidatoPorNumero(int numero)
        {
            var candidato = _candidatoService.ObiterCandidadtoNumero(numero);
            if (candidato == null)
                return NotFound("Candidato não encontrado.");
            return Ok(candidato);
        }

        [HttpPost("candidato")]
        public ActionResult Adicionar([FromBody] Candidato novoCandidato)
        {
            _candidatoService.Adicionar(novoCandidato);
            return Ok("Candidato adicionado");
        }
    }
}
