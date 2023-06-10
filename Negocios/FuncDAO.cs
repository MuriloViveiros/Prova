using Dapper;
using Prova.Mapeamento;
using Prova.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Negocios
{
    public class FuncDAO : Conexao
    {
        public List<Func> ListarFunc()

        {
            return conexao.Query<Func>("SELECT Nome,Telefone,Setor FROM Funcionarios order by Nome").ToList();
        }
    }
}
    

