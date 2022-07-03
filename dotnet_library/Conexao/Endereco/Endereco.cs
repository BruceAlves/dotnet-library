using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library.Conexao.Endereco
{
    public class Endereco : IEndereco
    {
        

         private readonly string conexao = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;


        public int CadastrarEndereco(string cep, string rua, string bairro, string cidade, string estado, string numero)
        {
            int idEndereco = 0;
          
            MySqlConnection mySql = new MySqlConnection(conexao);

            try
            {
                string insertEndereco =
               $@"insert into tb_endereco (cep, rua, bairro, cidade, estado, numero )
                values (@cep, @rua, @bairro, @cidade, @estado, @numero) ;";

                mySql = new MySqlConnection(conexao);
                MySqlCommand cmd = new MySqlCommand(insertEndereco, mySql);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@numero", numero);
                mySql.Open();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));
                idEndereco = Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco tb_Endereço!!", $"Erro!{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }
            return idEndereco;
        }
    }
}
