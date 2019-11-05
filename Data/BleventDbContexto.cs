using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blevent.Data
{
    public class BleventDbContexto : IdentityDbContext
    {


        public BleventDbContexto(DbContextOptions<BleventDbContexto> options)
            : base(options)
        {
        }
    }
}
