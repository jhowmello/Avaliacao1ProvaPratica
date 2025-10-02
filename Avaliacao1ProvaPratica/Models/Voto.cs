using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Avaliacao1ProvaPratica.Models
{
    public class Voto
    {
        public int NumeroVoto { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "O número do candidato é obrigatório.")]
        public Candidato NumeroCandidato { get; set; }

        [Required(ErrorMessage = "O RA do aluno é obrigatório.")]
        public int ra {  get; set; }
    }
}
