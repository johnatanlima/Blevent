using System.ComponentModel.DataAnnotations;

namespace Blevent.Models.ViewModels
{
    public class UsuarioViewModel
    {
        [Required]
        public string Nome {get; set;}

        
        public string Sobrenome {get; set;}

        [Required]
        public string NomeUsuario { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Senha {get; set;}


    }
}