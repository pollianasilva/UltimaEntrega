using Microsoft.EntityFrameworkCore;
using ViagensAgencia.Data;
using ViagensAgencia.Models;
using ViagensAgencia.Repositorios.Interfaces;

namespace ViagensAgencia.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ViagensAgenciaDBContex _dbContext;
        public UsuarioRepositorio(ViagensAgenciaDBContex viagensAgenciaDBContex)
        {
            _dbContext = viagensAgenciaDBContex;
        }
        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            var usuario = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

            if (usuario == null)
            {            
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            return usuario;
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }


        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }
        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
           UsuarioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)

            {
                throw new Exception($"Usuário para o ID: {id} Não foi encontrado no banco de dados.");
            }
            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Cpf = usuario.Cpf;
            usuarioPorId.Endereco = usuario.Endereco;
            usuarioPorId.Email = usuario.Email;
            usuarioPorId.Senha = usuario.Senha;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)

            {
                throw new Exception($"Usuário para o ID: {id} Não foi encontrado no banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

      
    }
}
