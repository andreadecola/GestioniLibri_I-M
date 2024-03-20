using Prestiti_Libri.Classes;
using Prestiti_Libri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.DAL
{
    internal class PrestitoDAL:Idal<Prestito>
    {
        private static PrestitoDAL? instanza;

        public static PrestitoDAL getIstanza()
        {
            if (instanza == null)
                instanza = new PrestitoDAL();

            return instanza;
        }

        public bool Delete(Prestito t)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Prestito t)
        {
            throw new NotSupportedException();
        }

        public bool Update(Prestito t)
        {

            throw new NotSupportedException();
        }

        public List<Prestito> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
