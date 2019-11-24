using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blevent.Models.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //builder.HasKey(p => p.UsuarioId).HasName("pk_UsuarioId");

            builder.Property(p => p.Nome).HasColumnType("varchar(45)").IsRequired().HasMaxLength(45);

            builder.Property(p => p.Sobrenome).HasColumnType("varchar(45)").IsRequired().HasMaxLength(45);

           // builder.Property(p => p.Email).HasColumnType("varchar(30)").IsRequired().HasMaxLength(30);

            //Props de Navegação e Relacionamentos
            //Geradas automaticamente pelo EF Core

        }
    }
}