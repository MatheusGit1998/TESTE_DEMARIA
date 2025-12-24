using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using TESTE_DEMARIA.CLASSES.BASE_DE_DADOS;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{
    public class FiltrosReportReviewerSQL
    {
        private readonly ConexaoBD _conexao;

        //INICIA UM NOVO COMANDO
        public FiltrosReportReviewerSQL()
        {
            _conexao = new ConexaoBD();
        }
        //INICIA UM CONEXAO COM O BANCO

        public NpgsqlConnection GetConn()
        {
            return new NpgsqlConnection(_conexao.GetConnectionString());
        }

        #region SELECT

        //SELECT PARA OBTER DETALHES DAS VENDAS E ATUALIZAR REPORTVIEWER DE VENDAS COM INTERVALO DE DATAS
        public DataTable ObterDadosDasVendas(DateTime dataInicio, DateTime dataFim)
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                    c.nome AS cliente,
                    v.id_venda AS idvenda,
                    v.data_venda AS datavenda,
                    p.nome AS produto,
                    i.quantidade AS quantidade,
                    i.preco_unitario AS precounitario,
                    (i.quantidade * i.preco_unitario) AS subtotalitem,
                    v.valor_total AS totalvenda
                FROM vendas v
                INNER JOIN cadastro_de_clientes c ON v.cliente_id = c.cliente_id
                INNER JOIN itens_venda i ON v.id_venda = i.id_venda
                INNER JOIN cadastro_de_produtos p ON i.id_produto = p.id_produto
                WHERE v.data_venda BETWEEN @dataInicio AND @dataFim
                ";


                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", dataFim);

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        //SELECT PARA OBTER DETALHES DAS DOS CLIENTES E ATUALIZAR REPORTVIEWER DE CADASTROS CLIENTES

        public DataTable ObterDadosClientes()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                c.*,
                c.data_cadastro AS datacadastro 
                FROM cadastro_de_clientes c
                ";


                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        //SELECT PARA OBTER DETALHES DAS DOS PRODUTOS E ATUALIZAR REPORTVIEWER DE CADASTROS PRODUTOS
        public DataTable ObterDadosProduto()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                    p.*,
                    p.criado_em AS criadoem 
                FROM cadastro_de_produtos p
                ";
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        #endregion

    }
}
