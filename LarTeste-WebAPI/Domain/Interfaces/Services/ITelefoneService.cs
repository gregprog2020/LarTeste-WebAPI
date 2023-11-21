using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Domain.Models.Response;

namespace LarTeste_WebAPI.Domain.Interfaces.Services
{
    public interface ITelefoneService
    {
        Task<ResultModel<string>> RegistraNovoTelefoneAsync(NovoTelefoneInputModel input);
        
        
    }

}
