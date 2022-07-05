using dotnet_library.Conexao.Usuario;
using dotnet_library.Utilitarios.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library
{
    public partial class CadastroLivro : Form
    {
        public CadastroLivro()
        {
            InitializeComponent();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            IUsuario usuarios = new Usuario();

            string nome = txtNomeLivro.Text;
            string autor = txtAutor.Text;
            string sinopse = txtSinopse.Text;
            var genero = cbxGenero.SelectedValue.ToString();


            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(autor) && !string.IsNullOrEmpty(sinopse) && !string.IsNullOrEmpty(genero))
            {
                usuarios.CadastrarLivro(nome, autor, sinopse, genero);
            }
            else
            {
                MessageBox.Show("Erro senha Inválida!");
            }
        }

        private void CadastroLivro_Load(object sender, EventArgs e)
        {
            string query = $@"select id, nome from dotnet_library.tb_genero order by id";

            IUsuario usuario = new Usuario();

            cbxGenero.Items.Clear();
            cbxGenero.DataSource = usuario.BuscarGenero();
            cbxGenero.DisplayMember = "nome";
            cbxGenero.ValueMember = "id";
        }

        private void btnCancelarCadastroLivro_Click(object sender, EventArgs e)
        {
            txtNomeLivro.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtSinopse.Text = string.Empty;
            cbxGenero.Text = string.Empty;

        }
    }

}
