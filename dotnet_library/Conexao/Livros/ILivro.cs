using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Livros
{
   public interface ILivro
    {
        DataTable BuscarGenero();
        void CadastrarLivro(string nome, string autor, string sinopse, string genero);

        DataTable BuscarLivrosEmprestados();

        void DevolverLivro(string id);
    }
}
