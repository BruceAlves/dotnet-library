using dotnet_library.Conexao.Livros_Emprestados;
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
    public partial class TelaLivrosEmprestados : Form
    {
        public TelaLivrosEmprestados()
        {
            InitializeComponent();
        }

        private void TelaLivrosEmprestados_Load(object sender, EventArgs e)
        {
            ILivrosEmprestados livrosEmprestados = new LivrosEmprestados();
            DataTable tabelaLivrosEmprestados = livrosEmprestados.BuscarLivrosEmprestados();

            dgvLivrosEmprestados.DataSource = tabelaLivrosEmprestados;
        }

        private void TelaLivrosEmprestados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Tela_Auxiliar_Emprestimo tela_Auxiliar_Emprestimo = new Tela_Auxiliar_Emprestimo();
            tela_Auxiliar_Emprestimo.ShowDialog();
        }
    }
}
