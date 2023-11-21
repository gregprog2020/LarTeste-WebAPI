using LarTeste_WebAPI.Domain.Interfaces.Repositories;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Infra.Repositories;
using LarTeste_WebAPI.Services;

namespace LarTeste_WebAPI.Infra.CrossCutting
{
    public static class CrossDependency
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            ConfiguringServices(services);
            ConfiguringRepositories(services);
            
            return services;
        }
        private static void ConfiguringServices(IServiceCollection services)
        {
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ITelefoneService, TelefoneService>();
            services.AddTransient<IPessoaService, PessoaService>();            
        }

        private static void ConfiguringRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
        }
    }
}
