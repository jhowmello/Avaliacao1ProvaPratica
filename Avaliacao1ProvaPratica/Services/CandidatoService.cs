using Avaliacao1ProvaPratica.Models;
using Avaliacao1ProvaPratica.Repository;

namespace Avaliacao1ProvaPratica.Services
{
    public class CandidatoService : ICandidadtoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public void Adicionar(Candidato novoCandidato)
        {
            var resultado = _candidatoRepository.ObterCandidatoNumero(novoCandidato.numerocadidato);
            if (resultado == null)
            {
                throw new Exception("Esse candidato já existe");
            }
            _candidatoRepository.adicionarCandidatos(novoCandidato);
        }

        public Candidato? ObiterCandidadtoNumero(int numeroCandidato)
        {
            return _candidatoRepository.ObterCandidatoNumero(numeroCandidato);
        }
        public List<Candidato> ObterTodosCandidatos()
        {
            return new List<Candidato>();
        }

    }
}
