using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Livros_Emprestados
{
    class LivrosEmprestados : ILivrosEmprestados
    {
        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public DataTable EmprestarLivro()
        {            

            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            DataTable dtLivrosDisponiveis = new DataTable();

            try
            {
                conexaoMysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoMysql);
                adapter.Fill(dtLivrosDisponiveis);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Conexão",$"Erro:\n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexaoMysql.Close();
            }

            return dtLivrosDisponiveis;
        }
    }
}
