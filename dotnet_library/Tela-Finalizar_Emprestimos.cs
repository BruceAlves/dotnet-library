using dotnet_library.Conexao.Finalizar_Emprestimos;
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
        public Tela_Finalizar_Emprestimos()
        {
            InitializeComponent();
        }

        private void Tela_Finalizar_Emprestimos_Load(object sender, EventArgs e)
        {
            IFinalizarEmprestimos clientes = new FinalizarEmprestimo();

            cbxClientes.Items.Clear();
            cbxClientes.DataSource = clientes.BuscarCliente();
            cbxClientes.DisplayMember = "nome";
            cbxClientes.ValueMember = "id";
        }
    }
}
