using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Utilitarios
{
    internal interface IViaCep
    {
        EnderecoViaCep? EnderecoViaCep(string cep);

        bool ValidarCep(string cep);

        bool ValidarNumero(string numero);
    }
}
