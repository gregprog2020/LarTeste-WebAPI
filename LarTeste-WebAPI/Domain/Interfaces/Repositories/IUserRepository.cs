using LarTeste_WebAPI.Domain.Entities;
using System.Linq.Expressions;

namespace LarTeste_WebAPI.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<bool> ChecaUsuarioExisteAsync(string nome);
        Task<bool> RegistraNovoUsuarioAsync(UsuarioEntity usuario);
        Task<T> GetUsuarioPorNome<T>(Expression<Func<UsuarioEntity, T>> expression, string nome);
    }
}
