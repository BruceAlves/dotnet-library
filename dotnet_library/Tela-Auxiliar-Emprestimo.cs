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
    public partial class Tela_Auxiliar_Emprestimo : Form
    {
        public Tela_Auxiliar_Emprestimo()
        {
            InitializeComponent();
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

       

        private void bntLivrosEmprestados_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaLivrosEmprestados telaLivrosEmprestados = new TelaLivrosEmprestados();
            telaLivrosEmprestados.ShowDialog();

        }

        private void bntLivrosDisponiveis_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LivrosDisponíveis livrosDisponíveis = new LivrosDisponíveis();
            livrosDisponíveis.ShowDialog();
        }

        private void Tela_Auxiliar_Emprestimo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
