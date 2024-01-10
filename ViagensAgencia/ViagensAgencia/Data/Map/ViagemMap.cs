using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ViagensAgencia.Models;

namespace ViagensAgencia.Data.Map
{
    public class ViagemMap : IEntityTypeConfiguration<ViagemModel>
    {
        public void Configure(EntityTypeBuilder<ViagemModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Destino).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.UsuarioId);

            builder.HasOne(x => x.Usuario);
        }
    }
}
