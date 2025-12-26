using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Npgsql;

namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{

    public class ConexaoBD
    {
        private string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados_form.json");

        //CARREGA JSON COM OS DADOS DA CONEXÃO
        public DadosFormulario CarregarDados()
        {
            if (!File.Exists(caminho))
            {
                throw new FileNotFoundException("Arquivo JSON não encontrado: " + caminho);
            }


            string json = File.ReadAllText(caminho);
            return JsonConvert.DeserializeObject<DadosFormulario>(json);
        }

        //MONTA STRING DA CONEXAO
        public string GetConnectionString()
        {
            var dados = CarregarDados();

            return $"Host={dados.Host};Port={dados.Port};Username={dados.Username};Password={dados.Password};Database={dados.Database}";
        }

        //TESTE DE CONEXAO
        public void ConexaoSQL()
        {
            string connString = GetConnectionString();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                Console.WriteLine("Conexão com PostgreSQL realizada com sucesso!");
            }
        }

    }
}
