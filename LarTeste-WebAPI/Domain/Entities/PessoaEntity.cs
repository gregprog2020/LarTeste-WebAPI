using LarTeste_WebAPI.Domain.Models.Input;
using Microsoft.AspNetCore.Components.Forms;

namespace LarTeste_WebAPI.Domain.Entities
{
    public class PessoaEntity
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Email { get; private set; }
        public int Ativo { get; private set; }

       /* public List<string> TelefoneNumeros { get; private set; }*/

        public PessoaEntity()
        { }

        public PessoaEntity(NovaPessoaInputModel input)
        {
            Nome = input.Nome;
            CPF = input.CPF;
            DataNascimento = input.DataNascimento;
            Email = input.Email;
            Ativo = input.Ativo;
        }

    }
}
