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
            IEmprestimos emprestimos = new Conexao.Emprestimo.Emprestimos();
           DataTable tabelaDisponiveis = emprestimos.BuscarLivrosDisponiveis();

            dgvLivros.DataSource = tabelaDisponiveis;
          
        }

        private void LivrosDisponíveis_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Tela_Auxiliar_Emprestimo tela_Auxiliar_Emprestimo = new Tela_Auxiliar_Emprestimo();
            tela_Auxiliar_Emprestimo.ShowDialog();
        }

        private  void bntEmprestar_Click(object sender, EventArgs e)
        {
            string? id = dgvLivros.SelectedRows[0].Cells[0].Value.ToString();
            string? nome = dgvLivros.SelectedRows[0].Cells[1].Value.ToString();

            this.Dispose();
            Tela_Finalizar_Emprestimos tela_Finalizar = new Tela_Finalizar_Emprestimos(id, nome);
            tela_Finalizar.ShowDialog();

        }
    }
}
