using Avaliacao1ProvaPratica.Models;
using Avaliacao1ProvaPratica.Repository;

namespace Avaliacao1ProvaPratica.Services
{
    public class VotoService : IVotoService
    {
        private readonly IVotoRepository _votoRepository;

        public void adicionarVoto(Voto voto)
        {
            _votoRepository.adicionarVoto(voto);
        }

        public Voto? ObterPorNumeroCandidato(int NumeroVoto)
        {
            return _votoRepository.ObterPorNumeroCandidato(NumeroVoto);
        }
    }
}
