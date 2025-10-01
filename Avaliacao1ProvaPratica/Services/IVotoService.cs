using Avaliacao1ProvaPratica.Models;

namespace Avaliacao1ProvaPratica.Services
{
    public interface IVotoService
    {
        public void adicionarVoto(Voto voto);

       
        public Voto? ObterPorNumeroCandidato(int NumeroVoto);
    }
}
