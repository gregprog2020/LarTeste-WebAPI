using LarTeste_WebAPI.Infra.Configuration;
using Microsoft.EntityFrameworkCore;

namespace LarTeste_WebAPI.Infra.Context
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TelefoneEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaEntityConfiguration());

        }
    }

}
