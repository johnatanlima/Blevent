using Blevent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blevent.Data
{
    public class BleventDbContexto : IdentityDbContext
    {
        
        public DbSet<Evento> Usuarios {get; set;}
        public DbSet<NivelAcesso> NiveisAcesso {get; set;}
        public DbSet<Evento> Eventos {get; set;}
        public DbSet<Realizador> Realizadores {get; set;}
        public DbSet<Patrocinador> Patrocinadores {get; set;}
        public DbSet<PatrocinadorEvento> PatrocinadoresEventos{get; set;}
      
        public BleventDbContexto(DbContextOptions<BleventDbContexto> options)
            : base(options)
        {
        }
    }
}
