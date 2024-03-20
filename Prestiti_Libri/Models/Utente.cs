using Prestiti_Libri.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.Models
{
    internal class Utente  
    {
        public Utente()
        {
        }

        public Utente(string? nome, string? cognome, string? email)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
        }

        public string? Nome { get; set; }

        public string? Cognome { get; set;}

        public string? Email { get; set;}
    }
}
