using System.ComponentModel;

namespace ViagensAgencia.Enums
{
    public enum StatusViagem
    {
        [Description("Aguardando Pagamento")]
        AFazer = 1,
        [Description("Processando Pagamento")]
        EmAndamento = 2,
        [Description("Pagamento Concluído")]
        Concluido = 3,
    }
}
