using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dotnet_library.Utilitarios
{
    internal class ViaCep : IViaCep
    {

        public EnderecoViaCep? EnderecoViaCep(string cep)
        {
           
            HttpClient cliente = new HttpClient();
            var respostaJson = cliente.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            
            string jsonString = respostaJson.Content.ReadAsStringAsync().Result;


            EnderecoViaCep? resposta = JsonConvert.DeserializeObject<EnderecoViaCep>(jsonString);


            return resposta ;
            
        }

        public bool ValidarCep(string cep)
        {
            var regex = new Regex(@"^\d{8}");

            return regex.IsMatch(cep);
        }

        public bool ValidarNumero(string numero)
        {
            var regex = new Regex (@"^[a - zA - Z] +$");
            return regex.IsMatch(numero);
        }
    }
}
