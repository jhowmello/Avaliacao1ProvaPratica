using System.ComponentModel.DataAnnotations;

namespace Avaliacao1ProvaPratica.Models
{
    public class Candidato
    {
        [Required(ErrorMessage = "O nome do candidato é obrigatório.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "A turma é obrigatória.")]
        [Range(1, 8, ErrorMessage = "A turma deve ser um número entre 1 e 8.")]
        public int turma { get; set; }

        [Required(ErrorMessage = "O número do candidato é obrigatório.")]
        [Range(10, 99, ErrorMessage = "O número do candidato deve estar entre 10 e 99.")]
        public int numerocadidato { get; set; }

        [Required(ErrorMessage = "A descrição da proposta é obrigatória.")]
        [StringLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres.")]
        public string proposta { get; set; }
    }
}
