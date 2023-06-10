using Dapper;
using Prova;
using Prova.Suporte;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace Prova
{
    public class UsuariosDAO : Conexao
    {  
        public Usuario Login(string nome, string senha)
        {
            return conexao.Query<Usuario>("SELECT * FROM Usuarios WHERE Nome=@pNome AND Senha = @pSenha",
           
            new
            {
                @pNome = nome,
                @pSenha = senha
            }).SingleOrDefault();
        }

        public void Salvar(string nome, string senha)
        {
            conexao.Execute("INSERT INTO Usuarios (Nome, Senha) VALUES (@Nome, @Senha)",
            new { nome, senha });
        }

    }
}
