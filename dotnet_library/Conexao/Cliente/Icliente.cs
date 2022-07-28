using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Cliente
{
    public interface ICliente
    {
        DataTable BuscarCliente();
        int CadastrarCliente( string nome, string email);
        DataTable RetornaDadosCliente();

    }
}
