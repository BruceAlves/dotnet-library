using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.LivrosEmprestados
{
  public  class LivrosEmprestimo : ILivrosEmprestados
    {
        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public void InsereDadosEmprestimoLivros()
        {
            string query = ""; //$@"insert into dotnet_library.tb_emprestismo(sysdate,data_devolucao,id_usuario,id_livro,id_cliente)
           //values('{}', '{}', '{}','{}')";

            MySqlConnection mysql = new MySqlConnection(conexao);

            try
            {
                mysql.Open();
                MySqlCommand executaComando = new MySqlCommand(query, mysql);
                executaComando.ExecuteNonQuery();
                MessageBox.Show($"cadastrado efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
