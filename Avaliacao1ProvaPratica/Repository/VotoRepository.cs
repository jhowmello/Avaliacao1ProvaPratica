using Avaliacao1ProvaPratica.Models;

namespace Avaliacao1ProvaPratica.Repository
{
    public class VotoRepository : IVotoRepository

    {
        private static List<Voto> votos = new List<Voto>();

        public void adicionarVoto(Voto voto)
        {
           votos.Add(voto);
        }

        public Voto? ObterPorNumeroCandidato(int NumeroVoto)
        {
            return votos.FirstOrDefault(a => a.NumeroVoto == NumeroVoto);
        }
    }
}
