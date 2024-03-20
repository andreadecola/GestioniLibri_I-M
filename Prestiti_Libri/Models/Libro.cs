using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.Classes
{
    internal class Libro
    {
        public Libro(DateTime annopubblicazione, string? titolo, bool isDisponibilità)
        {
            Annopubblicazione = annopubblicazione;
            Titolo = titolo;
            IsDisponibilità = isDisponibilità;
        }

        public DateTime Annopubblicazione {  get; set; }

        public string? Titolo { get; set; }

        public bool IsDisponibilità { get; set; }
    }
}
