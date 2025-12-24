using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_DEMARIA.CLASSES.OBJETOS
{
    public class Venda
    {

        public int IdVenda { get; set; }
        public int IdItem { get; set; }
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorSubTotal { get; set; }



        public Venda() { }
        public Venda(int idvenda, int iditem, int quantidade, float valortotal, float valorunitario, float valorsubtotal)
        {
            IdVenda = idvenda;
            IdItem = iditem;
            Quantidade = quantidade;
            ValorTotal = valortotal;
            ValorUnitario = valorunitario;
            ValorSubTotal = valorsubtotal;
        }
    }
}
