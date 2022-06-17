using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Usuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private string conexaoString = ConfigurationManager.ConnectionStrings["UsuariosDBString"].ConnectionString;
        //private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        string conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";


        private void carregarListView()
        {
            ////string conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";

            //SqlConnection conexao = new SqlConnection(conexaoString);
            //conexao.Open();

            ////string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
            //string sqlTexto = "select idUsuario, nomeCompleto, email from usuario";
            //SqlCommand comando = new SqlCommand(sqlTexto, conexao);



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
                listView_Usuarios.Items.Clear();

                int i = 0;
                while (leitor.Read())
                {
                    listView_Usuarios.Items.Add(leitor["idUsuario"].ToString());
                    listView_Usuarios.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                    listView_Usuarios.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
            }
            catch (Exception erro)
            {

                //throw;
            }

            finally
            {
                banco.fecharConexao();
            }

        }

        private void textBox_NomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Conectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            button_Conectar.Enabled = false;

        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(textBox_NomeCompleto.Text);
            MessageBox.Show("Nome: " + usuario.Nome + "\nEmail: " + usuario.Email);
            //Limpar();
            //usuario.gravarUsuario();
            if (usuario.gravarUsuario().Equals(true))
            {
                MessageBox.Show("Ok - Usuário inserido com sucesso.");
            }
            else
            {
                MessageBox.Show("Erro - Usuário não foi inserido.");
            }
            carregarListView();

        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            //lembre que o remover está relacionado com ListView e a região
            //selecionada

            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idUsuario = int.Parse(listView_Usuarios.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM usuario WHERE idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                //executar sentença SQL
                if (comando.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Removido com sucesso: " + listView_Usuarios.SelectedItems[0].Text);
                }
            }
            catch (Exception erro)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }
    }
}
