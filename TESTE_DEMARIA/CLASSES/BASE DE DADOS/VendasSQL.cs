using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{
    public class VendasSQL
    {

        private readonly ConexaoBD _conexao;
        public VendasSQL()
        {
            _conexao = new ConexaoBD();
        }

        #region INSERT
        //INSERT PARA REGISTRAR VENDA NA BASE VENDAS
        public int RegistrarVendaBase1(int idCliente, float valor)
        {
            const string sqlInsert = @"
            INSERT INTO vendas (
            cliente_id, valor_total
            )
            VALUES (
             @cliente_id, @valor_total
            )
            RETURNING id_venda;
            ";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente_id", idCliente);
                        cmd.Parameters.AddWithValue("@valor_total", valor);

                        int idVenda = Convert.ToInt32(cmd.ExecuteScalar());
                        return idVenda;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar a venda: " + ex.Message);
                return -1;
            }
        }

        //INSERT PARA REGISTRAR VENDA NA BASE ITENS_VENDA
        public void RegistrarVendaBase2(int idVenda, int idProduto, int Quantidade, float valorUni, float valorTotal)
        {
            const string sqlInsert = @"
            INSERT INTO itens_venda (
            id_venda, id_produto, quantidade, preco_unitario, preco_total
            )
            VALUES (
            @id_venda, @id_produto, @quantidade, @preco_unitario, @preco_total
            );";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_venda", idVenda);
                        cmd.Parameters.AddWithValue("@id_produto", idProduto);
                        cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                        cmd.Parameters.AddWithValue("@preco_unitario", valorUni);
                        cmd.Parameters.AddWithValue("@preco_total", valorTotal);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a venda Produto: " + ex.Message);
            }
        }
        #endregion

        #region SELECT
        //SELECT DA BASE VENDAS PARA ATUALIZAR LISTVIEW
        public void CarregarVendas(ListView listView)
        {
            const string sql = @"SELECT id_venda, cliente_id, data_venda, valor_total FROM Vendas";


            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        listView.Items.Clear();

                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["id_venda"].ToString());
                            item.SubItems.Add(reader["cliente_id"].ToString());
                            item.SubItems.Add(reader["data_venda"].ToString());
                            item.SubItems.Add(reader["valor_total"].ToString());

                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }



        //SELECT PARA ATUALIZAR VENDAS TOTAIS TELA HOME
        public decimal ObterTotalDeVendas()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT SUM(valor_total) FROM vendas";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Objeto não pode ser convertido de DBNull em outros tipos.")
                {

                }
                else
                {
                    MessageBox.Show("Erro ao obter total de vendas: " + ex.Message);

                }
                return 0;
            }
        }

        //SELECT PARA ATUALIZAR QUANTIDADE TOTAL DE ITEMS VENDIDOS TELA HOME

        public int ObterQtdItemsVendidos()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT SUM(quantidade) FROM itens_venda;";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Objeto não pode ser convertido de DBNull em outros tipos.")
                {
                   
                }
                else
                {
                    MessageBox.Show("Erro ao obter total de items vendidos ativos: " + ex.Message);
                    
                }
                return 0;
            }
        }
        #endregion
    }
}
