using LarTeste_WebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LarTeste_WebAPI.Infra.Configuration
{
    public class UsuarioEntityConfiguration : IEntityTypeConfiguration<UsuarioEntity>
    {
        public UsuarioEntityConfiguration()
        { }
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("int");
            builder.Property(x => x.Nome).HasColumnName("Nome").HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.Senha).HasColumnName("Senha").HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.Roles).HasColumnName("Roles").HasColumnType("nvarchar(MAX)");
        }
    }
}
