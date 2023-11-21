using LarTeste_WebAPI.Domain.Entities;

namespace LarTeste_WebAPI.Domain.Interfaces.Repositories
{
    public interface ITelefoneRepository
    {
        Task<bool> RegistraNovoTelefoneAsync(TelefoneEntity telefone);
        Task<bool> ChecaTelefoneExisteAsync(string numero);

    }
}
