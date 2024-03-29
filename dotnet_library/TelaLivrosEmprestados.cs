﻿using dotnet_library.Conexao.Livros;
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
    public partial class TelaLivrosEmprestados : Form
    {
        public TelaLivrosEmprestados()
        {
            InitializeComponent();
        }

        private void TelaLivrosEmprestados_Load(object sender, EventArgs e)
        {
            ILivro livrosEmprestados = new Livro();
            DataTable tabelaLivrosEmprestados = livrosEmprestados.BuscarLivrosEmprestados();

            dgvLivrosEmprestados.DataSource = tabelaLivrosEmprestados;
        }

        private void TelaLivrosEmprestados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Tela_Auxiliar_Emprestimo tela_Auxiliar_Emprestimo = new Tela_Auxiliar_Emprestimo();
            tela_Auxiliar_Emprestimo.ShowDialog();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            ILivro livro = new Livro();

            string? id = dgvLivrosEmprestados.SelectedRows[0].Cells[0].Value.ToString();

            var resposta = DialogResult;

            resposta = MessageBox.Show($@"Deseja realmente devolver o livro?", "ATENÇÃO!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            

            if (resposta == DialogResult.Yes)
            {
                livro.DevolverLivro(id);

                this.Dispose();

                TelaLivrosEmprestados telaLivrosEmprestados = new TelaLivrosEmprestados();

                telaLivrosEmprestados.ShowDialog();

              
            }
            else
            {
                this.Dispose();

                TelaLivrosEmprestados telaLivrosEmprestados = new TelaLivrosEmprestados();
                telaLivrosEmprestados.ShowDialog();
                
            }

        }
    }
}
