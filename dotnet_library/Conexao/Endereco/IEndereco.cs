﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Conexao.Endereco
{
    public interface IEndereco
    {
        int CadastrarEndereco(string cep, string rua,string bairro,string cidade,string estado,string numero);
    }
}
