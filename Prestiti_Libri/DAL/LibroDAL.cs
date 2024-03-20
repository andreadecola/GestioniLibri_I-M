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


        public bool Delete(Libro t)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro t)
        {
            throw new NotSupportedException();
        }

        public bool Update(Libro t)
        {

            throw new NotSupportedException();
        }

        public List<Libro> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
