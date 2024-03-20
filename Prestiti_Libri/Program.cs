using Prestiti_Libri.DAL;
using Prestiti_Libri.Models;

namespace Prestiti_Libri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente utente = new Utente()
            {
                Nome = "Ciccio",
                Cognome = "Bello",
                Email = "ciccio@bello.it"
            };
            Console.WriteLine(UtenteDAL.getIstanza().insert(utente)? "Funziona": "Non Funziona");
        }
    }
}
