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

       
    }
}
