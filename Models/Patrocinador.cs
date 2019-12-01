using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blevent.Models{
    public class Patrocinador{

        public Patrocinador()
        {
            PatrociniosValor = new HashSet<PatrocinadorEvento>();
        }
        
        public int PatrocinadorId { get; set; }

        public string  Nome { get; set; }

        public string Telefone { get; set; }
        
        public ICollection<PatrocinadorEvento> PatrociniosValor {get; set;}

    }
}