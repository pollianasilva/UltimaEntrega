using ViagensAgencia.Enums;

namespace ViagensAgencia.Models
{
    public class ViagemModel
    {
        public int Id { get; set; }
        public string? Destino { get; set; }

        public StatusViagem Status { get; set; }

        public int? UsuarioId { get; set; }

        public virtual UsuarioModel? Usuario { get; set; }
    }
}
