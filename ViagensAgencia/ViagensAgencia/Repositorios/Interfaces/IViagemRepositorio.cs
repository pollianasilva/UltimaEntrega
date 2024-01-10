using ViagensAgencia.Models;

namespace ViagensAgencia.Repositorios.Interfaces
{
    public interface IViagemRepositorio
    {
        Task<List<ViagemModel>> BuscarTodasViagens();
        Task<ViagemModel> BuscarPorId(int id);
        Task<ViagemModel> Adicionar(ViagemModel viagem);
        Task<ViagemModel> Atualizar(ViagemModel viagem, int id);
        Task<bool> Apagar(int id);
    }
}
