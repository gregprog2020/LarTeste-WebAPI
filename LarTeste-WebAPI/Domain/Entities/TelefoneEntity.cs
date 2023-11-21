using LarTeste_WebAPI.Domain.Enums;
using LarTeste_WebAPI.Domain.Models.Input;

namespace LarTeste_WebAPI.Domain.Entities
{   
    public class TelefoneEntity
    {
        public int Id { get; private set; }
        public string Tipo  { get; private set; }
        public string Numero { get; private set; }
        public int PessoaId {  get; private set; } 

        public TelefoneEntity()
        { }

        public TelefoneEntity(NovoTelefoneInputModel input)
        {
            Numero = input.Numero;
            Tipo = input.Tipo;
            PessoaId = input.PessoaId;
        }
    }
}
