using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Livros
{
  public  class Livro : ILivro
    {
        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public DataTable BuscarGenero()
        {

            string query = $@"select id, nome from dotnet_library.tb_genero order by id";

            DataTable dtGenero = new DataTable();

            MySqlConnection mySql = new MySqlConnection(conexao);

            try
            {
                mySql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySql);
                adapter.Fill(dtGenero);
            }
            catch (Exception )
            {
                MessageBox.Show("Erro de conexão", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }


            return dtGenero;
        }

        public DataTable BuscarLivrosEmprestados()
        {
            string query = $@"select id,nome,autor,sinopse from dotnet_library.tb_livro
            where disponivel = 0";

            DataTable dtLivrosEmprestados = new DataTable();

            MySqlConnection mySql = new MySqlConnection(conexao);

            try
            {
                mySql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySql);
                adapter.Fill(dtLivrosEmprestados);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao realizar a busca", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }
            return dtLivrosEmprestados;
        }

        public void CadastrarLivro(string nome, string autor, string sinopse, string genero)
        {
            string query = $@"insert into dotnet_library.tb_livro(nome,autor,sinopse,id_genero,disponivel)
           values('{nome}', '{autor}', '{sinopse}','{genero}', '1')";

            MySqlConnection mysql = new MySqlConnection(conexao);

            try
            {
                mysql.Open();
                MySqlCommand executaComando = new MySqlCommand(query, mysql);
                executaComando.ExecuteNonQuery();
                MessageBox.Show($"Livro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o Banco de dados", $"erro\n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                mysql.Close();
            }
        }

        public void DevolverLivro(string id)
        {
            string query = $@"update dotnet_library.tb_livro set disponivel = 1
             where id = {id};";

            MySqlConnection mysql = new MySqlConnection(conexao);

            try
            {
                mysql.Open();
                MySqlCommand comando = new MySqlCommand(query, mysql);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Devolução Efetuada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão com o Banco de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                mysql.Close();
            }
        }
    }
}
