using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_library.Utilitarios
{
    internal class ViaCep : IviaCep
    {

        public EnderecoViaCep? EnderecoViaCep(string cep)
        {
           
            HttpClient cliente = new HttpClient();
            var respostaJson = cliente.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            
            string jsonString = respostaJson.Content.ReadAsStringAsync().Result;


            EnderecoViaCep? resposta = JsonConvert.DeserializeObject<EnderecoViaCep>(jsonString);


            return resposta ;
            
        }
    }
}
