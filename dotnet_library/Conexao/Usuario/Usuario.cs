using dotnet_library.Conexao.Livros;
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
                MySqlCommand comando = new(query, conexaoMySQL);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
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

                if (dtUsuario.Rows.Count != 0)
                {
                    emailUsuarioValido = true;
                }
            }
            catch (Exception)
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


        public bool VerificaLogin(string email, string senha)
        {


            bool usuarioValido = false;

            string query = $@"select * from tb_usuario where email = '{email}'
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
                    SessaoUsuario.Id = Convert.ToInt32(dtUsuario.Rows[0]["id"]);
                    SessaoUsuario.Email = dtUsuario.Rows[0]["email"].ToString();
                    SessaoUsuario.Nome = dtUsuario.Rows[0]["nome"].ToString();
                    SessaoUsuario.Senha = dtUsuario.Rows[0]["senha"].ToString();

                    usuarioValido = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mysql.Close();
            }

            return usuarioValido;
        }

        

        public void CriarNovaSenha(string email, string novaSenha)
        {           

            string query = $@"update dotnet_library.tb_usuario set senha = {novaSenha} 
             where email = '{email}';";

            MySqlConnection mysql = new MySqlConnection(conexao);

            try
            {
                mysql.Open();
                MySqlCommand comando = new MySqlCommand(query, mysql);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Não se esqueça de anota-la em algum lugar.", "Sua senha foi alterada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
