using LarTeste_WebAPI.Domain.Entities;
using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Domain.Models.Output;
using LarTeste_WebAPI.Domain.Models.Response;

namespace LarTeste_WebAPI.Services
{
    public class PessoaService : IPessoaService
    { 
        private readonly IPessoaRepository _pessoaRepository;
        
        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
            
        }

        public async Task<ResultModel<string>> RegistraNovaPessoaAsync(NovaPessoaInputModel input)
        {
            var result = new ResultModel<string>();

            var pessoaExists = await _pessoaRepository.ChecaPessoaExisteAsync(input.Nome);
            if (pessoaExists)
                return result.AddError(result.Error);

            var statusRegister = await _pessoaRepository.RegistraNovaPessoaAsync(new PessoaEntity(input));
            if (statusRegister)
                return result.AddResult(result.Result);

            return result.AddError(result.Error);
        }

        public async Task<ResultModel<PessoaOutputModel>> GetPessoaPorIdAsync(int id)
            => new ResultModel<PessoaOutputModel>().AddResult(await _pessoaRepository.GetPessoaPorIdAsync(id));

        public async Task<ResultModel<List<PessoaOutputModel>>> GetPessoaPorNomeAsync(string nomePessoa)
            => new ResultModel<List<PessoaOutputModel>>().AddResult(await _pessoaRepository.GetPessoaPorNomeAsync(nomePessoa));
    }
}
