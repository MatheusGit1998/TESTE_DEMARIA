using System;
using System.IO;
using Newtonsoft.Json;
using Npgsql;

namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{
    public class DadosFormulario
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
    }

    public class TesteCon
    {
        private string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados_form.json");

        // CARREGA JSON COM DADOS DA CONEXÃO
        public DadosFormulario CarregarDados()
        {
            if (!File.Exists(caminho))
                throw new FileNotFoundException("Arquivo JSON não encontrado: " + caminho);

            string json = File.ReadAllText(caminho);
            return JsonConvert.DeserializeObject<DadosFormulario>(json);
        }

        //MONTA STRING DE CONEXÃO
        public string GetConnectionString()
        {
            var dados = CarregarDados();

            return $"Host={dados.Host};Port={dados.Port};Username={dados.Username};Password={dados.Password};Database={dados.Database}";
        }

        //TESTA A CONEXÃO
        public void TestarConexao()
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