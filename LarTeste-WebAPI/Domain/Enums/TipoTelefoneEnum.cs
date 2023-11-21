using System.ComponentModel;

namespace LarTeste_WebAPI.Domain.Enums
{
    public enum TipoTelefoneEnum : short
    {
        [Description("Celular")]
        Celular = 1,
        [Description("Comercial")]
        Comercial = 2,
        [Description("Residencial")]
        Residencial = 3
    }
}
