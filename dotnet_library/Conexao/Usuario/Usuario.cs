using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Usuario
{
   public class Usuario : IUsuario 
    {


        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public void InserirUsuario(string nome, string email, string senha)
        {
            string query = $@"insert into tb_usuario (nome, email, senha)
                          values ('{nome}', '{email}','{senha}');";

            MySqlConnection conexaoMySQL = new MySqlConnection(conexao);
            try
            {
                conexaoMySQL.Open();
                MySqlCommand comando = new (query, conexaoMySQL);
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoMySQL.Close();
            }
        }

        public bool VerificarEmailUsuario(string email)
        {
            bool emailUsuarioValido = false;

            string query = $@"select * from tb_usuario
            where email = '{email}'";

            MySqlConnection conexaoMySql = new MySqlConnection(conexao);
            DataTable dtUsuario = new DataTable();
            try
            {
                conexaoMySql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoMySql);
                adapter.Fill(dtUsuario);

                if(dtUsuario.Rows.Count != 0)
                {
                    emailUsuarioValido = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($@"Erro de conexão", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoMySql.Close();
            }
            return emailUsuarioValido;
        }


        public bool verificaLogin(string email, string senha)
        {
             

        bool usuarioValido = false;
          
            string query = $@"select * from dados_usario where email = '{email}'
                          and
                           senha = '{senha}'";


            MySqlConnection mysql = new MySqlConnection(conexao);
            DataTable dtUsuario = new DataTable();
            try
            {
                mysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mysql);
                adapter.Fill(dtUsuario);

                if (dtUsuario.Rows.Count > 0)
                {
                    usuarioValido = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conexão", "ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                mysql.Close();
            }

            return usuarioValido ;
        }
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }


            return dtGenero;
        }
       

       public void CadastrarLivro(string nome, string autor, string sinopse, string genero)
        {
            string query = $@"insert into dotnet_library.tb_livro(nome,autor,sinopse,id_genero)
           values('{nome}', '{autor}', '{sinopse}','{genero}')";

            MySqlConnection mysql = new MySqlConnection(conexao);

            try
            {
                mysql.Open();
                MySqlCommand executaComando = new MySqlCommand(query, mysql);
                executaComando.ExecuteNonQuery();
                MessageBox.Show($"Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    
    }
}
