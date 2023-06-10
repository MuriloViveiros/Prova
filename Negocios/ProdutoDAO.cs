using Dapper;
using Prova.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
   
    
        public class ProdutoDAO : Conexao
        {

            public void Adicionar(string produto, decimal valor, string linha)
            {
                conexao.Execute("INSERT INTO Produtos (Produto, Valor, Linha) VALUES (@Produto, @Valor, @Linha)",
                new { produto, valor, linha });
            }
       
            public void Atualizar( int id, string produto, decimal valor, string linha)
        {
             conexao.Execute("UPDATE Produtos SET Produto=@Produto, Valor=@Valor, Linha=@Linha WHERE ID=@ID",
            new {id, produto, valor, linha});
            }
            
            public void Excluir(int id)
            {
                conexao.Execute("DELETE FROM Produtos WHERE ID=@ID",
                new { id });
            }
            
            public ProdutoM Buscar(int id)
            {
                return conexao.Query<ProdutoM>("SELECT * FROM Produtos WHERE ID=@ID",
                new {@ID=id}).SingleOrDefault(); 
            }
            
             public List<ProdutoM> ListarTodas()

     {
                return conexao.Query<ProdutoM>("SELECT * FROM Produtos").ToList();
        }
    }
}
    

