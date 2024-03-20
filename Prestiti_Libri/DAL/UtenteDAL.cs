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

    

        public bool insert(Utente t)
        {
            bool risultato = false;

            using (SqlConnection connection = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Utente(nome,cognome,email) VALUES (@nome,@cognome,@email)";
                cmd.Parameters.AddWithValue("@nome", t.Nome);
                cmd.Parameters.AddWithValue("@cognome", t.Cognome);
                cmd.Parameters.AddWithValue("@email", t.Email);

                try
                {
                    connection.Open();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return risultato;
            };
        }

        public List<Utente> GetAll(Utente t)
        {
            throw new NotImplementedException();
        }

        public bool delete(Utente t)
        {
            throw new NotImplementedException();
        }

        public bool update(Utente t)
        {
            throw new NotImplementedException();
        }
    }
}
