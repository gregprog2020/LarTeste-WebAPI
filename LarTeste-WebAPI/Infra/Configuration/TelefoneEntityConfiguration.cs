using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LarTeste_WebAPI.Domain.Entities;

namespace LarTeste_WebAPI.Infra.Configuration
{
    public class TelefoneEntityConfiguration : IEntityTypeConfiguration<TelefoneEntity>
    {
        public void Configure(EntityTypeBuilder<TelefoneEntity> builder)
        {
            builder.ToTable("Telefones");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("int");
            builder.Property(x => x.Tipo).HasColumnName("Tipo").HasColumnType("nvarchar");
            builder.Property(x => x.Numero).HasColumnName("Numero").HasColumnType("nvarchar");
            builder.Property(x => x.PessoaId).HasColumnName("PessoaId").HasColumnType("int");
            
        }
    }
}

