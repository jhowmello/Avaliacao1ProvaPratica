using Avaliacao1ProvaPratica.Models;

namespace Avaliacao1ProvaPratica.Repository
{
    public interface IVotoRepository
    {
        public void adicionarVoto (Voto voto);
        public Voto? ObterPorNumeroCandidato(int NumeroVoto);

    }
}
