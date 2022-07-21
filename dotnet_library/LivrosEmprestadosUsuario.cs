using dotnet_library.Conexao.Cliente;
using dotnet_library.Conexao.Livros;
using dotnet_library.LivrosEmprestados;
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
    public partial class LivrosEmprestadosUsuario : Form
    {
        private int idLivro;
        public LivrosEmprestadosUsuario(int idLivro)
        {
          this.idLivro = idLivro;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
          
            DateTime dataVencimento = monthCalendar1.SelectionStart.ToUniversalTime();

            ILivrosEmprestados livrosEmprestados = new LivrosEmprestimo();
            
        }

        private void Verifica_cliente(object sender, EventArgs e)
        {
            txtNomeFuncionario.Text = SessaoUsuario.Nome;

            ICliente cliente = new Cliente();
            cbxCliente.Items.Clear();
            cbxCliente.DataSource = cliente.RetornaDadosCliente();
            cbxCliente.DisplayMember = "nome";
            cbxCliente.ValueMember = "id";
            
            
        }
    }
    
}
