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

namespace dotnet_library.Conexao.Cliente
{
    public class Cliente : ICliente
    {       
        public readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;

        public DataTable BuscarCliente()
        {
            throw new NotImplementedException();
        }

        public int CadastrarCliente( string nome, string email)
        {
            int idCliente = 0;
            
            MySqlConnection mySql = new MySqlConnection(conexao);            

            try
            {
                string comandoInsert =
                $@"insert into tb_cliente (nome, email)
                      values (@nome, @email);";
              
                MySqlCommand cmd = new MySqlCommand(comandoInsert,mySql);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email",email);
                mySql.Open();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));
                idCliente = Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);


                MessageBox.Show($"Cliente {nome} foi Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco!!", $"Erro!{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }

            return idCliente;
           
        }

        

        DataTable ICliente.RetornaDadosCliente()
        {
            string query = $@"select id, nome from dotnet_library.tb_cliente order by id";

            DataTable dtCliente = new DataTable();

            MySqlConnection mySql = new MySqlConnection(conexao);

            try
            {
                mySql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySql);
                adapter.Fill(dtCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }
            return dtCliente;
        }
    }
}
