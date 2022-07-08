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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastroUsuario_MouseHover(object sender, EventArgs e)
        {
            btnCadastroUsuario.BackColor = Color.DodgerBlue;
        }

        private void btnCadastroUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnCadastroUsuario.BackColor = Color.White;
        }

        private void btnCadastroCliente_MouseHover(object sender, EventArgs e)
        {
            btnCadastroCliente.BackColor = Color.DodgerBlue;
        }

        private void btnCadastroCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCadastroCliente.BackColor = Color.White;
        }

        private void btnCadastrarLivro_MouseHover(object sender, EventArgs e)
        {
            btnCadastrarLivro.BackColor = Color.DodgerBlue;
        }

        private void btnCadastrarLivro_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarLivro.BackColor = Color.White;
        }

        private void btnEmprestimos_MouseHover(object sender, EventArgs e)
        {
            btnEmprestimos.BackColor = Color.DodgerBlue;
        }

        private void btnEmprestimos_MouseLeave(object sender, EventArgs e)
        {
            btnEmprestimos.BackColor = Color.White;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.DodgerBlue;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Cadastro_Usuario cadastroUsuario = new Cadastro_Usuario();
            cadastroUsuario.Show();
            this.Hide();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cadastroCliente = new Cadastro_Cliente();
            cadastroCliente.Show();
            this.Hide();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            CadastroLivro cadastroLivro = new CadastroLivro();
            cadastroLivro.Show();
            this.Hide();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            Emprestimos emprestimos = new Emprestimos();
            emprestimos.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            DialogResult resultado = MessageBox.Show(@$"Deseja realizar o Logout?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
           if(resultado == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }

    
    }
}
