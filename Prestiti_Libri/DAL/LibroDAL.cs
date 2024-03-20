using Prestiti_Libri.Classes;
using Prestiti_Libri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.DAL
{
    internal class LibroDAL :Idal<Libro>
    {
        private static LibroDAL? instanza;

        public static LibroDAL getIstanza()
        {
            if (instanza == null)
                instanza = new LibroDAL();

            return instanza;
        }

        public bool delete(Libro t)
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetAll(Libro t)
        {
            throw new NotImplementedException();
        }

        public bool insert(Libro t)
        {
            throw new NotImplementedException();
        }

        public bool update(Libro t)
        {
            throw new NotImplementedException();
        }
    }
}
