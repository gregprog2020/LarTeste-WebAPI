using LarTeste_WebAPI.Models;

namespace LarTeste_WebAPI.Repositories
{
    public static class UserRepositoryOLD
    {
        public static Usuario Get(string nome, string senha)
        {
            var usuarios = new List<Usuario>();
            usuarios.Add(new Usuario { Id = 1, Nome = "admin", Senha = "123456", Roles = "admin" });
            usuarios.Add(new Usuario { Id = 2, Nome = "usuario", Senha = "888888", Roles = "usuario" });
            return usuarios.Where(x => x.Nome.ToLower() == nome.ToLower() && x.Senha == x.Senha).FirstOrDefault();
        }
    }


}
