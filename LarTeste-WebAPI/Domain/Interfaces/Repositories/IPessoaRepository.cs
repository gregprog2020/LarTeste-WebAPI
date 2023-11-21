using LarTeste_WebAPI.Domain.Entities;

namespace LarTeste_WebAPI.Domain.Interfaces.Repositories
{
    public interface IPessoaRepository
    {
        Task CommitAsync();
        Task<bool> RegistraNovaPessoaAsync(PessoaEntity pessoa);
        Task<bool> ChecaPessoaExisteAsync(string nome); 
        Task<bool> GetPessoaPorNomeAsync(string nomePessoa);
        Task<bool> GetPessoaPorIdAsync(int id);


    }
}
