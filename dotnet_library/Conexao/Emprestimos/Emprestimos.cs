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

    
    public class Emprestimos : IEmprestimos
    {
        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public DataTable BuscarLivrosDisponiveis()
        {            
            string query = $@"SELECT tb_livro.id as 'código' , tb_livro.nome, tb_livro.autor, tb_livro.sinopse, tb_genero.nome  as 'genêro' FROM tb_livro
            INNER JOIN tb_genero
            ON tb_livro.id_genero = tb_genero.id
            where disponivel = 1;";

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

        public void MarcarLivroIndisponivel(int idlivro)
        {
            string update = $@"UPDATE tb_livro
             SET disponivel = '0'
             WHERE id = {idlivro};";

            MySqlConnection conexaoMySql = new MySqlConnection( conexao);

            try
            {
                conexaoMySql.Open();

                MySqlCommand executorComando = new MySqlCommand(update, conexaoMySql);
                executorComando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco!!", $"Erro!{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexaoMySql.Close();
            }

        }

        public void RegistrarEmprestimo(DateTime dataDevolucao, int idUsuario, int idLivro, int idCliente)
        {
            string query = $@"insert into tb_emprestismo (data_emprestimo, data_devolucao, id_usuario, id_livro, id_cliente)
              values
             (sysdate(), '{dataDevolucao.ToString("yyyy-mm-dd")}', {idUsuario}, {idLivro}, {idCliente});";

            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            

            try
            {
                conexaoMysql.Open();
                MySqlCommand comando = new MySqlCommand(query, conexaoMysql);
                comando.ExecuteNonQuery();

                MessageBox.Show("inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:\n{ex.Message}", "Erro Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoMysql.Close();
            }
        }
    }
}
