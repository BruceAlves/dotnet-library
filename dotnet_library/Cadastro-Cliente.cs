using dotnet_library.Conexao.Cliente;
using dotnet_library.Conexao.Endereco;
using dotnet_library.Utilitarios;
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
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Sair(object sender, EventArgs e)
        {
            int cepLength = txtCep.Text.Length;

            IViaCep cepValido = new ViaCep();
            var respostaCepValido = cepValido.ValidarCep(txtCep.Text);

            if (cepLength != 8)
            {
                MessageBox.Show("Cep Inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCamposEspecificos();
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
                txtRua.Enabled = false;
            }
            else if (respostaCepValido == false)
            {
                MessageBox.Show("Cep Inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCamposEspecificos();
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
                txtRua.Enabled = false;
            }

            else
            {
                IViaCep endereco = new ViaCep();
                EnderecoViaCep? resposta = endereco.EnderecoViaCep(txtCep.Text);

                if (!string.IsNullOrEmpty(resposta?.Rua))
                {
                    txtRua.Text = resposta?.Rua;
                    txtRua.Enabled = false;
                }
                else
                {
                    txtRua.Enabled = true;
                    txtRua.Text = string.Empty;
                }

                if (!string.IsNullOrEmpty(resposta?.Bairro))
                {
                    txtBairro.Text = resposta?.Bairro;
                    txtBairro.Enabled = false;
                }
                else
                {
                    txtBairro.Enabled = true;
                    txtBairro.Text = string.Empty;
                }

                if (!string.IsNullOrEmpty(resposta?.Cidade))
                {
                    txtCidade.Text = resposta?.Cidade;
                    txtCidade.Enabled = false;
                }
                else
                {
                    txtCidade.Enabled = true;
                    txtCidade.Text = string.Empty;
                }

                if (!string.IsNullOrEmpty(resposta?.Estado))
                {
                    txtEstado.Text = resposta?.Estado;
                    txtEstado.Enabled = false;
                }
                else
                {
                    txtEstado.Enabled = true;
                    txtEstado.Text = string.Empty;
                }

            }

        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            IViaCep numeroValido = new ViaCep();
            var respostaNumeroValido = numeroValido.ValidarNumero(txtNumero.Text);

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtRua.Text) || string.IsNullOrEmpty(txtNumero.Text) || txtNumero.Text.Contains('a') || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtCep.Text) || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtRua.Text) || string.IsNullOrEmpty(txtNumero.Text) || respostaNumeroValido == false || txtNumero.Text.Contains('a') || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtCep.Text) || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("O campo Número não pode conter letras ou caracteres!","ERRO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNumero.Text = string.Empty;
            }
            else
            {

                ICliente clienteCadastro = new Cliente();
                int idCliente = clienteCadastro.CadastrarCliente(txtNome.Text, txtNome.Text);

                IEndereco cadastrandoEndereco = new Endereco();
                int idEndereco = cadastrandoEndereco.CadastrarEndereco(txtCep.Text, txtRua.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtNumero.Text);

                IClienteEndereco inserirId = new ClienteEndereco();
                inserirId.InserirID(idCliente, idEndereco);

                LimparTudo();

            }

        }

        private void Cadastro_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();

        }

        void LimparTudo()
        {
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtRua.Text = string.Empty;
        }

        void LimparCamposEspecificos()
        {
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtRua.Text = string.Empty;
        }

    }
}
