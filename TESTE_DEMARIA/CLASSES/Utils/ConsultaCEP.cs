using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TESTE_DEMARIA.CLASSES.Utils
{
    internal class ConsultaCEP
    {

        public class Endereco
        {
            public string logradouro { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string cep { get; set; }
        }

        public class BuscaCEP
        {
            private static readonly HttpClient client = new HttpClient();

            public async Task<Endereco> ObterEnderecoAsync(string cep)
            {
                cep = cep.Replace("-", "").Trim();

                if (cep.Length != 8)
                    return null;

                string url = $"https://viacep.com.br/ws/{cep}/json/";

                var response = await client.GetStringAsync(url);

                var endereco = JsonConvert.DeserializeObject<Endereco>(response);

                return endereco;
            }
        }

    }
}
