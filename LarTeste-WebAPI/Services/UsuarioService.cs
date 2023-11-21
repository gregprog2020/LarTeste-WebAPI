using LarTeste_WebAPI.Domain.Entities;
using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Domain.Models.Response;

namespace LarTeste_WebAPI.Services
{
    public class UsuarioService : IUsuarioService
    { 
        private readonly IUserRepository _usuarioRepository;
        public UsuarioService(IUserRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<ResultModel<string>> RegistraNovoUsuarioAsync(NovoUsuarioInputModel input)
        {
            var result = new ResultModel<string>();

            var usuarioExists = await _usuarioRepository.ChecaUsuarioExisteAsync(input.Nome);
            if (usuarioExists)
                return result.AddError(result.Error);

            var statusRegister = await _usuarioRepository.RegistraNovoUsuarioAsync(new UsuarioEntity(input));
            if (statusRegister)
                return result.AddResult(result.Result);

            return result.AddError(result.Error);
        }
    }
}
