using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Emprestimo
{

    
    public class Emprestimo : IEmprestimo
    {
        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public DataTable EmprestarLivro()
        {            

            string query = $@"SELECT tb_livro.nome, tb_livro.autor, tb_livro.sinopse, tb_genero.nome FROM tb_livro
            INNER JOIN tb_genero
            ON tb_livro.id_genero = tb_genero.id;";

            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            DataTable telaLivros = new DataTable();

            try
            {
                conexaoMysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoMysql);
                adapter.Fill(telaLivros);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Banco de Dados", $"Erro:\n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoMysql.Close();
            }

            return telaLivros;
        }
    }
}
