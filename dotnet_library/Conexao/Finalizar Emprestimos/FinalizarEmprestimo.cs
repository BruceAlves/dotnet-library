using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Finalizar_Emprestimos
{
    class FinalizarEmprestimo : IFinalizarEmprestimos
    {

        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;
        public DataTable BuscarCliente()
        {
            string select = $@"select id, nome from dotnet_library.tb_cliente order by id;";


            DataTable tbclientes = new DataTable();


            MySqlConnection mySql = new MySqlConnection(conexao);

            try
            {
                mySql.Open();
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(select, mySql);
                adapter.Fill(tbclientes);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro de conexão", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }

            return tbclientes;
           
        }
    }
}
