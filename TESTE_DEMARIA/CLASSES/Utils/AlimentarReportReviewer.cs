using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_DEMARIA.CLASSES.Utils
{
    internal class AlimentarReportReviewer
    {
        public class Venda
        {
            public string cliente { get; set; }
            public DateTime datavenda { get; set; }
            public int id_venda { get; set; }
            public decimal preco_unitario { get; set; }
            public string produto { get; set; }
            public int quantidade { get; set; }
            public decimal subtotal_item { get; set; }
            public decimal total_venda { get; set; }
        }

    }

    public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public DateTime DataCadastro { get; set; }


    }

    public class Produtos
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
