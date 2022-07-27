using dotnet_library.Conexao.Usuario;
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
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_MouseHover(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.DodgerBlue;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.White;
        }

        private void btnLimpar_MouseHover(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.DodgerBlue;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.White;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DodgerBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool nomeVazio = string.IsNullOrEmpty(txtNome.Text);
            bool emailVazio = string.IsNullOrEmpty(txtEmail.Text);
            bool senhaVazio = string.IsNullOrEmpty(txtSenha.Text);

            if (nomeVazio || emailVazio || senhaVazio)
            {
                MessageBox.Show($@"Um ou mais campos não foram preenchidos!", "O cadastro não pôde ser realizado!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IUsuario verificar = new Usuario();
                bool teste = verificar.VerificarEmailUsuario(txtEmail.Text);
                if (teste)
                {
                    MessageBox.Show($@"O usuário já está cadastrado!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    IUsuario usuario = new Usuario();
                    usuario.InserirUsuario(txtNome.Text, txtEmail.Text, txtSenha.Text);

                    MessageBox.Show($@"Cadastro efetuado com sucesso!", "Parabens!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void Cadastro_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();

            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
