using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.Classes
{
    internal class Prestito
    {
        public Prestito(DateTime dataInizioPrestito, DateTime dataFinePrestito)
        {
            DataInizioPrestito = dataInizioPrestito;
            DataFinePrestito = dataFinePrestito;
        }

        public DateTime DataInizioPrestito { get; set; }

        public DateTime DataFinePrestito { get; set; }



    }
}
