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

        public bool delete(Prestito t)
        {
            throw new NotImplementedException();
        }

        public List<Prestito> GetAll(Prestito t)
        {
            throw new NotImplementedException();
        }

        public bool insert(Prestito t)
        {
            throw new NotImplementedException();
        }

        public bool update(Prestito t)
        {
            throw new NotImplementedException();
        }
    }
}
