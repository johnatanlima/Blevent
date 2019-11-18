using Locar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blevent.Data
{
    public class BleventDbContexto : IdentityDbContext
    {
        
        DbSet<Usuario> Usuarios {get; set;}
        DbSet<NivelAcesso> NiveisAcesso {get; set;}
        
        public BleventDbContexto(DbContextOptions<BleventDbContexto> options)
            : base(options)
        {
        }
    }
}
