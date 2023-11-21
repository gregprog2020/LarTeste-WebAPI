using LarTeste_WebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Infra.Context;

namespace LarTeste_WebAPI.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbSet<UsuarioEntity> _dbSet;
        private readonly APIDbContext _context;

        public UserRepository(APIDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<UsuarioEntity>();
        }

        public async Task<bool> RegistraNovoUsuarioAsync(UsuarioEntity newUser)
        {
            try
            {
                await _dbSet.AddAsync(newUser);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> ChecaUsuarioExisteAsync(string nome)
        {
            try
            {
                return await _dbSet.AnyAsync(x => x.Nome == nome);
            }
            catch
            {
                return true;
            }
        }



        public async Task<T> GetUsuarioPorNome<T>(Expression<Func<UsuarioEntity, T>> expression, string Nome)
            => await _dbSet.Where(x => x.Nome == Nome).Select(expression).FirstOrDefaultAsync();
    }
}

