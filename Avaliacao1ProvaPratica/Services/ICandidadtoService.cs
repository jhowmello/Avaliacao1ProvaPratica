using Avaliacao1ProvaPratica.Models;

namespace Avaliacao1ProvaPratica.Services
{
    public interface ICandidadtoService
    {

        public void Adicionar(Candidato novoCandidato);

        public Candidato? ObiterCandidadtoNumero(int numeroCandidato);
        public List<Candidato> ObterTodosCandidatos();


    }
}
