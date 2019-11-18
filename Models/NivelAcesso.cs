using Microsoft.AspNetCore.Identity;

namespace Locar.Models
{
    public class NivelAcesso : IdentityRole
    {
        public string DescricaoNivelAcesso { get; set; }
    }
}