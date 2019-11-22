using Microsoft.AspNetCore.Identity;

namespace Blevent.Models
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; }

        public string Sobrenome {get; set;}

        public string Senha {get; set;}
    }
}