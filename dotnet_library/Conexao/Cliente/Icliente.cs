using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Cliente
{
    public interface ICliente
    {
        int CadastrarCliente( string nome, string email); 
    }
}
