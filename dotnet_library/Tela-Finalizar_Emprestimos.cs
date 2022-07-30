using dotnet_library.Conexao.Cliente;
using dotnet_library.Conexao.Emprestimo;
using dotnet_library.Conexao.Livros;
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
    public partial class Tela_Finalizar_Emprestimos : Form
    {
        private int idLivro;

        public Tela_Finalizar_Emprestimos(string id, string nome)
        {
            InitializeComponent();
            txtLivro.Text = nome;

            idLivro = Convert.ToInt32(id);
        }

        private void Tela_Finalizar_Emprestimos_Load(object sender, EventArgs e)
        {
            ICliente clientes = new Cliente();

            txtFuncionario.Text = SessaoUsuario.Nome;
            txtData.Text = DateTime.Now.Date.ToShortDateString();

            cbxClientes.Items.Clear();
            cbxClientes.DataSource = clientes.BuscarCliente();
            cbxClientes.DisplayMember = "nome";
            cbxClientes.ValueMember = "id";
        }

        private void Tela_Finalizar_Emprestimos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();

            LivrosDisponíveis livrosDisponíveis = new LivrosDisponíveis();
            livrosDisponíveis.ShowDialog();
        }

        private void btnComfirmar_Click(object sender, EventArgs e)
        {
            DateTime dataDevolucao = mcDataDevolucao.SelectionStart.Date;
            int idCliente = Convert.ToInt32(cbxClientes.SelectedValue.ToString());

            IEmprestimos emprestimos = new Emprestimos();
            emprestimos.RegistrarEmprestimo(dataDevolucao, SessaoUsuario.Id,idLivro,idCliente);
            emprestimos.MarcarLivroIndisponivel(idLivro);

            this.Dispose();

            LivrosDisponíveis livrosDisponíveis = new LivrosDisponíveis();
            livrosDisponíveis.ShowDialog();


        }
    }
}
