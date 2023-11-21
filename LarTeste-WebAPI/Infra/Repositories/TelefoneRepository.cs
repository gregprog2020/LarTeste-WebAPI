using LarTeste_WebAPI.Domain.Entities;
using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LarTeste_WebAPI.Infra.Repositories
{
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly APIDbContext _context;
        private readonly DbSet<TelefoneEntity> _dbSet;

        public TelefoneRepository(APIDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TelefoneEntity>();
        }
            
        public async Task<bool> RegistraNovoTelefoneAsync(TelefoneEntity telefone)
        {
            try
            {
                await _dbSet.AddAsync(telefone);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> ChecaTelefoneExisteAsync(string numero)
        {
            try
            {
                return await _dbSet.AnyAsync(x => x.Numero == numero);
            }
            catch
            {
                return true;
            }
        }
        /*public async Task<TelefoneOutputModel> GetTelefoneIdAsync(int id)
            => await _dbSet.Where(x => x.Id == id)
                           .Select(x => new TelefoneOutputModel(x.Numero, x.Tipo, x.PessoaId))
                           .FirstOrDefaultAsync();

        public async Task<List<TelefoneOutputModel>> GetTelefoneListByIdAsync(int id)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                if (!string.IsNullOrWhiteSpace(name))
                    query = query.Where(x => x.Name.ToLower().Contains(name.ToLower()));

                return await query.Where(x => x.Status == ProductStatusEnum.Active).Select(x => new TelefoneOutputModel(x.Name, x.Description, x.Price, x.Stock))
                                  .ToListAsync();
            }
            catch
            {
                return null;
            }
        }*/
    }
}
