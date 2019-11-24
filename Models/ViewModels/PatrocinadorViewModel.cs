using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blevent.Models.ViewModels{
    public class PatrocinadorViewModel{
    
        [Display(Description = "Nome")]
        public string  Nome { get; set; }

        [Display(Description = "Nº telefone")]
        public string Telefone { get; set; }
        
        [Display(Description = "Valores de patrocío")]
        public ICollection<PatrocinadorEvento> PatrociniosValor {get; set;}

    }
}