using LarTeste_WebAPI.Domain.Models.Input;

namespace LarTeste_WebAPI.Domain.Entities
{
    public class UsuarioEntity    
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Roles { get; private set; }

        public UsuarioEntity()
        { }
        public UsuarioEntity(NovoUsuarioInputModel input)
        {
            Nome = input.Nome;
            Senha = input.Senha;
            Roles = input.Roles;
        }
    }
}
