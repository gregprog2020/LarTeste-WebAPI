using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Domain.Models.Output;
using LarTeste_WebAPI.Domain.Models.Response;

namespace LarTeste_WebAPI.Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        Task<ResultModel<string>> RegistraNovaPessoaAsync(NovaPessoaInputModel input);
        Task<ResultModel<List<PessoaOutputModel>>> GetPessoaPorNomeAsync(string nome);
        Task<ResultModel<PessoaOutputModel>> GetPessoaPorIdAsync(int id);
        
    }
}
