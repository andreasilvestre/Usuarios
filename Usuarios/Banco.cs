﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace Usuarios
//{
//    public class Banco
//    {
//        //private string stringConexao = "Data Source=localhost; Initial Catalog=ATOSUFN; User ID=usuario; password='senha';language=Portuguese";
//        string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";

//        private SqlConnection cn;

//        private void conexao()//vincular a string com o cn, bm inicia o CN
//        {
//            cn = new SqlConnection(stringConexao);
//        }

//        public SqlConnection abrirConexao()
//        {
//            try
//            {
//                //tentar fazer algo
//                conexao();
//                cn.Open();

//                return cn;
//            }
//            catch (Exception ex)
//            {
//                //faz algo se deu erro
//                return null;
//            }
//        }

//        public void fecharConexao()
//        {
//            try
//            {
//                cn.Close();
//            }
//            catch (Exception ex)
//            {
//                return;
//            }
//        }

//        public DataTable executarConsultaGenerica(string sql)
//        {
//            try
//            {
//                abrirConexao();

//                SqlCommand command = new SqlCommand(sql, cn);
//                command.ExecuteNonQuery();

//                SqlDataAdapter adapter = new SqlDataAdapter(command);

//                DataTable dt = new DataTable();
//                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

//                return dt;
//            }
//            catch (Exception ex)
//            {
//                return null;
//            }
//            finally
//            {
//                fecharConexao();
//            }
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

//namespace SimplesWindowsFormsBanco
namespace Usuarios
{
    public class Banco
    {
        //para conexao sql interprise
        //private string stringConexao = "Data Source=localhost; Initial Catalog=ATOSUFN; User ID=usuario; password='senha';language=Portuguese";
        //string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ATOSUFN;TrustServerCertificate=True;Integrated Security=True";
        string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";

        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();
                //MessageBox.Show("conexão deu certo ");
                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                //MessageBox.Show("erro de conexão: " + ex);
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}