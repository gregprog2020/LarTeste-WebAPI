using LarTeste_WebAPI.Domain.Entities;
using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Domain.Models.Output;
using LarTeste_WebAPI.Infra.Context;
using LarTeste_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LarTeste_WebAPI.Infra.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly APIDbContext _context;
        private readonly DbSet<PessoaEntity> _dbSet;

        public PessoaRepository(APIDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<PessoaEntity>();
        }

        public async Task CommitAsync()
            => await _context.SaveChangesAsync();

        public async Task<bool> RegistraNovaPessoaAsync(PessoaEntity pessoa)
        {
            try
            {
                await _dbSet.AddAsync(pessoa);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> ChecaPessoaExisteAsync(string nome)
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
        public async Task<PessoaOutputModel> GetPessoaPorIdAsync(int id)
            => await _dbSet.Where(x => x.Id == id)
                           .Select(x => new PessoaOutputModel(x.Nome, x.CPF, x.DataNascimento, x.Email, x.Ativo))
                           .FirstOrDefaultAsync();

        public async Task<List<PessoaOutputModel>> GetPessoaPorNomeAsync(string nomePessoa)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                if (!string.IsNullOrWhiteSpace(nomePessoa))
                    query = query.Where(x => x.Nome.ToLower().Contains(nomePessoa.ToLower()));

                return await query.Select(x => new PessoaOutputModel(x.Nome, x.CPF, x.DataNascimento, x.Email, x.Ativo))
                                  .ToListAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
