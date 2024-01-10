using Microsoft.EntityFrameworkCore;
using ViagensAgencia.Data.Map;
using ViagensAgencia.Models;

namespace ViagensAgencia.Data
{
    public class ViagensAgenciaDBContex : DbContext
    {
        public ViagensAgenciaDBContex(DbContextOptions<ViagensAgenciaDBContex> options)
            : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ViagemModel> Viagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ViagemMap());

            base.OnModelCreating(modelBuilder);
        }

    }

}


