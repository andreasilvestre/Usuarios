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
        int idUsuario;
        string nome;
        string email;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public Usuario(string nome)
        {     
            this.Nome = nome;
            gerarEmail();
            
        }

        public Usuario(string nome, string email, int id)
        {
            this.idUsuario = id;
            this.nome = nome;
            this.email = email;
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

        public static bool removerUsuario(int idUsuario)
        {

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao(); //open

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "Delete from usuario where idUsuario=@idUsuario;";
            command.Parameters.AddWithValue("@idUsuario", idUsuario);

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
        public static List<Usuario> gerarListaUsuarios()
        {

            List<Usuario> listaUsuarios = new List<Usuario>();

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from usuario;";

            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                //listView_Usuarios.Items.Clear();
               

                int i = 0;
                while (leitor.Read())
                {
                    listaUsuarios.Add(new Usuario(leitor["nomeCompleto"].ToString(), leitor["email"].ToString(), int.Parse(leitor["idUsuario"].ToString())));
                    i++;
                }
            }
            catch (Exception erro)
            {
                //não sei
                //throw;
            }

            finally
            {
                banco.fecharConexao();
            }
            return listaUsuarios;
        }
    }
}