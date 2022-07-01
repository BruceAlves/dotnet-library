using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Usuario
{
   public interface IUsuario
    {
         bool verificaLogin(string email, string senha);
    }
}
