using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_DEMARIA.CLASSES.OBJETOS
{
    public class Produto
    {

        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public int Estoque { get; set; }
        public DateTime Criado_Em { get; set; }
        public bool Ativo { get; set; }


        public Produto() { }
        public Produto(string nome, string descricao, float valor, int estoque, DateTime criado_em)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Estoque = estoque;
            Criado_Em = criado_em;
            Ativo = true;
        }
    }
}
