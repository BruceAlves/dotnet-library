using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Usuario
{
    public interface IUsuario
    {
        void InserirUsuario(string nome, string email, string senha);

        bool VerificarEmailUsuario(string email);

        bool VerificaLogin(string email, string senha);

        void CriarNovaSenha(string email, string novaSenha);
     


    }
}
