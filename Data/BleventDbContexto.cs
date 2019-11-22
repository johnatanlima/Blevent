using Blevent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blevent.Data
{
    public class BleventDbContexto : IdentityDbContext
    {
        
        DbSet<Evento> Usuarios {get; set;}
        DbSet<UsuarioNivelAcesso> NiveisAcesso {get; set;}
        DbSet<Evento> Eventos {get; set;}
        DbSet<Realizador> Realizadores {get; set;}
        //DbSet<Pa> Patrocinadores {get; set;}
        //DbSet<PatrocinadorEvento> PatrocinadoresEventos{get; set;}
      
        public BleventDbContexto(DbContextOptions<BleventDbContexto> options)
            : base(options)
        {
        }
    }
}
