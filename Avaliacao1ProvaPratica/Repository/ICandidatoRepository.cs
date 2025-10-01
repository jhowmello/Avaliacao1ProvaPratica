using Avaliacao1ProvaPratica.Models;

namespace Avaliacao1ProvaPratica.Repository
{
    public interface ICandidatoRepository
    {

        public List<Candidato> ObterTodosCandidatos();

        public Candidato? ObterCandidatoNumero(int numero);

        public void adicionarCandidatos(Candidato novoCandidato);

    }
}
