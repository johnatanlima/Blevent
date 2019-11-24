using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Blevent.Models
{
    public class NivelAcesso : IdentityRole
    {
        [Display(Description = "Definição Nível Acesso")]
        public string DescricaoNivelAcesso { get; set; }
    }
}