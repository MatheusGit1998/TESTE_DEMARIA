using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_DEMARIA.CLASSES.OBJETOS
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public bool Ativo { get; set; }

        public Cliente() { }
        public Cliente(string nome, string email, string telefone, string cpf, string logradouro, string numero, string complemento, string bairro, string localidade, string uf, string cep)
        {
            Nome = nome;    
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;   
            Localidade = localidade;
            Uf = uf;
            Cep = cep;
            Ativo = true;
        }
    }
}
