using System.ComponentModel.DataAnnotations;
using Blevent.Models;

namespace Blevent.Models.ViewModels
{
    public class PatrocinadorEventoViewModel{
        
        [DataType(DataType.Currency, ErrorMessage="Informe um valor válido!")]
        [Display(Description="Valor do patrocínio")]
        [Required(ErrorMessageResourceName = "Este campo é obrigatório!")]
        public decimal ValorPatrocinado {get; set;}

        [Display(Description = "Informe qual evento")]
        public string EventoId { get; set; }
        
        [Display(Description = "Informe qual patrocinador")]
        public string PatrocinadorId { get; set; }
       
    }
}