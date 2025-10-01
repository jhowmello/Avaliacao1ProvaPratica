using Avaliacao1ProvaPratica.Models;
using System.Linq;

namespace Avaliacao1ProvaPratica.Repository
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private static List<Candidato> candidatos = new List<Candidato>();


        public List<Candidato> ObterTodosCandidatos()
        {
            return new List<Candidato>();
        }

        public void adicionarCandidatos(Candidato novoCandidato)
        {
            candidatos.Add(novoCandidato);
        }

        public Candidato? ObterCandidatoNumero(int numero)
        {
            return candidatos.FirstOrDefault(a => a.numerocadidato == numero);
        }


    }
}
