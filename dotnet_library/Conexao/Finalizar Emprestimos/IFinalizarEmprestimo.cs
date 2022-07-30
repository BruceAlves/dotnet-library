using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Finalizar_Emprestimos
{
    interface IFinalizarEmprestimos
    {
        DataTable BuscarCliente();
    }
}
