using LarTeste_WebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LarTeste_WebAPI.Infra.Configuration
{
    public class PessoaEntityConfiguration : IEntityTypeConfiguration<PessoaEntity>
    {
        public PessoaEntityConfiguration()
        { }

        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            builder.ToTable("Pessoas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("int");
            builder.Property(x => x.Nome).HasColumnName("Nome").HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.CPF).HasColumnName("CPF").HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.DataNascimento).HasColumnName("DataNascimento").HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar");
            builder.Property(x => x.Ativo).HasColumnName("Ativo").HasColumnType("bit").IsRequired();
        }
    }
}
