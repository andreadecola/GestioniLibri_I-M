using Prestiti_Libri.Models;
using Prestiti_Libri.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.DAL
{
    internal class UtenteDAL : Idal<Utente>
    {

        private static UtenteDAL? instanza;

        public static UtenteDAL getIstanza()
        {
            if (instanza == null)
                instanza = new UtenteDAL();

            return instanza;
        }

        public  bool Delete(Utente t)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Utente t)
        {
            bool risultato = false;

            using (SqlConnection connection = new SqlConnection(Config.getIstanza().GetConnectionString())
            {

            }
                
        }

        public bool Update(Utente t) { 
            
            throw new NotSupportedException();
        }

        public List<Utente> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
