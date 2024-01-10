using Microsoft.EntityFrameworkCore;
using ViagensAgencia.Data;
using ViagensAgencia.Models;
using ViagensAgencia.Repositorios.Interfaces;

namespace ViagensAgencia.Repositorios
{
    public class ViagemRepositorio : IViagemRepositorio
    {
        private readonly ViagensAgenciaDBContex _dbContext;
        public ViagemRepositorio(ViagensAgenciaDBContex viagensAgenciaDBContex)
        {
            _dbContext = viagensAgenciaDBContex;
        }
        public async Task<ViagemModel> BuscarPorId(int id)
        {
            var viagem = await _dbContext.Viagens
                .Include(x => x.Usuario)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (viagem == null)
            {            
                throw new Exception($"Viagem para o ID: {id} não foi encontrada no banco de dados.");
            }

            return viagem;
        }

        public async Task<List<ViagemModel>> BuscarTodasViagens()
        {
            return await _dbContext.Viagens
                .Include(x => x.Usuario)
                .ToListAsync();
        }

        public async Task<ViagemModel> Adicionar(ViagemModel viagem)
        {
            await _dbContext.Viagens.AddAsync(viagem);
            await _dbContext.SaveChangesAsync();
            return viagem;
        }
        public async Task<ViagemModel> Atualizar(ViagemModel viagem, int id)
        {
            ViagemModel viagemPorId = await BuscarPorId(id);
            if (viagemPorId == null)

            {
                throw new Exception($"Viagem para o ID: {id} Não foi encontrada no banco de dados.");
            }
            viagemPorId.Destino = viagem.Destino;
            viagemPorId.Status = viagem.Status;
            viagemPorId.UsuarioId = viagem.UsuarioId;
            

            _dbContext.Viagens.Update(viagemPorId);
            await _dbContext.SaveChangesAsync();

            return viagemPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            ViagemModel viagemPorId = await BuscarPorId(id);

            if (viagemPorId == null)

            {
                throw new Exception($"Viagem para o ID: {id} Não foi encontrada no banco de dados.");
            }

            _dbContext.Viagens.Remove(viagemPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

      
    }
}
