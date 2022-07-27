using dotnet_library.Conexao.Livros;
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
            ILivro livro = new Livro();

            string nome = txtNomeLivro.Text;
            string autor = txtAutor.Text;
            string sinopse = txtSinopse.Text;
            var genero = cbxGenero.SelectedValue.ToString();


            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(autor) && !string.IsNullOrEmpty(sinopse) && !string.IsNullOrEmpty(genero))
            {
                livro.CadastrarLivro(nome, autor, sinopse, genero);
            }
            else
            {
                MessageBox.Show("Erro campos não preenchidos !");
            }
        }

        private void CadastroLivro_Load(object sender, EventArgs e)
        {           

            ILivro livro = new Livro();

            cbxGenero.Items.Clear();
            cbxGenero.DataSource = livro.BuscarGenero();
            cbxGenero.DisplayMember = "nome";
            cbxGenero.ValueMember = "id";
        }

        private void btnCancelarCadastroLivro_Click(object sender, EventArgs e)
        {
            txtNomeLivro.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtSinopse.Text = string.Empty;
          
        }

        private void txtNomeLivro_Enter(object sender, EventArgs e)
        {
            txtNomeLivro.Text = string.Empty;
        }

        private void txtAutor_Enter(object sender, EventArgs e)
        {
            txtAutor.Text = string.Empty;
        }

        private void txtSinopse_Enter(object sender, EventArgs e)
        {
            txtSinopse.Text = string.Empty;
        }

        private void CadastroLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }

}
