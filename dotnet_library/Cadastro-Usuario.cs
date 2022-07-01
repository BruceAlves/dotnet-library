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
            this.Hide();
        }
    }
}
