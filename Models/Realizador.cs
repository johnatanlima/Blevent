using System.Collections.Generic;

namespace Blevent.Models
{
    public class Realizador{

        public Realizador()
        {
            Eventos = new HashSet<Evento>();
        }

        public int RealizadorId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public ICollection<Evento> Eventos {get; set;} 
    }
}