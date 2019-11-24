using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blevent.Models{
    public class Patrocinador{

        public Patrocinador()
        {
            PatrociniosValor = new HashSet<PatrocinadorEvento>();
        }
        
        [Display(Description = "ID - Patrocinador")]
        public int PatrocinadorId { get; set; }

        [Display(Description = "Nome")]
        public string  Nome { get; set; }

        [Display(Description = "Nº telefone")]
        public string Telefone { get; set; }
        
        public ICollection<PatrocinadorEvento> PatrociniosValor {get; set;}

    }
}