using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Emprestimo
{
    public interface IEmprestimos
    {
        DataTable BuscarLivrosDisponiveis();
        void RegistrarEmprestimo(DateTime dataDevolucao, int idUsuario, int idLivro, int idCliente);
        void MarcarLivroIndisponivel(int idlivro);

    }
}
