using dotnet_library.Conexao.Emprestimo;
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
    public partial class LivrosDisponíveis : Form
    {
        public LivrosDisponíveis()
        {
            InitializeComponent();
        }

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            ILivrosDisponíveis emprestimos = new Conexao.Emprestimo.LivrosDisponíveis();
           DataTable tabelaDisponiveis = emprestimos.BuscarLivrosDisponiveis();

            dgvLivros.DataSource = tabelaDisponiveis;
          
        }

        private void LivrosDisponíveis_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Tela_Auxiliar_Emprestimo tela_Auxiliar_Emprestimo = new Tela_Auxiliar_Emprestimo();
            tela_Auxiliar_Emprestimo.ShowDialog();
        }
    }
}
