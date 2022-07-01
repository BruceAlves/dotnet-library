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
