using Microsoft.AspNetCore.Identity;

namespace Blevent.Models
{
    public class NivelAcesso : IdentityRole
    {
        public string DescricaoNivelAcesso { get; set; }
    }
}