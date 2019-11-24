using System.ComponentModel.DataAnnotations;

namespace Blevent.Models.ViewModels
{
    public class UsuarioViewModel
    {   
        [Required(ErrorMessage="Esse campo é obrigatório!")]
        [DataType(DataType.Text)]
        [Display(Description = "Primeiro nome")]
        public string Nome {get; set;}

        [Required(ErrorMessage="Esse campo é obrigatório!")]
        [DataType(DataType.Text)]
        [Display(Description = "Último nome")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage="Esse campo é obrigatório!")]
        [DataType(DataType.Text)] 
        [Display(Description = "Nome de usuário/login")]
        public string NomeUsuario { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage="Informe uma expressao de email válida!")]
        [Display(Description = "Email")]
        public string Email { get; set; }
        

        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage="Obseve o número de caracteres!")]
        [Display(Description= "Senha")]
        public string Senha { get; set; }

    }
}