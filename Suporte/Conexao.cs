using System.Configuration;
using System.Data.SqlClient;
namespace Prova.Suporte
{
    public class Conexao
    {
        public SqlConnection conexao = null;
        public Conexao()
        {
            
       conexao = new SqlConnection(
       ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
        }
    }
}