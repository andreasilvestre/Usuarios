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

        //string conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";

        private void carregarListView()
        {

            List<Usuario> listaUsuario = new List<Usuario>();

            listaUsuario = Usuario.gerarListaUsuarios();

            listView_Usuarios.Items.Clear();
            int contador = 0;
            foreach ( Usuario i in listaUsuario)
            {
                listView_Usuarios.Items.Add(i.IdUsuario.ToString());
                listView_Usuarios.Items[contador].SubItems.Add(i.Nome);
                listView_Usuarios.Items[contador].SubItems.Add(i.Email);
                contador++;
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
            //MessageBox.Show("Nome: " + usuario.Nome + "\nEmail: " + usuario.Email);
            usuario.gravarUsuario();
            carregarListView();

        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            //lembre que o remover está relacionado com ListView e a região
            //selecionada

            Usuario.removerUsuario(int.Parse(listView_Usuarios.SelectedItems[0].Text));

            //recarregar ListView
            carregarListView();

        }
    }
}
