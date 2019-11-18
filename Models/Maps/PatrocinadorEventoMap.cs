using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCore04.Models.Maps
{
    public class PatrocinadorEventoMap : IEntityTypeConfiguration<PatrocinadorEvento>
    {
        public void Configure(EntityTypeBuilder<PatrocinadorEvento> builder)
        {
            builder.ToTable("Patrocinador_Evento");

            builder.HasKey(k => k.PatrocinadorValorId).HasName("pk_PatrocinadorEventoId");

            builder.Property(p => p.ValorPatrocinado).HasColumnType("decimal(9,2)").IsRequired();

            builder.HasOne(x => x.EventoVirtual).WithMany(x => x.PatrociniosValor).OnDelete(DeleteBehavior.SetNull).HasForeignKey(x => x.EventoId);
            builder.HasOne(x => x.PatrocinadorVirtual).WithMany(x => x.PatrociniosValor).OnDelete(DeleteBehavior.SetNull).HasForeignKey(x => x.PatrocinadorId);
            
            //Props de Navegação e Relacionamentos
            //Geradas automaticamente pelo EF Core

        }
    }
}