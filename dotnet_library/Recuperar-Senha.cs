using dotnet_library.Conexao.Livros;
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
    public partial class Recuperar_Senha : Form
    {

        public Recuperar_Senha()
        {
            InitializeComponent();
        }

        private void btnComfirmarCodigo_Click(object sender, EventArgs e)
        {
            bool validacao = ComfirmarCodigo(txtCodigo.Text);

            if (validacao == true)
            {
                txtCriarSenha.Enabled = true;
                txtComfirmarSenha.Enabled = true;
                btnComfirmar.Enabled = true;
                groupComfirmarSenha.Visible = true;

            }
            else
            {
                MessageBox.Show("Por favor tente novamente", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private bool ComfirmarCodigo(string codigo)
        {
            bool codigoValido = false;

            if (codigo == SessaoUsuario.CodigoRecuperacao)
            {
                codigoValido = true;
            }
            else
            {
                codigoValido = false;
            }
            return codigoValido;
        }

        private void btnComfirmar_Click_1(object sender, EventArgs e)
        {

            if (txtCriarSenha.Text == txtComfirmarSenha.Text)
            {
                IUsuario usuario = new Usuario();
                usuario.CriarNovaSenha(SessaoUsuario.Email!, txtComfirmarSenha.Text);

                this.Dispose();
                Login login = new Login();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("As senha não comferem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

