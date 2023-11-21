using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace LarTeste_WebAPI.Infra.Context
{
    public static class ContextConfiguration
    {
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<APIDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DBConnection")));
           
            return services;
        }
    }
}
