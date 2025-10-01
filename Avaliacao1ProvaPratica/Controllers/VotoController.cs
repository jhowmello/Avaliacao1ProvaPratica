using Avaliacao1ProvaPratica.Models;
using Avaliacao1ProvaPratica.Services;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao1ProvaPratica.Controllers
{
    [ApiController()]
    [Route("api/[controller]")]
    public class VotoController
    {
        private IVotoService _votoService;

        [HttpPost("voto")]
        public ActionResult<Voto> adicionarVoto([FromBody] Voto voto)
        {
            _votoService.adicionarVoto(voto);

            return Ok("Voto adicionado");
        }

        [HttpGet("ObterPorNumero")]
        public ActionResult<Voto> ObterPorNumeroCandidato([FromBody] int voto)
        {
            var resultado = _votoService.ObterPorNumeroCandidato(voto);


            return Ok(resultado);

           
        }


    }






    
}
