using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Cliente
{
    public class ClienteEndereco : IClienteEndereco
    {

        private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public void InserirID(int id_Cliente, int id_Endereco)
        {
            string comandoInsert =
                $@"insert into tb_cliente_endereco (id_cliente, id_endereco)
                      values ('{id_Cliente}', '{id_Endereco}');";

            MySqlConnection conexaoMySql = new MySqlConnection(conexao);

            try
            {
                conexaoMySql.Open();

                MySqlCommand executorComando = new MySqlCommand(comandoInsert, conexaoMySql);
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
    }
}
