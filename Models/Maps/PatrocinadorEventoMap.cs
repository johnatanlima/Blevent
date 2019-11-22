using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blevent.Models.Maps
{
    public class PatrocinadorEventoMap : IEntityTypeConfiguration<PatrocinadorEvento>
    {
        public void Configure(EntityTypeBuilder<PatrocinadorEvento> builder)
        {
            builder.ToTable("Patrocinador_Evento");

            builder.HasKey(k => k.PatrocinadorEventoId).HasName("pk_PatrocinadorEventoId");

            builder.Property(p => p.ValorPatrocinado).HasColumnType("decimal(9,2)").IsRequired();

            builder.HasOne(x => x.EventoVirtual)
                .WithMany(x => x.PatrociniosValor)
                .HasForeignKey(x => x.EventoId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasOne(x => x.PatrocinadorVirtual)
                .WithMany(x => x.PatrociniosValor)
                .HasForeignKey(x => x.PatrocinadorId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}