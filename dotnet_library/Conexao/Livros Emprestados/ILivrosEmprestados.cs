using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Livros_Emprestados
{
    interface ILivrosEmprestados
    {
        void EmprestarLivro(DateTime dataDevolucao, int idLivro, int idCliente );

        DataTable LivrosEmprestados();
    }
}
