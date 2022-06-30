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

            IviaCep endereco = new ViaCep();
            Endereco? resposta = endereco.EnderecoViaCep(txtCep.Text);

            if (!string.IsNullOrEmpty(resposta?.Rua))
            {
                txtRua.Text = resposta?.Rua;
                txtRua.Enabled = false;
            }
            
            
            txtBairro.Text = resposta?.Bairro;

            
            txtBairro.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            
            
        }
    }
}
