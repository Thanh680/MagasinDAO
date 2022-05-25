using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    class Connexion
    {
        private static SqlConnection c;
        private Connexion() { } //Constructeur privé et vide...
        public static SqlConnection getInstance()
        {
            if (c == null)
            {
                string chaineDeConnexion;
                chaineDeConnexion = "Data Source=SRV-APP-2\\SQLSERVERSIO;" +
                "Initial Catalog=NGUYEN;" +
               "Integrated Security=SSPI;" +
               "MultipleActiveResultSets=true;"
               ;
                try
                {
                    c = new SqlConnection(chaineDeConnexion);
                    c.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion :" + ex.Message);
                }
            }
            return c;
        }
    }
}
