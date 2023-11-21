using LarTeste_WebAPI.Domain.Models.Commons;

namespace LarTeste_WebAPI.Domain.Models.Output
{
    public class PessoaOutputModel: PessoaCommon
    {

        public PessoaOutputModel()
        { }

        public PessoaOutputModel(string nome, string cpf, DateTime dataNascimento, string email,int ativo)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Email = email;
            Ativo = ativo;
        }
    }
}
