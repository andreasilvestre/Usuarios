using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    internal class Usuario
    {
        string nome;
        string email;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }

        public Usuario(string nome)
        {     
            this.Nome = nome;
            gerarEmail();
            
        }

        private void gerarEmail()
        {
            string[] vetorNome;
            vetorNome = this.Nome.Split(' ');
            this.Email = vetorNome[0] + "." + vetorNome[vetorNome.Length - 1] + "@ufn.edu.br";
            this.Email = this.Email.ToLower();
        }

        public bool gravarUsuario()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into usuario values (@nomeCompleto, @email);";
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = this.Nome;
            command.Parameters[1].Value = this.Email;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

    }
}