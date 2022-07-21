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
    public partial class Emprestimos : Form
    {
        public Emprestimos()
        {
            InitializeComponent();
        }

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            IEmprestimo emprestimos = new Emprestimo();
           DataTable tabelaEmprestimo = emprestimos.EmprestarLivro();

            dgvLivros.DataSource = tabelaEmprestimo;
          
        }

        private void bntEmprestar_Click(object sender, EventArgs e)
        {

        }
    }
}
