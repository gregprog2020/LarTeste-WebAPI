using LarTeste_WebAPI.Domain.Entities;
using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Domain.Models.Response;

namespace LarTeste_WebAPI.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository, IPessoaRepository pessoaRepository)
        {
            _telefoneRepository = telefoneRepository;
            _pessoaRepository = pessoaRepository;
        }
        public async Task<ResultModel<string>> RegistraNovoTelefoneAsync(NovoTelefoneInputModel input)
        {
            var result = new ResultModel<string>();

            var telefoneExists = await _telefoneRepository.ChecaTelefoneExisteAsync(input.Numero);
            if (telefoneExists)
                return result.AddError(result.Error);

            var statusRegister = await _telefoneRepository.RegistraNovoTelefoneAsync(new TelefoneEntity(input));
            if (statusRegister)
                return result.AddResult(result.Result);

            return result.AddError(result.Error);
        }
        
    }
}
