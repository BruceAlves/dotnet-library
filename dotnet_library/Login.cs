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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IUsuario conexao = new Usuario();
            bool usuarioExistente = conexao.VerificaLogin(txtEmail.Text, txtSenha.Text);

            if (usuarioExistente)
            {
                MessageBox.Show("Usuário logado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Hide(); // esconde a tela atual

                Menu menu = new Menu();

                menu.ShowDialog(); // chama a tela instanciada


            }
            else
            {
                MessageBox.Show("Dados inválidos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacao_Senha recuperacao_Senha = new Recuperacao_Senha();
            recuperacao_Senha.Show();
            this.Hide();
        }

      

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
        }
    }
    
}
